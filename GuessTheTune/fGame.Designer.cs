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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.WMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonGameNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // WMediaPlayer
            // 
            this.WMediaPlayer.Enabled = true;
            this.WMediaPlayer.Location = new System.Drawing.Point(230, 357);
            this.WMediaPlayer.Name = "WMediaPlayer";
            this.WMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMediaPlayer.OcxState")));
            this.WMediaPlayer.Size = new System.Drawing.Size(313, 55);
            this.WMediaPlayer.TabIndex = 0;
            this.WMediaPlayer.Visible = false;
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
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessTheTune.Properties.Resources.backgroundMelody;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGameNext);
            this.Controls.Add(this.WMediaPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fGame";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.WMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMediaPlayer;
        private System.Windows.Forms.Button buttonGameNext;
    }
}