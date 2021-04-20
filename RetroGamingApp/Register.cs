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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            usernameBox.Text = "";
            passwordBox.Text = "";
            MessageBox.Show("Registered!");
            this.DestroyHandle();
        }
    }
}
