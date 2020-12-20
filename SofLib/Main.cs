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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.mainView1.Height = this.Height - this.panel3.Height;
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnMb_Click(object sender, EventArgs e)
        {
            this.mainView1.Visible = true;
            this.categoryView1.Visible = false;
            this.usersView1.Visible = false;
            this.borrowView1.Visible = false;
            this.FormName.Text = "Books Manegments";
            this.mainView1.MainView_Load(sender, e);
        }

        private void BtnMc_Click(object sender, EventArgs e)
        {
            this.categoryView1.Visible = true;
            this.mainView1.Visible = false;
            this.usersView1.Visible = false;
            this.borrowView1.Visible = false;
            this.FormName.Text = "Categories Manegments";
            this.categoryView1.load_Category_View(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.mainView1.Visible = true;
            this.categoryView1.Visible = false;
            this.usersView1.Visible = false;
            this.borrowView1.Visible = false;
        }

        private void BtnUm_Click(object sender, EventArgs e)
        {
            this.usersView1.Visible = true;
            this.mainView1.Visible = false;
            this.categoryView1.Visible = false;
            this.borrowView1.Visible = false;
            this.FormName.Text = "Members Manegments";
            this.usersView1.UserView_Load(sender, e);
        }

        private void BtnBorrow_Click(object sender, EventArgs e)
        {
            this.borrowView1.Visible = true;
            this.usersView1.Visible = false;
            this.mainView1.Visible = false;
            this.categoryView1.Visible = false;
            this.FormName.Text = "Borrowing Manegments";
            this.borrowView1.BorrowView_Load(sender, e);
        }
    }
}
