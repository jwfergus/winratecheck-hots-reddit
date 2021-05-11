using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winratecheck_hots_reddit
{
    class GamePlayer
    {
        public string name;
        public bool winner;
        public int side;

        public GamePlayer(string name, bool winner, int side)
        {
            this.name = name;
            this.winner = winner;
            this.side = side;
        }
    }

    class PlayerSideStats
    {
        public int leftWins;
        public int leftLosses;
        public int rightWins;
        public int rightLosses;
        public int totalGames => leftLosses + leftWins + rightLosses + rightWins;
         
    }
    class ParseResult
    {
        public List<GamePlayer> players;

        public ParseResult()
        {
            players = new List<GamePlayer>();
        }
        
    }


    class AggregateStats
    {
        public List<ParseResult> allParseResults;

        public AggregateStats()
        {
            allParseResults = new List<ParseResult>();
        }

        public (string name, PlayerSideStats stats) GetSideWinrateMainPlayer()
        {
            Dictionary<string, PlayerSideStats> allPlayerStats = new Dictionary<string, PlayerSideStats>();
            foreach(var parseResult in allParseResults)
            {
                foreach(var player in parseResult.players)
                {
                    if (!allPlayerStats.ContainsKey(player.name))
                        allPlayerStats.Add(player.name, new PlayerSideStats());

                    // Wins
                    if (player.winner && player.side == 0)
                        allPlayerStats[player.name].leftWins++;
                    if (player.winner && player.side == 1)
                        allPlayerStats[player.name].rightWins++;

                    // Losses
                    if (!player.winner && player.side == 0)
                        allPlayerStats[player.name].leftLosses++;
                    if (!player.winner && player.side == 1)
                        allPlayerStats[player.name].rightLosses++;
                }
            }
            var mainPlayer = allPlayerStats.Aggregate((l, r) => l.Value.totalGames > r.Value.totalGames ? l : r).Key;
            
            return (mainPlayer, allPlayerStats[mainPlayer]);
        }
    }
}
