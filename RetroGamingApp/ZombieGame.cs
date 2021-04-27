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
            if (gameOver) return;

            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {
                facing = "up";
                goup = true;
                player.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.Down)
            {
                facing = "down";
                godown = true;
                player.Image = Properties.Resources.down;
            }
        }
        private void Keyisup(object sender, KeyEventArgs e)
        {
            if (gameOver) return;

            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
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

        }
        private void DropAmmo()
        {

        }

        private void shoot (string direct)
        {

        }

        private void makeZombies()
        {

        }
        private void ZombieGame_Load(object sender, EventArgs e)
        {

        }

        private void gameEngine(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                healthBar.Value = Convert.ToInt32(playerHealth);
            } else
            {
                player.Image = Properties.Resources.dead;
                GameTimer.Stop();
                gameOver = true;
            }
            label1.Text = "   Ammo:    " + ammo;
            label2.Text = "Kills: " + score;

            if (playerHealth < 20)
            {
                healthBar.ForeColor = Color.Red;
            } // add rest of slide 20
        }
    }
}
