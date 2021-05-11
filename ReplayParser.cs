using Heroes.ReplayParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace winratecheck_hots_reddit
{
    class ReplayParser
    {
        public string replayFolder;
        private List<string> _replays;
        public int ReplayCount => _replays.Count();

        public ReplayParser(string replayFolder)
        {
            if (!Directory.Exists(replayFolder))
                throw new Exception($"Invalid replay folder selected: {replayFolder}");

            this.replayFolder = replayFolder;
            _replays = Directory.GetFiles(replayFolder).Where(x => x.Split('.').Last() == "StormReplay").ToList();
        }

        public AggregateStats ParseReplays(BackgroundWorker worker, DoWorkEventArgs e)
        {
            AggregateStats aggregateStats = new AggregateStats();

            int completedCount = 0;

            var cts = new CancellationTokenSource();
            ParallelOptions options = new ParallelOptions();
            options.CancellationToken = cts.Token;
            options.MaxDegreeOfParallelism = Environment.ProcessorCount;

            Parallel.ForEach(_replays, options, replay =>
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    cts.Cancel();
                }
                (var result, bool success) = parseReplay(replay);
                if (success)
                    aggregateStats.allParseResults.Add(result);
                completedCount++;

                worker.ReportProgress(completedCount * 100 / ReplayCount);
            });
            return aggregateStats;

        }

        private (ParseResult, bool) parseReplay(string replayPath)
        {
            ParseResult result = new ParseResult();

            var (replayParseResult, replay) = DataParser.ParseReplay(replayPath, deleteFile: false, ParseOptions.MinimalParsing);
            if (replayParseResult != DataParser.ReplayParseResult.Success)
            {
                return (null, false);
            }

            foreach(var player in replay.Players)
            {
                result.players.Add(new GamePlayer(player.Name, player.IsWinner, player.Team));
            }
            return (result, true);
        }
    }
}
