using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using System.Windows.Forms;

namespace RetroGamingApp
{
    public partial class Pong : Form
    {
        bool goup;
        bool godown;
        bool cpuUp;
        bool cpuDown;
        bool cpuMode = true;
        bool funmode = false;
        bool boxDisplayed = false;
        bool lostFirst = false;
        int speed = 5;
        int ballx = 5;
        int bally = 5;
        int score = 0;
        int cpuPoint = 0;
        int randx = 0;
        int randy = 0;
        Random random = new Random();

        public Pong()
        {
            InitializeComponent();
            playStart();
        }
        private void playError()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\david.X201\OneDrive - Bacup & Rawtenstall Grammar School\Retro\Game\RetroGamingApp\Resources\Windows Vista Error Sound.wav");
            simpleSound.Play();
        }
        private void playStart()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\david.X201\OneDrive - Bacup & Rawtenstall Grammar School\Retro\Game\RetroGamingApp\Resources\Microsoft Windows Vista Startup Sound.wav");
            simpleSound.Play();
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
            if (cpuMode == false)
            {
                if (e.KeyCode == Keys.Down)
                {
                    cpuDown = true;
                }
                if (e.KeyCode == Keys.Up)
                {
                    cpuUp = true;
                }
            }
            if (e.KeyCode == Keys.G)
            {
                if (cpuMode == true)
                {
                    cpuMode = false;
                } else
                {
                    cpuMode = true;
                }
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
            if (cpuMode == false)
            {
                if (e.KeyCode == Keys.Down)
                {
                    cpuDown = false;
                }
                if (e.KeyCode == Keys.Up)
                {
                    cpuUp = false;
                }
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            playerScore.Text = "" + score;
            cpuLabel.Text = "" + cpuPoint;
            ball.Top -= bally;
            ball.Left -= ballx;
            if (lostFirst == true && boxDisplayed == false)
            {
                gameTimer.Stop();
                boxDisplayed = true;
                DialogResult dialogResult = MessageBox.Show("You lost the first point! Do you want punishment?", "Epilepsy Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    funmode = true;
                    gameTimer.Start();
                }
                else if (dialogResult == DialogResult.No)
                {
                    funmode = false;
                    gameTimer.Start();
                }
                
            }
            if (funmode == true) 
            {
                backPanel.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            }
            if (cpuMode == true)
            {
                cpu.Top += speed;
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
            }   
            if (ball.Left < 0)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx = -5;
                bally = random.Next(5) + 1;
                cpuPoint++;
            }
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx = 5;
                bally = random.Next(5) + 1;
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
                    randx = random.Next(6) - 3;
                    randy = random.Next(6) - 3;
                    ballx += randx;
                    bally += randy;
                    playError();
                }
                else
                {
                    ballx++;
                    randx = random.Next(6) - 3;
                    randy = random.Next(6) - 3;
                    ballx += randx;
                    bally += randy;
                }
                ballx = -ballx;
            }
            if (goup == true && player.Top > 0)
            {
                player.Top -= 8;
            }
            if (godown == true && player.Top < 455)
            {
                player.Top += 8;
            }
            if (cpuMode == false)
            {
                if (cpuUp == true && cpu.Top > 0)
                {
                    cpu.Top -= 8;
                }
                if (cpuDown == true && cpu.Top < 455)
                {
                    cpu.Top += 8;
                }
            }
            if (score == 0 && cpuPoint == 1 && cpuMode == true)
            {
                lostFirst = true;
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
    }
}
