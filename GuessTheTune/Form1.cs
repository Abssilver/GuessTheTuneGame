﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheTune
{
    public partial class formMain : Form
    {
        fSettings settings = new fSettings();
        fGame game = new fGame();
        public formMain()
        {
            InitializeComponent();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            game.ShowDialog();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            Quiz.ReadParams();
            Quiz.ReadMusic();
        }
    }
}
