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
            this.SuspendLayout();
            // 
            // listBoxSettingsMusicList
            // 
            this.listBoxSettingsMusicList.FormattingEnabled = true;
            this.listBoxSettingsMusicList.ItemHeight = 16;
            this.listBoxSettingsMusicList.Location = new System.Drawing.Point(1, 12);
            this.listBoxSettingsMusicList.Name = "listBoxSettingsMusicList";
            this.listBoxSettingsMusicList.Size = new System.Drawing.Size(787, 324);
            this.listBoxSettingsMusicList.TabIndex = 0;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(21, 351);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(135, 29);
            this.buttonSelectFolder.TabIndex = 1;
            this.buttonSelectFolder.Text = "Select folder";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(176, 351);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(135, 29);
            this.buttonClearAll.TabIndex = 2;
            this.buttonClearAll.Text = "Clear all";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            // 
            // checkBoxSubfolders
            // 
            this.checkBoxSubfolders.AutoSize = true;
            this.checkBoxSubfolders.Location = new System.Drawing.Point(335, 359);
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
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSettingsOk);
            this.Controls.Add(this.buttonSettingsCancel);
            this.Controls.Add(this.checkBoxSubfolders);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonSelectFolder);
            this.Controls.Add(this.listBoxSettingsMusicList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSettings";
            this.Text = "Settings";
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
    }
}