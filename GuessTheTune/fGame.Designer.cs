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
            this.buttonGameNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonGameNext.BackgroundImage = global::GuessTheTune.Properties.Resources.icons8_forward_button_96;
            this.buttonGameNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGameNext.FlatAppearance.BorderSize = 0;
            this.buttonGameNext.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonGameNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonGameNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonGameNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGameNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGameNext.Location = new System.Drawing.Point(330, 133);
            this.buttonGameNext.Name = "buttonGameNext";
            this.buttonGameNext.Size = new System.Drawing.Size(96, 96);
            this.buttonGameNext.TabIndex = 1;
            this.buttonGameNext.UseVisualStyleBackColor = false;
            this.buttonGameNext.Click += new System.EventHandler(this.buttonGameNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Magneto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(596, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player 2";
            // 
            // labelPlayer2Score
            // 
            this.labelPlayer2Score.AutoSize = true;
            this.labelPlayer2Score.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2Score.Font = new System.Drawing.Font("Magneto", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2Score.ForeColor = System.Drawing.Color.Moccasin;
            this.labelPlayer2Score.Location = new System.Drawing.Point(633, 118);
            this.labelPlayer2Score.Name = "labelPlayer2Score";
            this.labelPlayer2Score.Size = new System.Drawing.Size(56, 52);
            this.labelPlayer2Score.TabIndex = 3;
            this.labelPlayer2Score.Text = "0";
            this.labelPlayer2Score.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelPlayer1Score_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Magneto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(65, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player 1";
            // 
            // labelPlayer1Score
            // 
            this.labelPlayer1Score.AutoSize = true;
            this.labelPlayer1Score.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1Score.Font = new System.Drawing.Font("Magneto", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1Score.ForeColor = System.Drawing.Color.Moccasin;
            this.labelPlayer1Score.Location = new System.Drawing.Point(98, 118);
            this.labelPlayer1Score.Name = "labelPlayer1Score";
            this.labelPlayer1Score.Size = new System.Drawing.Size(56, 52);
            this.labelPlayer1Score.TabIndex = 5;
            this.labelPlayer1Score.Text = "0";
            this.labelPlayer1Score.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelPlayer1Score_MouseClick);
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.Color.Transparent;
            this.buttonPause.BackgroundImage = global::GuessTheTune.Properties.Resources.icons8_pause_button_96;
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPause.FlatAppearance.BorderSize = 0;
            this.buttonPause.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPause.Location = new System.Drawing.Point(276, 235);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(96, 96);
            this.buttonPause.TabIndex = 6;
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.Transparent;
            this.buttonContinue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonContinue.BackgroundImage")));
            this.buttonContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonContinue.FlatAppearance.BorderSize = 0;
            this.buttonContinue.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContinue.Location = new System.Drawing.Point(389, 235);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(96, 96);
            this.buttonContinue.TabIndex = 7;
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // labelSongLeft
            // 
            this.labelSongLeft.AutoSize = true;
            this.labelSongLeft.BackColor = System.Drawing.Color.Transparent;
            this.labelSongLeft.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSongLeft.ForeColor = System.Drawing.Color.Moccasin;
            this.labelSongLeft.Location = new System.Drawing.Point(530, 396);
            this.labelSongLeft.Name = "labelSongLeft";
            this.labelSongLeft.Size = new System.Drawing.Size(213, 36);
            this.labelSongLeft.TabIndex = 8;
            this.labelSongLeft.Text = "Song left: 0";
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
            this.labelMusicDuration.BackColor = System.Drawing.Color.Transparent;
            this.labelMusicDuration.Font = new System.Drawing.Font("Magneto", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMusicDuration.ForeColor = System.Drawing.Color.Moccasin;
            this.labelMusicDuration.Location = new System.Drawing.Point(330, 70);
            this.labelMusicDuration.Name = "labelMusicDuration";
            this.labelMusicDuration.Size = new System.Drawing.Size(96, 46);
            this.labelMusicDuration.TabIndex = 10;
            this.labelMusicDuration.Text = "0";
            this.labelMusicDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessTheTune.Properties.Resources.backgroundMelody820x512;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 465);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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