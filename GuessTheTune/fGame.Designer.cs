namespace GuessTheTune
{
    partial class fGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.WMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonGameNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlayer2Score = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPlayer1Score = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.labelSongLeft = new System.Windows.Forms.Label();
            this.progressBarOfSong = new System.Windows.Forms.ProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelMusicDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // WMediaPlayer
            // 
            this.WMediaPlayer.Enabled = true;
            this.WMediaPlayer.Location = new System.Drawing.Point(241, 12);
            this.WMediaPlayer.Name = "WMediaPlayer";
            this.WMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMediaPlayer.OcxState")));
            this.WMediaPlayer.Size = new System.Drawing.Size(302, 55);
            this.WMediaPlayer.TabIndex = 0;
            this.WMediaPlayer.Visible = false;
            this.WMediaPlayer.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMediaPlayer_OpenStateChange);
            // 
            // buttonGameNext
            // 
            this.buttonGameNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGameNext.Location = new System.Drawing.Point(278, 161);
            this.buttonGameNext.Name = "buttonGameNext";
            this.buttonGameNext.Size = new System.Drawing.Size(232, 66);
            this.buttonGameNext.TabIndex = 1;
            this.buttonGameNext.Text = "Next";
            this.buttonGameNext.UseVisualStyleBackColor = true;
            this.buttonGameNext.Click += new System.EventHandler(this.buttonGameNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(602, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player 2";
            // 
            // labelPlayer2Score
            // 
            this.labelPlayer2Score.AutoSize = true;
            this.labelPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer2Score.Location = new System.Drawing.Point(642, 133);
            this.labelPlayer2Score.Name = "labelPlayer2Score";
            this.labelPlayer2Score.Size = new System.Drawing.Size(31, 32);
            this.labelPlayer2Score.TabIndex = 3;
            this.labelPlayer2Score.Text = "0";
            this.labelPlayer2Score.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelPlayer1Score_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(71, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player 1";
            // 
            // labelPlayer1Score
            // 
            this.labelPlayer1Score.AutoSize = true;
            this.labelPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer1Score.Location = new System.Drawing.Point(114, 133);
            this.labelPlayer1Score.Name = "labelPlayer1Score";
            this.labelPlayer1Score.Size = new System.Drawing.Size(31, 32);
            this.labelPlayer1Score.TabIndex = 5;
            this.labelPlayer1Score.Text = "0";
            this.labelPlayer1Score.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelPlayer1Score_MouseClick);
            // 
            // buttonPause
            // 
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPause.Location = new System.Drawing.Point(241, 266);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(121, 59);
            this.buttonPause.TabIndex = 6;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContinue.Location = new System.Drawing.Point(422, 266);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(121, 59);
            this.buttonContinue.TabIndex = 7;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // labelSongLeft
            // 
            this.labelSongLeft.AutoSize = true;
            this.labelSongLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSongLeft.Location = new System.Drawing.Point(373, 90);
            this.labelSongLeft.Name = "labelSongLeft";
            this.labelSongLeft.Size = new System.Drawing.Size(42, 46);
            this.labelSongLeft.TabIndex = 8;
            this.labelSongLeft.Text = "0";
            // 
            // progressBarOfSong
            // 
            this.progressBarOfSong.Location = new System.Drawing.Point(241, 354);
            this.progressBarOfSong.Name = "progressBarOfSong";
            this.progressBarOfSong.Size = new System.Drawing.Size(302, 23);
            this.progressBarOfSong.TabIndex = 9;
            this.progressBarOfSong.Value = 50;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // labelMusicDuration
            // 
            this.labelMusicDuration.AutoSize = true;
            this.labelMusicDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMusicDuration.Location = new System.Drawing.Point(373, 395);
            this.labelMusicDuration.Name = "labelMusicDuration";
            this.labelMusicDuration.Size = new System.Drawing.Size(35, 38);
            this.labelMusicDuration.TabIndex = 10;
            this.labelMusicDuration.Text = "0";
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessTheTune.Properties.Resources.backgroundMelody;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMusicDuration);
            this.Controls.Add(this.progressBarOfSong);
            this.Controls.Add(this.labelSongLeft);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.labelPlayer1Score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPlayer2Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGameNext);
            this.Controls.Add(this.WMediaPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fGame";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Load += new System.EventHandler(this.fGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMediaPlayer;
        private System.Windows.Forms.Button buttonGameNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlayer2Score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPlayer1Score;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label labelSongLeft;
        private System.Windows.Forms.ProgressBar progressBarOfSong;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label labelMusicDuration;
    }
}