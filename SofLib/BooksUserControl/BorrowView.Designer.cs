namespace SofLib.BooksUserControl
{
    partial class BorrowView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowView));
            this.panel10 = new System.Windows.Forms.Panel();
            this.AddBook = new System.Windows.Forms.Label();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.BorrowGridView = new Telerik.WinControls.UI.RadGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PageTitle = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.box = new Telerik.WinControls.UI.RadGroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.formPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bookPicker = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.memberPicker = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Addnew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dateBorow = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.returnBack = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ReturnBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowGridView.MasterTemplate)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            this.panel3.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicker.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicker.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberPicker.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberPicker.EditorControl.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 59);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1065, 72);
            this.panel10.TabIndex = 27;
            // 
            // AddBook
            // 
            this.AddBook.AutoSize = true;
            this.AddBook.Font = new System.Drawing.Font("Chaparral Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBook.Location = new System.Drawing.Point(6, 13);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(186, 38);
            this.AddBook.TabIndex = 1;
            this.AddBook.Text = "Borrow Book";
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.BorrowGridView);
            this.gridPanel.Controls.Add(this.panel8);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridPanel.Location = new System.Drawing.Point(0, 0);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(1065, 394);
            this.gridPanel.TabIndex = 0;
            // 
            // BorrowGridView
            // 
            this.BorrowGridView.BackColor = System.Drawing.SystemColors.Control;
            this.BorrowGridView.ColumnChooserSortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            this.BorrowGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.BorrowGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorrowGridView.EnableTheming = false;
            this.BorrowGridView.Font = new System.Drawing.Font("Roboto Light", 9.75F);
            this.BorrowGridView.ForeColor = System.Drawing.Color.Black;
            this.BorrowGridView.HideSelection = true;
            this.BorrowGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BorrowGridView.Location = new System.Drawing.Point(0, 61);
            // 
            // 
            // 
            this.BorrowGridView.MasterTemplate.AllowAddNewRow = false;
            this.BorrowGridView.MasterTemplate.AllowColumnReorder = false;
            this.BorrowGridView.MasterTemplate.AllowDeleteRow = false;
            this.BorrowGridView.MasterTemplate.AllowSearchRow = true;
            this.BorrowGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.BorrowGridView.MasterTemplate.EnableAlternatingRowColor = true;
            this.BorrowGridView.MasterTemplate.EnablePaging = true;
            this.BorrowGridView.MasterTemplate.PageSize = 5;
            this.BorrowGridView.MasterTemplate.ShowGroupedColumns = true;
            this.BorrowGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.BorrowGridView.Name = "BorrowGridView";
            this.BorrowGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.BorrowGridView.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            this.BorrowGridView.Size = new System.Drawing.Size(1065, 294);
            this.BorrowGridView.TabIndex = 13;
            this.BorrowGridView.ThemeName = "Crystal";
            this.BorrowGridView.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.BorrowGridView_CellClick);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Controls.Add(this.panel5);
            this.panel8.Controls.Add(this.PageTitle);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1065, 61);
            this.panel8.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ReturnBtn);
            this.panel5.Controls.Add(this.bunifuFlatButton1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(948, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(117, 61);
            this.panel5.TabIndex = 12;
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.Font = new System.Drawing.Font("Chaparral Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.PageTitle.Location = new System.Drawing.Point(4, 11);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(230, 38);
            this.PageTitle.TabIndex = 1;
            this.PageTitle.Text = "Borrowed Books";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DimGray;
            this.panel9.Controls.Add(this.bunifuFlatButton2);
            this.panel9.Controls.Add(this.AddBook);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1065, 59);
            this.panel9.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.box);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(60, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1082, 1043);
            this.panel4.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 1205);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1065, 532);
            this.panel6.TabIndex = 13;
            // 
            // box
            // 
            this.box.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.box.AutoSize = true;
            this.box.Dock = System.Windows.Forms.DockStyle.Top;
            this.box.HeaderMargin = new System.Windows.Forms.Padding(1);
            this.box.HeaderText = "Book Info";
            this.box.Location = new System.Drawing.Point(0, 1203);
            this.box.Name = "box";
            // 
            // 
            // 
            this.box.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.box.Size = new System.Drawing.Size(1065, 2);
            this.box.TabIndex = 12;
            this.box.Text = "Book Info";
            this.box.ThemeName = "Crystal";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.formPanel);
            this.panel3.Controls.Add(this.gridPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1065, 1203);
            this.panel3.TabIndex = 11;
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formPanel.Controls.Add(this.panel7);
            this.formPanel.Controls.Add(this.tableLayoutPanel1);
            this.formPanel.Controls.Add(this.panel10);
            this.formPanel.Controls.Add(this.panel9);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formPanel.Location = new System.Drawing.Point(0, 394);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(1065, 392);
            this.formPanel.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 339);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1065, 42);
            this.panel7.TabIndex = 29;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Addnew, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateBorow, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.returnBack, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.bookPicker, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.memberPicker, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 131);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1065, 208);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(559, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 50);
            this.label4.TabIndex = 10;
            this.label4.Text = "Return Back Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(104, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 50);
            this.label3.TabIndex = 8;
            this.label3.Text = "Borrowing Date ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(104, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "Book";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(559, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 50);
            this.label9.TabIndex = 20;
            this.label9.Text = "Member";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookPicker
            // 
            this.bookPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // bookPicker.NestedRadGridView
            // 
            this.bookPicker.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.bookPicker.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookPicker.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bookPicker.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.bookPicker.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.bookPicker.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.bookPicker.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.bookPicker.EditorControl.MasterTemplate.EnableGrouping = false;
            this.bookPicker.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.bookPicker.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.bookPicker.EditorControl.Name = "NestedRadGridView";
            this.bookPicker.EditorControl.ReadOnly = true;
            this.bookPicker.EditorControl.ShowGroupPanel = false;
            this.bookPicker.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.bookPicker.EditorControl.TabIndex = 0;
            this.bookPicker.Location = new System.Drawing.Point(205, 13);
            this.bookPicker.Name = "bookPicker";
            this.bookPicker.Size = new System.Drawing.Size(298, 24);
            this.bookPicker.TabIndex = 31;
            this.bookPicker.TabStop = false;
            this.bookPicker.ThemeName = "Fluent";
            this.bookPicker.Validating += new System.ComponentModel.CancelEventHandler(this.BookPicker_Validating);
            // 
            // memberPicker
            // 
            this.memberPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // memberPicker.NestedRadGridView
            // 
            this.memberPicker.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.memberPicker.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberPicker.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.memberPicker.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.memberPicker.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.memberPicker.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.memberPicker.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.memberPicker.EditorControl.MasterTemplate.EnableGrouping = false;
            this.memberPicker.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.memberPicker.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.memberPicker.EditorControl.Name = "NestedRadGridView";
            this.memberPicker.EditorControl.ReadOnly = true;
            this.memberPicker.EditorControl.ShowGroupPanel = false;
            this.memberPicker.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.memberPicker.EditorControl.TabIndex = 0;
            this.memberPicker.Location = new System.Drawing.Point(660, 13);
            this.memberPicker.Name = "memberPicker";
            this.memberPicker.Size = new System.Drawing.Size(298, 24);
            this.memberPicker.TabIndex = 32;
            this.memberPicker.TabStop = false;
            this.memberPicker.ThemeName = "Fluent";
            this.memberPicker.Validating += new System.ComponentModel.CancelEventHandler(this.MemberPicker_Validating);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(60, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 31);
            this.panel1.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1142, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(60, 1023);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 1023);
            this.panel2.TabIndex = 13;
            // 
            // Addnew
            // 
            this.Addnew.Active = false;
            this.Addnew.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.Addnew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Addnew.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Addnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Addnew.BorderRadius = 0;
            this.Addnew.ButtonText = "Add Borrowing";
            this.Addnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Addnew.DisabledColor = System.Drawing.Color.Gray;
            this.Addnew.Iconcolor = System.Drawing.Color.Transparent;
            this.Addnew.Iconimage = global::SofLib.Properties.Resources.plus_icon_plus_svg_png_icon_download_1;
            this.Addnew.Iconimage_right = null;
            this.Addnew.Iconimage_right_Selected = null;
            this.Addnew.Iconimage_Selected = null;
            this.Addnew.IconMarginLeft = 10;
            this.Addnew.IconMarginRight = 50;
            this.Addnew.IconRightVisible = true;
            this.Addnew.IconRightZoom = 10D;
            this.Addnew.IconVisible = true;
            this.Addnew.IconZoom = 60D;
            this.Addnew.IsTab = false;
            this.Addnew.Location = new System.Drawing.Point(660, 133);
            this.Addnew.Name = "Addnew";
            this.Addnew.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.Addnew.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.Addnew.OnHoverTextColor = System.Drawing.Color.White;
            this.Addnew.selected = false;
            this.Addnew.Size = new System.Drawing.Size(282, 41);
            this.Addnew.TabIndex = 22;
            this.Addnew.Text = "Add Borrowing";
            this.Addnew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Addnew.Textcolor = System.Drawing.Color.White;
            this.Addnew.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addnew.Click += new System.EventHandler(this.Addnew_Click);
            // 
            // dateBorow
            // 
            this.dateBorow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateBorow.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dateBorow.BorderRadius = 1;
            this.dateBorow.Color = System.Drawing.SystemColors.InactiveBorder;
            this.dateBorow.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.dateBorow.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dateBorow.DisabledColor = System.Drawing.Color.Gray;
            this.dateBorow.DisplayWeekNumbers = false;
            this.dateBorow.DPHeight = 0;
            this.dateBorow.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateBorow.FillDatePicker = false;
            this.dateBorow.ForeColor = System.Drawing.Color.Indigo;
            this.dateBorow.Icon = ((System.Drawing.Image)(resources.GetObject("dateBorow.Icon")));
            this.dateBorow.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.dateBorow.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dateBorow.Location = new System.Drawing.Point(205, 59);
            this.dateBorow.MinimumSize = new System.Drawing.Size(281, 32);
            this.dateBorow.Name = "dateBorow";
            this.dateBorow.Size = new System.Drawing.Size(298, 32);
            this.dateBorow.TabIndex = 23;
            // 
            // returnBack
            // 
            this.returnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.returnBack.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.returnBack.BorderRadius = 1;
            this.returnBack.Color = System.Drawing.SystemColors.InactiveBorder;
            this.returnBack.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.returnBack.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.returnBack.DisabledColor = System.Drawing.Color.Gray;
            this.returnBack.DisplayWeekNumbers = false;
            this.returnBack.DPHeight = 0;
            this.returnBack.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.returnBack.FillDatePicker = false;
            this.returnBack.ForeColor = System.Drawing.Color.Indigo;
            this.returnBack.Icon = ((System.Drawing.Image)(resources.GetObject("returnBack.Icon")));
            this.returnBack.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.returnBack.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.returnBack.Location = new System.Drawing.Point(660, 59);
            this.returnBack.MinimumSize = new System.Drawing.Size(281, 32);
            this.returnBack.Name = "returnBack";
            this.returnBack.Size = new System.Drawing.Size(298, 32);
            this.returnBack.TabIndex = 29;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::SofLib.Properties.Resources._340;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 10;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 10D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 60D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(1010, 0);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(55, 59);
            this.bunifuFlatButton2.TabIndex = 24;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Active = false;
            this.ReturnBtn.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.ReturnBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.ReturnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnBtn.BorderRadius = 0;
            this.ReturnBtn.ButtonText = "";
            this.ReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ReturnBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ReturnBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ReturnBtn.Iconimage = global::SofLib.Properties.Resources._44650_200;
            this.ReturnBtn.Iconimage_right = null;
            this.ReturnBtn.Iconimage_right_Selected = null;
            this.ReturnBtn.Iconimage_Selected = null;
            this.ReturnBtn.IconMarginLeft = 12;
            this.ReturnBtn.IconMarginRight = 0;
            this.ReturnBtn.IconRightVisible = true;
            this.ReturnBtn.IconRightZoom = 10D;
            this.ReturnBtn.IconVisible = true;
            this.ReturnBtn.IconZoom = 60D;
            this.ReturnBtn.IsTab = false;
            this.ReturnBtn.Location = new System.Drawing.Point(3, 0);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Normalcolor = System.Drawing.Color.ForestGreen;
            this.ReturnBtn.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.ReturnBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ReturnBtn.selected = false;
            this.ReturnBtn.Size = new System.Drawing.Size(59, 61);
            this.ReturnBtn.TabIndex = 24;
            this.ReturnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReturnBtn.Textcolor = System.Drawing.Color.White;
            this.ReturnBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBtn.Visible = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::SofLib.Properties.Resources.plus_icon_plus_svg_png_icon_download_1;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 12;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 10D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(62, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(55, 61);
            this.bunifuFlatButton1.TabIndex = 23;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // BorrowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "BorrowView";
            this.Size = new System.Drawing.Size(1202, 1023);
            this.Load += new System.EventHandler(this.BorrowView_Load);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BorrowGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowGridView)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            this.panel3.ResumeLayout(false);
            this.formPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicker.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicker.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberPicker.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberPicker.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberPicker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label AddBook;
        private System.Windows.Forms.Panel gridPanel;
        private Telerik.WinControls.UI.RadGridView BorrowGridView;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label PageTitle;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private Telerik.WinControls.UI.RadGroupBox box;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuFlatButton Addnew;
        private Bunifu.UI.WinForms.BunifuDatePicker dateBorow;
        private Bunifu.UI.WinForms.BunifuDatePicker returnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox bookPicker;
        private Telerik.WinControls.UI.RadMultiColumnComboBox memberPicker;
        private Bunifu.Framework.UI.BunifuFlatButton ReturnBtn;
    }
}
