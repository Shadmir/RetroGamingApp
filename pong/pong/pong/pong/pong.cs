using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pong
{
    public partial class pong : Form
    {
        bool goup;
        bool godown;
        bool cpuUp;
        bool cpuDown;
        int speed = 5;
        int ballx = 5;
        int bally = 5;
        int score = 0;
        int cpuPoint = 0;

        public pong()
        {
            InitializeComponent();
        }

        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gameTimer.Enabled = true;
                startGameLabel.Visible = false;
            }
            if (e.KeyCode == Keys.S)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.W)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                cpuDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                cpuUp = true;
            }
        }

        private void Keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.W)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                cpuDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                cpuUp = false;
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            playerScore.Text = "" + score;
            cpuLabel.Text = "" + cpuPoint;
            ball.Top -= bally;
            ball.Left -= ballx;
            /*
            if (score < 5)
            {
                if (cpu.Top < 0 || cpu.Top > 455)
                {
                    speed = -speed;
                }
            }
            else
            {
                cpu.Top = ball.Top - 30;
            }
            */
            if (ball.Left < 0)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx = -5;
                cpuPoint++;
            }
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx = 5;
                score++;
            }
            if (ball.Top < 0 || ball.Height + ball.Top > ClientSize.Height)
            {
                bally = -bally;
            }
            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                if (ballx < 0)
                {
                    ballx--;                  
                }
                else
                {
                    ballx++;
                }
                ballx = -ballx;
                speed++;
            }
            if (goup == true && player.Top > 0)
            {
                player.Top -= 8;
            }
            if (godown == true && player.Top < 455)
            {
                player.Top += 8;
            }
            if (cpuUp == true && cpu.Top > 0)
            {
                cpu.Top -= 8;
            }
            if (cpuDown == true && cpu.Top < 455)
            {
                cpu.Top += 8;
            }
            if (score > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("Left wins this game!");
                this.DestroyHandle();
            }
            if (cpuPoint > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("Right wins this game!");
                this.DestroyHandle();
            }
        }

        private void startGameLabel_Click(object sender, EventArgs e)
        {

        }

        private void pong_Load(object sender, EventArgs e)
        {

        }
    }
}
