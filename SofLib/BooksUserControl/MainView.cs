using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using BindingData;
using Telerik.WinControls.UI;
using Models;
using Telerik.WinControls.UI.Data;

namespace SofLib.BooksUserControl
{
    public partial class MainView : UserControl
    {
        private List<BooksBinding> bookslist;
        private List<BooksBinding> clone;
        private String error;
        List<Category> categoryList;
        HashSet<int> rowIndexs = new HashSet<int>();
        private int errorCount;
        private long lastId;
        public MainView()
        {
            InitializeComponent();
            this.BooksGridView.TableElement.TableHeaderHeight = 50;
            this.BooksGridView.TableElement.GroupHeaderHeight = 50;
            this.BooksGridView.TableElement.RowHeight = 50;
            panel6.Location = new Point(0, 0);
            this.BooksGridView.PageSize = (int)(this.Height - 400) / 50;
            this.panel3.Height = this.Height - 150;
            this.gridPanel.Height = this.Height - 150;
            this.BooksGridView.Height = this.gridPanel.Height;
            this.refernceBox.Enabled = false;
            panel6.Visible = false;
            panel6.AutoScroll = false;
            BooksGridView.Height = panel3.Height - 100;
            clearBtn.Visible = false;
        }

        public void MainView_Load(object sender, EventArgs e)
        {
            bookslist = BooksController.getAllBooks(out error);
            clone = bookslist.OrderBy(x => x.Id).ToList();
            if (clone.Count > 0)
                lastId = bookslist
                .OrderBy(x => x.Id)
                .Select(x => x.Id)
                .Last();
            else lastId = 0;
            this.refernceBox.Text = "BOOK_" + (++lastId);

            categoryList = Category.getAllCategories(out error);
            foreach (var a in categoryList)
            {
                this.CategoryDrop.AddItem(a.ToString());
            }

            this.yearPicker.Format = DateTimePickerFormat.Custom;
            this.yearPicker.CustomFormat = "yyyy";
            this.yearPicker.ShowUpDown = true;

            BooksGridView.DataSource = clone;

            foreach (GridViewColumn column in BooksGridView.Columns)
            {
                column.TextAlignment = ContentAlignment.MiddleCenter;
            }
        }

        private void setLabelLocation()
        {
            PageTitle.Location = new Point(0, PageTitle.Location.Y);
            int fcWidth = (this.Width - 120) / 2;
            int labelWidth = this.PageTitle.Width;
            //PageTitle.Location = new Point(fcWidth - labelWidth / 2, PageTitle.Location.Y);
            PageTitle.Location = new Point(0, PageTitle.Location.Y);
            this.tableLayoutPanel1.Width = this.BooksGridView.Width - 10;
        }

        private void MainView_SizeChanged(object sender, EventArgs e)
        {
            setLabelLocation();
        }

        private void BooksGridView_EditorRequired(object sender, Telerik.WinControls.UI.EditorRequiredEventArgs e)
        {
            String colName = BooksGridView.CurrentColumn.HeaderText;
            if (colName.ToLower().Equals("id") || colName.ToLower().Equals("reference"))
            {
                BooksGridView.CurrentColumn.ReadOnly = true;
            }
            else if (colName.ToLower().Equals("category"))
            {
                VirtualGridDropDownListEditor ddl = new VirtualGridDropDownListEditor();
                RadDropDownListEditorElement element = ddl.EditorElement as RadDropDownListEditorElement;
                element.DataSource = categoryList;
                element.DisplayMember = "categoryName";
                element.ValueMember = "categoryName";
                element.SelectedIndex = 1;
                e.Editor = ddl;
            }

        }



