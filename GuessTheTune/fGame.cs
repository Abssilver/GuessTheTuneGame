using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuessTheTune
{
    public partial class fGame : Form
    {
        Random rnd = new Random();
        int musicDuration = Quiz.musicDuration;
        public fGame()
        {
            InitializeComponent();
        }

        private void GenerateSong()
        {
            if (Quiz.allMusicList.Count == 0)
                EndGame();
            else
            {
                musicDuration = Quiz.musicDuration;
                int indexNumber = rnd.Next(0, Quiz.allMusicList.Count);
                WMediaPlayer.URL = Quiz.allMusicList[indexNumber];
                //WMediaPlayer.Ctlcontrols.play();
                Quiz.allMusicList.RemoveAt(indexNumber);
                labelSongLeft.Text = Quiz.allMusicList.Count.ToString();
            }
        }
        private void buttonGameNext_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            progressBarOfSong.Value = 0;
            GenerateSong();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            gameTimer.Stop();
            WMediaPlayer.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            labelSongLeft.Text = Quiz.allMusicList.Count.ToString();
            progressBarOfSong.Value = 0;
            progressBarOfSong.Minimum = 0;
            progressBarOfSong.Maximum = Quiz.gameDuration;
            labelMusicDuration.Text = musicDuration.ToString();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            progressBarOfSong.Value++;
            musicDuration--;
            labelMusicDuration.Text = musicDuration.ToString();
            if (progressBarOfSong.Value==progressBarOfSong.Maximum)
            {
                EndGame();
                return;
            }
            if (musicDuration == 0)
                GenerateSong();
        }
        private void EndGame()
        {
            gameTimer.Stop();
            WMediaPlayer.Ctlcontrols.stop();
        }
        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (progressBarOfSong.Value<progressBarOfSong.Maximum)
            {
                PauseGame();
            }
        }
        private void PauseGame()
        {
            gameTimer.Stop();
            WMediaPlayer.Ctlcontrols.pause();
        }
        private void ResumeGame()
        {
            gameTimer.Start();
            WMediaPlayer.Ctlcontrols.play();
        }
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            ResumeGame();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.A)
            {
                PauseGame();
                fMessage fmessage = new fMessage();
                fmessage.labelMessage.Text = "Is the Player 1's answer correct?";
                SoundPlayer splayer = new SoundPlayer(@"Resources\player1.wav");
                splayer.PlaySync();
                if (fmessage.ShowDialog()==DialogResult.Yes)
                {
                    labelPlayer1Score.Text = Convert.ToString(Convert.ToInt32(labelPlayer1Score.Text) + 1);
                    GenerateSong();
                }
                ResumeGame();
            } else if (e.KeyData == Keys.L)
                {
                    PauseGame();
                //if (MessageBox.Show("Is it right answer?", "Player 2 answer", MessageBoxButtons.YesNo) == DialogResult.Yes)
                fMessage fmessage = new fMessage();
                fmessage.labelMessage.Text = "Is the Player 2's answer correct?";
                SoundPlayer splayer = new SoundPlayer(@"Resources\player2.wav");
                splayer.PlaySync();
                if (fmessage.ShowDialog() == DialogResult.Yes)
                {
                        labelPlayer2Score.Text = Convert.ToString(Convert.ToInt32(labelPlayer2Score.Text) + 1);
                        GenerateSong();
                    }
                    ResumeGame();
                }
        }

        private void WMediaPlayer_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Quiz.randomStartMusic)
            {
                if (WMediaPlayer.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    WMediaPlayer.Ctlcontrols.currentPosition = rnd.Next(0, (int)WMediaPlayer.currentMedia.duration / 2);
            }
        }
    }
}
