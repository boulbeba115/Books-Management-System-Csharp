using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SofLib
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            loginImg.Location = new Point(this.Width / 2 - loginImg.Size.Width / 2, 75);
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.userName.Text))
            {
                MessageBox.Show("Please enter the  UserName ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(this.Password.Text))
            {
                MessageBox.Show("Please enter the password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(userName.Text.Equals("admin") && Password.Text.Equals("admin"))
                {
                    Form f = new Main();
                    this.Hide();
                    f.Show();
                } 
            }

        }
    }
}
