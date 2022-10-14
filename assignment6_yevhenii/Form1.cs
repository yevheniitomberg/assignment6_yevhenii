using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6_yevhenii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button_finish.Enabled = false;
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            this.picture_pc.Image = null;
            this.button_finish.Enabled = true;
            this.button_play.Enabled = false;
        }

        private void picture_stone_Click(object sender, EventArgs e)
        {
            if (this.button_finish.Enabled == true)
            {
                ShowComputerDecision(1, ComputerRandomSelect());
            }
        }

        private void picture_scissors_Click(object sender, EventArgs e)
        {
            if (this.button_finish.Enabled == true)
            {
                ShowComputerDecision(2, ComputerRandomSelect());
            }
        }

        private void picture_paper_Click(object sender, EventArgs e)
        {
            if (this.button_finish.Enabled == true)
            {
                ShowComputerDecision(3, ComputerRandomSelect());
            }
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            int score_pc = int.Parse(this.label_score_pc.Text);
            int score_player = int.Parse(this.label_score_player.Text);

            if (score_pc > score_player)
            {
                MessageBox.Show("You lost with " + score_pc + ":" + score_player + " score", "Your bad!", MessageBoxButtons.OK);
            } else if (score_player > score_pc)
            {
                MessageBox.Show("You won with " + score_pc + ":" + score_player + " score", "Congrats!", MessageBoxButtons.OK);
            } else
            {
                MessageBox.Show("You have a draw with " + score_pc + ":" + score_player + " score", "Not bad!", MessageBoxButtons.OK);

            }
            this.label_score_pc.Text = "0";
            this.label_score_player.Text = "0";
            this.label_status.Text = "Status";
            this.picture_pc.Image = null;
            this.button_finish.Enabled = false;
            this.button_play.Enabled = true;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
