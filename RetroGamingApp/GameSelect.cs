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
    public partial class GameSelect : Form
    {
        public GameSelect()
        {
            InitializeComponent();
        }
        Pong pongGame = new Pong();
        ZombieGame zom = new ZombieGame();

        private void pongButton_Click(object sender, EventArgs e)
        {
            pongGame.Show();
            this.DestroyHandle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zom.Show();
            this.DestroyHandle();
        }
    }
}
