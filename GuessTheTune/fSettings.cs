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
            Quiz.gameDuration = Convert.ToInt32(comboBoxGameDuration.Text);
            Quiz.musicDuration = Convert.ToInt32(comboBoxMusicDuration.Text);
            Quiz.randomStartMusic = checkBoxRandomStartMusic.Checked;
            Quiz.searchInSubfolders = checkBoxSubfolders.Checked;

            Quiz.WriteParams();
            this.Hide();
        }

        private void buttonSettingsCancel_Click(object sender, EventArgs e)
        {
            LoadQuizData();

            this.Hide();
        }
        private void LoadQuizData()
        {
            comboBoxGameDuration.Text = Quiz.gameDuration.ToString();
            comboBoxMusicDuration.Text = Quiz.musicDuration.ToString();
            checkBoxRandomStartMusic.Checked = Quiz.randomStartMusic;
            checkBoxSubfolders.Checked = Quiz.searchInSubfolders;
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

                Quiz.lastFolderPath = fbd.SelectedPath;
                Quiz.allMusicList.Clear();
                Quiz.allMusicList.AddRange(musicList);
            }
            
        }

        private void fSettings_Load(object sender, EventArgs e)
        {
            LoadQuizData();
            listBoxSettingsMusicList.Items.Clear();
            listBoxSettingsMusicList.Items.AddRange(Quiz.allMusicList.ToArray());
        }
    }
}
