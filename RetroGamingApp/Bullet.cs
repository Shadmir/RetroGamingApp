using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace RetroGamingApp
{
    class Bullet
    {
        public string direction;
        public int speed = 20;
        PictureBox Bullet = new PictureBox();
        Timer tm = new Timer();

        public int bulletLeft;
        public int bulletTop;

        public void mkBullet(Form form)
        {
            Bullet.BackColor = Color.Yellow;
            Bullet.Size = 
        }
    }
}
