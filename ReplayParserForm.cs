using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace winratecheck_hots_reddit
{
    public partial class mainForm : Form
    {
        ReplayParser replayParser;


        public mainForm()
        {
            InitializeComponent();

        }

        private void selectFolder_Button_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();


                // TESTING
                fbd.SelectedPath = @"C:\Users\admin\Documents\Heroes of the Storm\Accounts\79127123\1-Hero-1-4002586\Replays\Multiplayer";
                // TESTING


                if (fbd.ShowDialog() == DialogResult.OK)
                {
                     replayParser = new ReplayParser(fbd.SelectedPath);

                    folderValid_Label.Text = $"Replays found: {replayParser.ReplayCount}";
                    if(replayParser.ReplayCount != 0)
                    {
                        setUiReadyForParse();
                    }
                    else
                    {
                        setUiNotReadyForParse();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured");
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            replayParse_ProgressBar.Enabled = false;
            parseReplays_Button.Enabled = false;
            cancel_Button.Enabled = false;
            folderValid_Label.Text = "";
            replayParseProgress_Label.Enabled = false;
            replayParseProgress_Label.Text = $"Progress: 0 %";
            results_GroupBox.Enabled = false;

        }


        private void setUiNotReadyForParse()
        {
            replayParseProgress_Label.Text = $"Progress: 0 %";
            replayParse_ProgressBar.Value = 0;
            replayParseProgress_Label.Refresh();
            replayParse_ProgressBar.Refresh();

            replayParse_ProgressBar.Enabled = false;
            parseReplays_Button.Enabled = false;
            cancel_Button.Enabled = false;
            replayParseProgress_Label.Enabled = false;
        }
        private void setUiReadyForParse()
        {
            replayParseProgress_Label.Text = $"Progress: 0 %";
            replayParse_ProgressBar.Value = 0;
            replayParseProgress_Label.Refresh();
            replayParse_ProgressBar.Refresh();

            replayParse_ProgressBar.Enabled = true;
            parseReplays_Button.Enabled = true;
            cancel_Button.Enabled = false;
            replayParseProgress_Label.Enabled = true;
        }
        private void setUiParsing()
        {
            replayParse_ProgressBar.Enabled = true;
            parseReplays_Button.Enabled = false;
            cancel_Button.Enabled = true;
            replayParseProgress_Label.Enabled = true;
            replayParse_ProgressBar.Value = 0;
            replayParseProgress_Label.Text = $"Progress: 0 %";
        }
        private void setUiComplete()
        {
            replayParse_ProgressBar.Enabled = true;
            parseReplays_Button.Enabled = false;
            cancel_Button.Enabled = false;
            replayParseProgress_Label.Enabled = false;
            replayParse_ProgressBar.Value = 100;
            replayParseProgress_Label.Text = $"Progress: 100 %";
        }

        private void parseReplays_Button_Click(object sender, EventArgs e)
        {
            try
            {
                setUiParsing();
                replayParse_BackgroundWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured");
            }
        }

        private void parseReplays_DoWork(object sender, DoWorkEventArgs e)
        {
            replayParse_BackgroundWorker.WorkerReportsProgress = true;
            try
            {
                var res = replayParser.ParseReplays(replayParse_BackgroundWorker, e);
                e.Result = res.GetSideWinrateMainPlayer();
            }
            catch(OperationCanceledException ex)
            {
                MessageBox.Show(ex.Message, "Operation cancelled.");
            }
        }

        private void replayParse_BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            replayParse_ProgressBar.Value = e.ProgressPercentage;
            replayParseProgress_Label.Text = $"Progress: {e.ProgressPercentage} %";
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            // reset replayParser
            replayParser = new ReplayParser(replayParser.replayFolder);
            setUiReadyForParse();
            replayParse_BackgroundWorker.CancelAsync();
        }

        private void replayParse_BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                setUiComplete();
                var stats = (((string name, PlayerSideStats stats))e.Result).stats;

                leftLosses_Label.Text = stats.leftLosses.ToString();
                leftWins_Label.Text = stats.leftWins.ToString();
                rightLosses_Label.Text = stats.rightLosses.ToString();
                rightWins_Label.Text = stats.rightWins.ToString();

                leftPercentage_Label.Text = $"{(double)stats.leftWins / (double)(stats.leftLosses + stats.leftWins):P1}";
                rightPercentage_Label.Text = $"{(double)stats.rightWins / (double)(stats.rightLosses + stats.rightWins):P1}";
                results_GroupBox.Enabled = true;
            }
        }
    }
}
