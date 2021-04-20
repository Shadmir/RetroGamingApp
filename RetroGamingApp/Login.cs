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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        GameSelect gameSelect = new GameSelect();
        Register register = new Register();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            gameSelect.Show();
            usernameBox.Text = "";
            passwordBox.Text = "";
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            register.Show();
        }
    }
}
