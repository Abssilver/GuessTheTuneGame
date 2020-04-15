namespace GuessTheTune
{
    partial class fSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSettings));
            this.listBoxSettingsMusicList = new System.Windows.Forms.ListBox();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.checkBoxSubfolders = new System.Windows.Forms.CheckBox();
            this.buttonSettingsCancel = new System.Windows.Forms.Button();
            this.buttonSettingsOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMusicDuration = new System.Windows.Forms.ComboBox();
            this.comboBoxGameDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxRandomStartMusic = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSettingsMusicList
            // 
            this.listBoxSettingsMusicList.FormattingEnabled = true;
            this.listBoxSettingsMusicList.ItemHeight = 16;
            this.listBoxSettingsMusicList.Location = new System.Drawing.Point(1, 12);
            this.listBoxSettingsMusicList.Name = "listBoxSettingsMusicList";
            this.listBoxSettingsMusicList.Size = new System.Drawing.Size(787, 292);
            this.listBoxSettingsMusicList.TabIndex = 0;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(21, 327);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(135, 29);
            this.buttonSelectFolder.TabIndex = 1;
            this.buttonSelectFolder.Text = "Select folder";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(176, 327);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(135, 29);
            this.buttonClearAll.TabIndex = 2;
            this.buttonClearAll.Text = "Clear all";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            // 
            // checkBoxSubfolders
            // 
            this.checkBoxSubfolders.AutoSize = true;
            this.checkBoxSubfolders.Location = new System.Drawing.Point(31, 370);
            this.checkBoxSubfolders.Name = "checkBoxSubfolders";
            this.checkBoxSubfolders.Size = new System.Drawing.Size(125, 21);
            this.checkBoxSubfolders.TabIndex = 3;
            this.checkBoxSubfolders.Text = "Use subfolders";
            this.checkBoxSubfolders.UseVisualStyleBackColor = true;
            // 
            // buttonSettingsCancel
            // 
            this.buttonSettingsCancel.Location = new System.Drawing.Point(176, 407);
            this.buttonSettingsCancel.Name = "buttonSettingsCancel";
            this.buttonSettingsCancel.Size = new System.Drawing.Size(135, 29);
            this.buttonSettingsCancel.TabIndex = 4;
            this.buttonSettingsCancel.Text = "Cancel";
            this.buttonSettingsCancel.UseVisualStyleBackColor = true;
            this.buttonSettingsCancel.Click += new System.EventHandler(this.buttonSettingsCancel_Click);
            // 
            // buttonSettingsOk
            // 
            this.buttonSettingsOk.Location = new System.Drawing.Point(21, 407);
            this.buttonSettingsOk.Name = "buttonSettingsOk";
            this.buttonSettingsOk.Size = new System.Drawing.Size(135, 29);
            this.buttonSettingsOk.TabIndex = 5;
            this.buttonSettingsOk.Text = "OK";
            this.buttonSettingsOk.UseVisualStyleBackColor = true;
            this.buttonSettingsOk.Click += new System.EventHandler(this.buttonSettingsOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBoxRandomStartMusic);
            this.groupBox1.Controls.Add(this.comboBoxMusicDuration);
            this.groupBox1.Controls.Add(this.comboBoxGameDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(364, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 111);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Settings";
            // 
            // comboBoxMusicDuration
            // 
            this.comboBoxMusicDuration.FormattingEnabled = true;
            this.comboBoxMusicDuration.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.comboBoxMusicDuration.Location = new System.Drawing.Point(139, 53);
            this.comboBoxMusicDuration.Name = "comboBoxMusicDuration";
            this.comboBoxMusicDuration.Size = new System.Drawing.Size(73, 24);
            this.comboBoxMusicDuration.TabIndex = 3;
            this.comboBoxMusicDuration.Text = "10";
            // 
            // comboBoxGameDuration
            // 
            this.comboBoxGameDuration.FormattingEnabled = true;
            this.comboBoxGameDuration.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "75",
            "90",
            "120"});
            this.comboBoxGameDuration.Location = new System.Drawing.Point(139, 21);
            this.comboBoxGameDuration.Name = "comboBoxGameDuration";
            this.comboBoxGameDuration.Size = new System.Drawing.Size(73, 24);
            this.comboBoxGameDuration.TabIndex = 2;
            this.comboBoxGameDuration.Text = "60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time For Answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Duration";
            // 
            // checkBoxRandomStartMusic
            // 
            this.checkBoxRandomStartMusic.AutoSize = true;
            this.checkBoxRandomStartMusic.Location = new System.Drawing.Point(10, 84);
            this.checkBoxRandomStartMusic.Name = "checkBoxRandomStartMusic";
            this.checkBoxRandomStartMusic.Size = new System.Drawing.Size(208, 21);
            this.checkBoxRandomStartMusic.TabIndex = 4;
            this.checkBoxRandomStartMusic.Text = "Random interval of the song";
            this.checkBoxRandomStartMusic.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Player 2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "L"});
            this.comboBox1.Location = new System.Drawing.Point(315, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "L";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A"});
            this.comboBox2.Location = new System.Drawing.Point(315, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(73, 24);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Text = "A";
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSettingsOk);
            this.Controls.Add(this.buttonSettingsCancel);
            this.Controls.Add(this.checkBoxSubfolders);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonSelectFolder);
            this.Controls.Add(this.listBoxSettingsMusicList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSettingsMusicList;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.CheckBox checkBoxSubfolders;
        private System.Windows.Forms.Button buttonSettingsCancel;
        private System.Windows.Forms.Button buttonSettingsOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxMusicDuration;
        private System.Windows.Forms.ComboBox comboBoxGameDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxRandomStartMusic;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}