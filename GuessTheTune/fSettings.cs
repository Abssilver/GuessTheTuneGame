using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessTheTune
{
    public partial class fSettings : Form
    {
        public fSettings()
        {
            InitializeComponent();
        }

        private void buttonSettingsOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSettingsCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog()==DialogResult.OK)
            {
                string[] musicList = Directory.GetFiles(fbd.SelectedPath, "*.mp3", 
                    checkBoxSubfolders.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                listBoxSettingsMusicList.Items.Clear();
                listBoxSettingsMusicList.Items.AddRange(musicList);
                Quiz.allMusicList.Clear();
                Quiz.allMusicList.AddRange(musicList);
            }
            
        }
    }
}
