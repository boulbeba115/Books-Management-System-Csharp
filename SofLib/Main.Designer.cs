namespace SofLib
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Menu = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBorrow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnUm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnMc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnMb = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FormName = new System.Windows.Forms.Label();
            this.categoryView1 = new SofLib.CategoryUserControl.CategoryView();
            this.mainView1 = new SofLib.BooksUserControl.MainView();
            this.usersView1 = new SofLib.UsersControl.UsersView();
            this.borrowView1 = new SofLib.BooksUserControl.BorrowView();
            this.Menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.Menu.Controls.Add(this.UserPanel);
            this.Menu.Controls.Add(this.panel2);
            this.Menu.Controls.Add(this.panel1);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(257, 653);
            this.Menu.TabIndex = 0;
            // 
            // UserPanel
            // 
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPanel.Location = new System.Drawing.Point(0, 391);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(257, 35);
            this.UserPanel.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.btnBorrow);
            this.panel2.Controls.Add(this.BtnUm);
            this.panel2.Controls.Add(this.BtnMc);
            this.panel2.Controls.Add(this.BtnMb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 315);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(70)))), ((int)(((byte)(154)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "   Stats";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 13;
            this.bunifuFlatButton1.IconMarginRight = 20;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 65D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 192);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(70)))), ((int)(((byte)(154)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(257, 48);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "   Stats";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Visible = false;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Active = false;
            this.btnBorrow.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(70)))), ((int)(((byte)(154)))));
            this.btnBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrow.BorderRadius = 0;
            this.btnBorrow.ButtonText = "   Borrowed books";
            this.btnBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrow.DisabledColor = System.Drawing.Color.Gray;
            this.btnBorrow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrow.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBorrow.Iconimage = global::SofLib.Properties.Resources.borrow_book_2078922_1757915;
            this.btnBorrow.Iconimage_right = null;
            this.btnBorrow.Iconimage_right_Selected = null;
            this.btnBorrow.Iconimage_Selected = null;
            this.btnBorrow.IconMarginLeft = 13;
            this.btnBorrow.IconMarginRight = 20;
            this.btnBorrow.IconRightVisible = true;
            this.btnBorrow.IconRightZoom = 0D;
            this.btnBorrow.IconVisible = true;
            this.btnBorrow.IconZoom = 65D;
            this.btnBorrow.IsTab = false;
            this.btnBorrow.Location = new System.Drawing.Point(0, 144);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.btnBorrow.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(70)))), ((int)(((byte)(154)))));
            this.btnBorrow.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBorrow.selected = false;
            this.btnBorrow.Size = new System.Drawing.Size(257, 48);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "   Borrowed books";
            this.btnBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrow.Textcolor = System.Drawing.Color.White;
            this.btnBorrow.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.Click += new System.EventHandler(this.BtnBorrow_Click);
            // 
            // BtnUm
            // 
            this.BtnUm.Active = false;
            this.BtnUm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(70)))), ((int)(((byte)(154)))));
            this.BtnUm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.BtnUm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUm.BorderRadius = 0;
            this.BtnUm.ButtonText = "Members Managments";
            this.BtnUm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUm.DisabledColor = System.Drawing.Color.Gray;
            this.BtnUm.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUm.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnUm.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnUm.Iconimage")));
            this.BtnUm.Iconimage_right = null;
            this.BtnUm.Iconimage_right_Selected = null;
            this.BtnUm.Iconimage_Selected = null;
            this.BtnUm.IconMarginLeft = 2;
            this.BtnUm.IconMarginRight = 0;
            this.BtnUm.IconRightVisible = true;
            this.BtnUm.IconRightZoom = 0D;
            this.BtnUm.IconVisible = true;
            this.BtnUm.IconZoom = 100D;
            this.BtnUm.IsTab = false;
            this.BtnUm.Location = new System.Drawing.Point(0, 96);
            this.BtnUm.Name = "BtnUm";
            this.BtnUm.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.BtnUm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(70)))), ((int)(((byte)(154)))));
            this.BtnUm.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnUm.selected = false;
            this.BtnUm.Size = new System.Drawing.Size(257, 48);
            this.BtnUm.TabIndex = 1;
            this.BtnUm.Text = "Members Managments";
            this.BtnUm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUm.Textcolor = System.Drawing.Color.White;
            this.BtnUm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUm.Click += new System.EventHandler(this.BtnUm_Click);
            // 
            // BtnMc
            // 
            this.BtnMc.Active = false;
            this.BtnMc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(70)))), ((int)(((byte)(154)))));
            this.BtnMc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.BtnMc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMc.BorderRadius = 0;
            this.BtnMc.ButtonText = "    Categories Managments";
            this.BtnMc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMc.DisabledColor = System.Drawing.Color.Gray;
            this.BtnMc.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMc.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnMc.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnMc.Iconimage")));
            this.BtnMc.Iconimage_right = null;
            this.BtnMc.Iconimage_right_Selected = null;
            this.BtnMc.Iconimage_Selected = null;
            this.BtnMc.IconMarginLeft = 10;
            this.BtnMc.IconMarginRight = 0;
            this.BtnMc.IconRightVisible = true;
            this.BtnMc.IconRightZoom = 0D;
            this.BtnMc.IconVisible = true;
            this.BtnMc.IconZoom = 65D;
            this.BtnMc.IsTab = false;
            this.BtnMc.Location = new System.Drawing.Point(0, 48);
            this.BtnMc.Name = "BtnMc";
            this.BtnMc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.BtnMc.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(70)))), ((int)(((byte)(154)))));
            this.BtnMc.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnMc.selected = false;
            this.BtnMc.Size = new System.Drawing.Size(257, 48);
            this.BtnMc.TabIndex = 1;
            this.BtnMc.Text = "    Categories Managments";
            this.BtnMc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMc.Textcolor = System.Drawing.Color.White;
            this.BtnMc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMc.Click += new System.EventHandler(this.BtnMc_Click);
            // 
            // BtnMb
            // 
            this.BtnMb.Active = false;
            this.BtnMb.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(70)))), ((int)(((byte)(154)))));
            this.BtnMb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.BtnMb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMb.BorderRadius = 0;
            this.BtnMb.ButtonText = "Books Managments";
            this.BtnMb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMb.DisabledColor = System.Drawing.Color.Gray;
            this.BtnMb.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMb.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnMb.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnMb.Iconimage")));
            this.BtnMb.Iconimage_right = null;
            this.BtnMb.Iconimage_right_Selected = null;
            this.BtnMb.Iconimage_Selected = null;
            this.BtnMb.IconMarginLeft = 10;
            this.BtnMb.IconMarginRight = 0;
            this.BtnMb.IconRightVisible = true;
            this.BtnMb.IconRightZoom = 0D;
            this.BtnMb.IconVisible = true;
            this.BtnMb.IconZoom = 90D;
            this.BtnMb.IsTab = false;
            this.BtnMb.Location = new System.Drawing.Point(0, 0);
            this.BtnMb.Name = "BtnMb";
            this.BtnMb.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.BtnMb.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(70)))), ((int)(((byte)(154)))));
            this.BtnMb.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnMb.selected = false;
            this.BtnMb.Size = new System.Drawing.Size(257, 48);
            this.BtnMb.TabIndex = 0;
            this.BtnMb.Text = "Books Managments";
            this.BtnMb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMb.Textcolor = System.Drawing.Color.White;
            this.BtnMb.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMb.Click += new System.EventHandler(this.BtnMb_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 76);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dosis", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(87, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "SOFTLIB";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(0, 0);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(0, 0);
            this.doubleBitmapControl1.TabIndex = 0;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.panel3.Controls.Add(this.bunifuFlatButton2);
            this.panel3.Controls.Add(this.FormName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(257, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1027, 75);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 10;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 10D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 40D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(976, 0);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(51, 75);
            this.bunifuFlatButton2.TabIndex = 25;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // FormName
            // 
            this.FormName.AutoSize = true;
            this.FormName.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormName.Location = new System.Drawing.Point(6, 19);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(226, 32);
            this.FormName.TabIndex = 0;
            this.FormName.Text = "Books Managments";
            // 
            // categoryView1
            // 
            this.categoryView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryView1.Location = new System.Drawing.Point(257, 75);
            this.categoryView1.Name = "categoryView1";
            this.categoryView1.Size = new System.Drawing.Size(1027, 578);
            this.categoryView1.TabIndex = 3;
            // 
            // mainView1
            // 
            this.mainView1.AutoScroll = true;
            this.mainView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainView1.Location = new System.Drawing.Point(257, 75);
            this.mainView1.Name = "mainView1";
            this.mainView1.Size = new System.Drawing.Size(1027, 578);
            this.mainView1.TabIndex = 2;
            // 
            // usersView1
            // 
            this.usersView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersView1.Location = new System.Drawing.Point(257, 75);
            this.usersView1.Name = "usersView1";
            this.usersView1.Size = new System.Drawing.Size(1027, 578);
            this.usersView1.TabIndex = 4;
            // 
            // borrowView1
            // 
            this.borrowView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowView1.Location = new System.Drawing.Point(257, 75);
            this.borrowView1.Name = "borrowView1";
            this.borrowView1.Size = new System.Drawing.Size(1027, 578);
            this.borrowView1.TabIndex = 5;
            this.borrowView1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 653);
            this.Controls.Add(this.borrowView1);
            this.Controls.Add(this.usersView1);
            this.Controls.Add(this.categoryView1);
            this.Controls.Add(this.mainView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Menu);
            this.MinimumSize = new System.Drawing.Size(1300, 39);
            this.Name = "Main";
            this.Text = "Users Managments";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton BtnMb;
        private System.Windows.Forms.Panel UserPanel;
        private Bunifu.Framework.UI.BunifuFlatButton BtnUm;
        private Bunifu.Framework.UI.BunifuFlatButton BtnMc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label FormName;
        private BooksUserControl.MainView mainView1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private CategoryUserControl.CategoryView categoryView1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnBorrow;
        private UsersControl.UsersView usersView1;
        private BooksUserControl.BorrowView borrowView1;
    }
}

