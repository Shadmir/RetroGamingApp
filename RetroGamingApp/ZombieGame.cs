using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;

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
        int elapsed = 0;
        int power = 0;
        int powerChance;
        bool powerup = false;
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
        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);
            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
            //now rotate the image
            gfx.RotateTransform(rotationAngle);
            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));
            //dispose of our Graphics object
            gfx.Dispose();
            //return the image
            return bmp;
        }

        private void timeWiz()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.timewiz);
            simpleSound.Play();
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

        private void makeTime()
        {
            PictureBox time = new PictureBox();
            time.Tag = "time";
            time.Image = Properties.Resources.time_wizard;
            time.Left = rnd.Next(0, 900);
            time.Top = rnd.Next(0, 800);
            time.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(time);
            player.BringToFront();
        }
        private void ZombieGame_Load(object sender, EventArgs e)
        {

        }

        private void gameEngine(object sender, EventArgs e)
        {
            powerChance = rnd.Next(1000);
            if (powerChance == 1)
            {
                makeTime();
            }
            elapsed++;
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
            if (power + 200 < elapsed && powerup)
            {
                zombieSpeed = 0;
                powerup = false;
            }
            if (powerup == false)
            {
                zombieSpeed = 5;
            }

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
                        Controls.Remove(((PictureBox)x));

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
                    if (((PictureBox)x).Left > player.Left)
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
                    ((PictureBox)x).Image = RotateImage(Properties.Resources.zup, (float)(360 - ((180 / Math.PI) * (Math.Atan2(((PictureBox)x).Location.X - player.Location.X, ((PictureBox)x).Location.Y - player.Location.Y)))));
                    foreach (Control j in this.Controls)
                    {
                        if ((j is PictureBox && j.Tag == "Bullet") && (x is PictureBox && x.Tag == "zombie"))
                        {
                            if (x.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++;
                                playerHealth += 5;
                                this.Controls.Remove(j);
                                j.Dispose();
                                this.Controls.Remove(x);
                                x.Dispose();
                                if (score % 20 == 0)
                                {
                                    makeZombies();
                                    makeZombies();
                                } else
                                {
                                    makeZombies();
                                }
                            }
                        }
                    }
                }
                
                if (x.Tag == "time" && x is PictureBox)
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        zombieSpeed = 0;
                        power = elapsed;
                        timeWiz();
                        powerup = true;
                        ((PictureBox)x).Dispose();
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
                if (godown)
                {
                    facing = "SW";
                } if (goup)
                {
                    facing = "NW";
                }
                player.Image = Properties.Resources.left;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = true;
                facing = "right";
                if (godown)
                {
                    facing = "SE";
                } if (goup)
                {
                    facing = "NE";
                }
                player.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.W)
            {
                facing = "up";
                goup = true;
                if (goleft)
                {
                    facing = "NW";
                } if (goright)
                {
                    facing = "NE";
                }
                player.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.S)
            {
                facing = "down";
                godown = true;
                if (goleft)
                {
                    facing = "SW";
                }
                if (goright)
                {
                    facing = "SE";
                }
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
//zombie rotation coide by georg blad