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
    public partial class fMessage : Form
    {
        int answerTime = 10;
        public fMessage()
        {
            InitializeComponent();
        }

        private void fMessage_Load(object sender, EventArgs e)
        {
            answerTime = 10;
            checkAnswerTimer.Start();
        }

        private void checkAnswerTimer_Tick(object sender, EventArgs e)
        {
            answerTime--;
            labelTimer.Text = answerTime.ToString();
            if (answerTime<1)
            {
                checkAnswerTimer.Stop();
                SoundPlayer splayer = new SoundPlayer(@"Resources\notification.wav");
                splayer.Play();
            }
        }

        private void fMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            checkAnswerTimer.Stop();
        }

        private void labelShowAnswer_Click(object sender, EventArgs e)
        {
            labelShowAnswer.Text = Quiz.songName;
        }
    }
}
