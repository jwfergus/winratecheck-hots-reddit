
namespace winratecheck_hots_reddit
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.selectFolder_Button = new System.Windows.Forms.Button();
            this.selectFolder_Label = new System.Windows.Forms.Label();
            this.replayParse_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.folderValid_Label = new System.Windows.Forms.Label();
            this.parseReplays_Button = new System.Windows.Forms.Button();
            this.replayParseProgress_Label = new System.Windows.Forms.Label();
            this.replayParse_BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.results_GroupBox = new System.Windows.Forms.GroupBox();
            this.percentage_Label = new System.Windows.Forms.Label();
            this.loss_Label = new System.Windows.Forms.Label();
            this.win_Label = new System.Windows.Forms.Label();
            this.rightPercentage_Label = new System.Windows.Forms.Label();
            this.rightLosses_Label = new System.Windows.Forms.Label();
            this.leftPercentage_Label = new System.Windows.Forms.Label();
            this.leftLosses_Label = new System.Windows.Forms.Label();
            this.rightWins_Label = new System.Windows.Forms.Label();
            this.right_Label = new System.Windows.Forms.Label();
            this.leftWins_Label = new System.Windows.Forms.Label();
            this.left_Label = new System.Windows.Forms.Label();
            this.results_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFolder_Button
            // 
            this.selectFolder_Button.Location = new System.Drawing.Point(8, 126);
            this.selectFolder_Button.Name = "selectFolder_Button";
            this.selectFolder_Button.Size = new System.Drawing.Size(95, 23);
            this.selectFolder_Button.TabIndex = 0;
            this.selectFolder_Button.Text = "Select Folder";
            this.selectFolder_Button.UseVisualStyleBackColor = true;
            this.selectFolder_Button.Click += new System.EventHandler(this.selectFolder_Button_Click);
            // 
            // selectFolder_Label
            // 
            this.selectFolder_Label.AutoSize = true;
            this.selectFolder_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectFolder_Label.Location = new System.Drawing.Point(12, 9);
            this.selectFolder_Label.Name = "selectFolder_Label";
            this.selectFolder_Label.Size = new System.Drawing.Size(718, 67);
            this.selectFolder_Label.TabIndex = 1;
            this.selectFolder_Label.Text = resources.GetString("selectFolder_Label.Text");
            // 
            // replayParse_ProgressBar
            // 
            this.replayParse_ProgressBar.Location = new System.Drawing.Point(8, 207);
            this.replayParse_ProgressBar.Name = "replayParse_ProgressBar";
            this.replayParse_ProgressBar.Size = new System.Drawing.Size(176, 23);
            this.replayParse_ProgressBar.TabIndex = 2;
            // 
            // folderValid_Label
            // 
            this.folderValid_Label.AutoSize = true;
            this.folderValid_Label.Location = new System.Drawing.Point(5, 101);
            this.folderValid_Label.Name = "folderValid_Label";
            this.folderValid_Label.Size = new System.Drawing.Size(88, 13);
            this.folderValid_Label.TabIndex = 3;
            this.folderValid_Label.Text = "folderValid_Label";
            // 
            // parseReplays_Button
            // 
            this.parseReplays_Button.Location = new System.Drawing.Point(8, 247);
            this.parseReplays_Button.Name = "parseReplays_Button";
            this.parseReplays_Button.Size = new System.Drawing.Size(95, 23);
            this.parseReplays_Button.TabIndex = 4;
            this.parseReplays_Button.Text = "Parse Replays";
            this.parseReplays_Button.UseVisualStyleBackColor = true;
            this.parseReplays_Button.Click += new System.EventHandler(this.parseReplays_Button_Click);
            // 
            // replayParseProgress_Label
            // 
            this.replayParseProgress_Label.AutoSize = true;
            this.replayParseProgress_Label.Location = new System.Drawing.Point(8, 188);
            this.replayParseProgress_Label.Name = "replayParseProgress_Label";
            this.replayParseProgress_Label.Size = new System.Drawing.Size(135, 13);
            this.replayParseProgress_Label.TabIndex = 5;
            this.replayParseProgress_Label.Text = "replayParseProgress_Label";
            // 
            // replayParse_BackgroundWorker
            // 
            this.replayParse_BackgroundWorker.WorkerReportsProgress = true;
            this.replayParse_BackgroundWorker.WorkerSupportsCancellation = true;
            this.replayParse_BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.parseReplays_DoWork);
            this.replayParse_BackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.replayParse_BackgroundWorker_ProgressChanged);
            this.replayParse_BackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.replayParse_BackgroundWorker_RunWorkerCompleted);
            // 
            // cancel_Button
            // 
            this.cancel_Button.Location = new System.Drawing.Point(109, 247);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.cancel_Button.TabIndex = 6;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // results_GroupBox
            // 
            this.results_GroupBox.Controls.Add(this.percentage_Label);
            this.results_GroupBox.Controls.Add(this.loss_Label);
            this.results_GroupBox.Controls.Add(this.win_Label);
            this.results_GroupBox.Controls.Add(this.rightPercentage_Label);
            this.results_GroupBox.Controls.Add(this.rightLosses_Label);
            this.results_GroupBox.Controls.Add(this.leftPercentage_Label);
            this.results_GroupBox.Controls.Add(this.leftLosses_Label);
            this.results_GroupBox.Controls.Add(this.rightWins_Label);
            this.results_GroupBox.Controls.Add(this.right_Label);
            this.results_GroupBox.Controls.Add(this.leftWins_Label);
            this.results_GroupBox.Controls.Add(this.left_Label);
            this.results_GroupBox.Location = new System.Drawing.Point(249, 101);
            this.results_GroupBox.Name = "results_GroupBox";
            this.results_GroupBox.Size = new System.Drawing.Size(481, 323);
            this.results_GroupBox.TabIndex = 7;
            this.results_GroupBox.TabStop = false;
            this.results_GroupBox.Text = "Results";
            // 
            // percentage_Label
            // 
            this.percentage_Label.AutoSize = true;
            this.percentage_Label.Location = new System.Drawing.Point(6, 73);
            this.percentage_Label.Name = "percentage_Label";
            this.percentage_Label.Size = new System.Drawing.Size(52, 13);
            this.percentage_Label.TabIndex = 10;
            this.percentage_Label.Text = "Win Rate";
            this.percentage_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loss_Label
            // 
            this.loss_Label.AutoSize = true;
            this.loss_Label.Location = new System.Drawing.Point(18, 57);
            this.loss_Label.Name = "loss_Label";
            this.loss_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loss_Label.Size = new System.Drawing.Size(40, 13);
            this.loss_Label.TabIndex = 9;
            this.loss_Label.Text = "Losses";
            this.loss_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // win_Label
            // 
            this.win_Label.AutoSize = true;
            this.win_Label.Location = new System.Drawing.Point(24, 41);
            this.win_Label.Name = "win_Label";
            this.win_Label.Size = new System.Drawing.Size(31, 13);
            this.win_Label.TabIndex = 8;
            this.win_Label.Text = "Wins";
            this.win_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rightPercentage_Label
            // 
            this.rightPercentage_Label.AutoSize = true;
            this.rightPercentage_Label.Location = new System.Drawing.Point(137, 73);
            this.rightPercentage_Label.Name = "rightPercentage_Label";
            this.rightPercentage_Label.Size = new System.Drawing.Size(0, 13);
            this.rightPercentage_Label.TabIndex = 7;
            this.rightPercentage_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightLosses_Label
            // 
            this.rightLosses_Label.AutoSize = true;
            this.rightLosses_Label.Location = new System.Drawing.Point(137, 57);
            this.rightLosses_Label.Name = "rightLosses_Label";
            this.rightLosses_Label.Size = new System.Drawing.Size(0, 13);
            this.rightLosses_Label.TabIndex = 6;
            this.rightLosses_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftPercentage_Label
            // 
            this.leftPercentage_Label.AutoSize = true;
            this.leftPercentage_Label.Location = new System.Drawing.Point(64, 73);
            this.leftPercentage_Label.Name = "leftPercentage_Label";
            this.leftPercentage_Label.Size = new System.Drawing.Size(0, 13);
            this.leftPercentage_Label.TabIndex = 5;
            this.leftPercentage_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftLosses_Label
            // 
            this.leftLosses_Label.AutoSize = true;
            this.leftLosses_Label.Location = new System.Drawing.Point(64, 57);
            this.leftLosses_Label.Name = "leftLosses_Label";
            this.leftLosses_Label.Size = new System.Drawing.Size(0, 13);
            this.leftLosses_Label.TabIndex = 4;
            this.leftLosses_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightWins_Label
            // 
            this.rightWins_Label.AutoSize = true;
            this.rightWins_Label.Location = new System.Drawing.Point(137, 41);
            this.rightWins_Label.Name = "rightWins_Label";
            this.rightWins_Label.Size = new System.Drawing.Size(0, 13);
            this.rightWins_Label.TabIndex = 3;
            this.rightWins_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // right_Label
            // 
            this.right_Label.AutoSize = true;
            this.right_Label.Location = new System.Drawing.Point(128, 25);
            this.right_Label.Name = "right_Label";
            this.right_Label.Size = new System.Drawing.Size(56, 13);
            this.right_Label.TabIndex = 2;
            this.right_Label.Text = "Right Side";
            this.right_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftWins_Label
            // 
            this.leftWins_Label.AutoSize = true;
            this.leftWins_Label.Location = new System.Drawing.Point(64, 41);
            this.leftWins_Label.Name = "leftWins_Label";
            this.leftWins_Label.Size = new System.Drawing.Size(0, 13);
            this.leftWins_Label.TabIndex = 1;
            this.leftWins_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // left_Label
            // 
            this.left_Label.AutoSize = true;
            this.left_Label.Location = new System.Drawing.Point(57, 25);
            this.left_Label.Name = "left_Label";
            this.left_Label.Size = new System.Drawing.Size(49, 13);
            this.left_Label.TabIndex = 0;
            this.left_Label.Text = "Left Side";
            this.left_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 440);
            this.Controls.Add(this.results_GroupBox);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.replayParseProgress_Label);
            this.Controls.Add(this.parseReplays_Button);
            this.Controls.Add(this.folderValid_Label);
            this.Controls.Add(this.replayParse_ProgressBar);
            this.Controls.Add(this.selectFolder_Label);
            this.Controls.Add(this.selectFolder_Button);
            this.Name = "mainForm";
            this.Text = "Winrate Check - Hots Reddit";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.results_GroupBox.ResumeLayout(false);
            this.results_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolder_Button;
        private System.Windows.Forms.Label selectFolder_Label;
        private System.Windows.Forms.ProgressBar replayParse_ProgressBar;
        private System.Windows.Forms.Label folderValid_Label;
        private System.Windows.Forms.Button parseReplays_Button;
        private System.Windows.Forms.Label replayParseProgress_Label;
        private System.ComponentModel.BackgroundWorker replayParse_BackgroundWorker;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.GroupBox results_GroupBox;
        private System.Windows.Forms.Label percentage_Label;
        private System.Windows.Forms.Label loss_Label;
        private System.Windows.Forms.Label win_Label;
        private System.Windows.Forms.Label rightPercentage_Label;
        private System.Windows.Forms.Label rightLosses_Label;
        private System.Windows.Forms.Label leftPercentage_Label;
        private System.Windows.Forms.Label leftLosses_Label;
        private System.Windows.Forms.Label rightWins_Label;
        private System.Windows.Forms.Label right_Label;
        private System.Windows.Forms.Label leftWins_Label;
        private System.Windows.Forms.Label left_Label;
    }
}

