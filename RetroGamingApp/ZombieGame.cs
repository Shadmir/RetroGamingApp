using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroGamingApp
{
    public partial class ZombieGame : Form
    {
        bool goup;
        bool godown;
        bool goleft;
        bool goright;
        string facing = "up";
        double playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int zombieSpeed = 3;
        int score = 0;
        bool gameOver = false;
        Random rnd = new Random();

        public ZombieGame()
        {
            InitializeComponent();
        }

        private void Keyisdown(object sender, KeyEventArgs e)
        {
            
        }
        private void Keyisup(object sender, KeyEventArgs e)
        {
            
        }
        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = (rnd.Next(10, 890));
            ammo.Top = rnd.Next(50, 600);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();
        }

        private void shoot (string direct)
        {
            bullet shoot = new bullet();
            shoot.direction = direct;
            shoot.bulletLeft = player.Left + (player.Width / 2);
            shoot.bulletTop = player.Top + (player.Height / 2);
            shoot.mkBullet(this);
        }

        private void makeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = rnd.Next(0, 900);
            zombie.Top = rnd.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(zombie);
            player.BringToFront();
        }
        private void ZombieGame_Load(object sender, EventArgs e)
        {

        }

        private void gameEngine(object sender, EventArgs e)
        {
            if (playerHealth > 100)
            {
                playerHealth = 100;
            }
            if (playerHealth > 1)
            {
                healthBar.Value = Convert.ToInt32(playerHealth);
            } else
            {
                player.Image = Properties.Resources.dead;
                GameTimer.Stop();
                gameOver = true;
            }
            label1.Text = "Ammo:    " + ammo;
            label2.Text = "Kills: " + score;

            if (playerHealth < 20)
            {
                healthBar.ForeColor = Color.Red;
            }

            if (goleft && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (goright && player.Left + player.Width < 930)
            {
                player.Left += speed;
            }
            if (goup && player.Top > 60)
            {
                player.Top -= speed;
            }
            if (godown && player.Top + player.Height < 700)
            {
                player.Top += speed;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "ammo")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        this.Controls.Remove(((PictureBox)x));

                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }

                if (x is PictureBox && x.Tag == "bullet")
                {
                    if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > 930 || ((PictureBox)x).Top < 10 || ((PictureBox)x).Top > 700)
                    {
                        this.Controls.Remove((PictureBox)x);
                        ((PictureBox)x).Dispose();
                    }
                }
                if (x is PictureBox && x.Tag == "zombie")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        playerHealth -= 1;
                    }
                    if(((PictureBox)x).Left > player.Left)
                    {
                        ((PictureBox)x).Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (((PictureBox)x).Left < player.Left)
                    {
                        ((PictureBox)x).Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (((PictureBox)x).Top > player.Top)
                    {
                        ((PictureBox)x).Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (((PictureBox)x).Top < player.Top)
                    {
                        ((PictureBox)x).Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                    foreach (Control j in this.Controls)
                    {
                        if((j is PictureBox && j.Tag == "Bullet") && (x is PictureBox && x.Tag == "zombie"))
                        {
                            if (x.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++;
                                playerHealth += 5;
                                this.Controls.Remove(j);
                                j.Dispose();
                                this.Controls.Remove(x);
                                x.Dispose();
                                for (int i = 0; i < rnd.Next(score / 2) + 1; i++)
                                {
                                    makeZombies();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ZombieGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameOver) return;

            if (e.KeyCode == Keys.A)
            {
                goleft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.W)
            {
                facing = "up";
                goup = true;
                player.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.S)
            {
                facing = "down";
                godown = true;
                player.Image = Properties.Resources.down;
            }
        }

        private void ZombieGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (gameOver) return;

            if (e.KeyCode == Keys.A)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.W)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.S)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Space && ammo > 0)
            {
                ammo--;
                shoot(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                GameTimer.Enabled = true;
                gameStartLabel.Visible = false;
            }
        }
    }
}