        private void BooksGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            String colName = BooksGridView.CurrentColumn.HeaderText;
            if (colName.ToLower().Equals("id") || colName.ToLower().Equals("reference"))
            {
                BooksGridView.CurrentColumn.ReadOnly = true;
            }
        }
        private void Panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BooksGridView_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            GridViewEditManager g = (GridViewEditManager)sender;
            int rowIndex = g.GridViewElement.CurrentRow.Index;
            rowIndexs.Add(rowIndex);
            this.saveModif.Visible = true;
            clearBtn.Visible = true;
        }
        private void SaveModif_Click_1(object sender, EventArgs e)
        {
            foreach (var i in rowIndexs)
            {
                String error;
                BooksBinding b = clone[i];
                Book book = b.reverseBind();
                BooksController.UpdateBook(book, out error);
                if (!String.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error);
                    return;
                }
            }
            MessageBox.Show("Changed with successfull", rowIndexs.Count + "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.saveModif.Visible = false;
        }

        


        private void Addnew_Click(object sender, EventArgs e)
        {
            errorCount = 0;
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (errorCount>-7)
                MessageBox.Show("Plz fill selected inputs","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                else
                {
                    String error;
                    int i = CategoryDrop.selectedIndex;
                    Category c =  categoryList.ElementAt(i);
                    Book b = new Book(0,refernceBox.Text, titleBox.Text, authorBox.Text, Convert.ToInt32(yearPicker.Text),
                        Convert.ToInt32(nbPagesBox.Text), Convert.ToInt32(nbChaptir.Text), Convert.ToInt32(editionBox.Text), Convert.ToInt32(currentQ.Text),
                        Convert.ToInt32(totalQ.Text), c);
                    BooksController.addBook(b,out error);
                    if (!String.IsNullOrEmpty(error))
                    {
                        MessageBox.Show(error);
                        return;
                    }
                    else
                    {
                        b.Id = lastId;
                        BooksBinding bindBook = new BooksBinding(b);
                        clone.Add(bindBook);
                        bookslist = clone;
                        BooksGridView.DataSource = null;
                        BooksGridView.DataSource = clone;
                        this.refernceBox.Text = "BOOK_"+(++lastId).ToString();
                        BooksGridView.Refresh();
                        formPanel.Visible = false;
                        gridPanel.Visible = true;
                        MessageBox.Show("Book Added successfull", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearForm();
                    }
                }
            }

        }
        public void clearForm()
        {
            titleBox.ResetText();
            authorBox.ResetText();
            yearPicker.ResetText();
            nbPagesBox.Text = "0";
            nbChaptir.Text = "0";
            editionBox.Text = "0";
            currentQ.Text = "0";
            totalQ.Text = "0";

        }
        private void EditionBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                MessageBox.Show("This field accept only numeric values", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NbChaptir_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                MessageBox.Show("This field accept only numeric values", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NbPagesBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                MessageBox.Show("This field accept only numeric values", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void CategoryDrop_Validating(object sender, CancelEventArgs e)
        {
            if (CategoryDrop.selectedIndex < 0)
            {
                e.Cancel = false;
                errorProvider1.SetError(CategoryDrop, "please select the category");
                errorCount++;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(CategoryDrop, null);
                errorCount--;
            }
        }
        private void NbPagesBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(this.nbPagesBox.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(nbPagesBox, "The number of pages is required");
                errorCount++;
            }
            else if (Convert.ToInt32(this.nbPagesBox.Text) < 0)
            {
                e.Cancel = false;
                errorProvider1.SetError(nbPagesBox, "can't be negative");
                errorCount++;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(nbPagesBox, null);
                errorCount--;
            }
        }

        private void EditionBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(this.editionBox.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(editionBox, "The number of Edition is required");
                errorCount++;
            }
            else if (Convert.ToInt32(this.editionBox.Text) < 0)
            {
                e.Cancel = false;
                errorProvider1.SetError(editionBox, "can't be negative");
                errorCount++;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(editionBox, null);
                errorCount--;
            }
        }

        private void NbChaptir_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(this.nbChaptir.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(nbChaptir, "The number of Chapters is required");
                errorCount++;
            }
            else if (Convert.ToInt32(this.nbChaptir.Text) < 0)
            {
                e.Cancel = false;
                errorProvider1.SetError(nbChaptir, "can't be negative");
                errorCount++;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(nbChaptir, null);
                errorCount--;
            }
        }

        private void TitleBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(this.titleBox.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(titleBox, "The Field cannot be empty");
                errorCount++;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(titleBox, null);
                errorCount--;
            }
        }

        private void AuthorBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(this.authorBox.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(authorBox, "The Field cannot be empty");
                errorCount++;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(authorBox, null);
                errorCount--;
            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            gridPanel.Visible = false;
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            formPanel.Visible = false;
            gridPanel.Visible = true;
        }

        private void TotalQ_OnValueChanged(object sender, EventArgs e)
        {
            this.currentQ.Text = this.totalQ.Text;
        }

        private void TotalQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                MessageBox.Show("This field accept only numeric values", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TotalQ_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(this.totalQ.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(totalQ, "The Inital Quantity of copyies of this book is required");
                errorCount++;
            }
            else if (Convert.ToInt32(this.totalQ.Text) < 0)
            {
                e.Cancel = false;
                errorProvider1.SetError(totalQ, "can't be negative");
                errorCount++;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(totalQ, null);
                errorCount--;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.clone = bookslist;
            this.BooksGridView.DataSource = null;
            this.BooksGridView.DataSource = this.clone;
            this.saveModif.Visible = false;
            this.rowIndexs.Clear();
            clearBtn.Visible = false;
        }
    }
}
