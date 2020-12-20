using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers;
using BindingData;
using Telerik.WinControls.UI;

namespace SofLib.BooksUserControl
{
    public partial class BorrowView : UserControl
    {
        private List<BooksBinding> bookList;
        private List<Member> memberList;
        private List<Borrow> borrowList;
        private List<BorrowBinding> borrowBindingList;
        private int errorCount = 0;
        private long lastId = 0;
        private Book selectedBook = new Book();
        public BorrowView()
        {
            InitializeComponent();
            this.BorrowGridView.TableElement.TableHeaderHeight = 50;
            this.BorrowGridView.TableElement.GroupHeaderHeight = 50;
            this.BorrowGridView.TableElement.RowHeight = 50;
            panel6.Location = new Point(0, 0);
            this.BorrowGridView.PageSize = (int)(this.Height - 400) / 50;
            this.panel3.Height = this.Height - 150;
            this.gridPanel.Height = this.Height - 150;
            this.BorrowGridView.Height = this.gridPanel.Height;
            panel6.Visible = false;
            panel6.AutoScroll = true;
            BorrowGridView.Height = panel3.Height - 100;
            this.dateBorow.MinDate = DateTime.Today;
            this.returnBack.MinDate = this.dateBorow.Value;

        }

        public void BorrowView_Load(object sender, EventArgs e)
        {
            string berror, merror, borrowError;
            bookList = BooksController.getAllBooks(out berror);
            memberList = MembersController.getAllMembers(out merror);
            borrowList = BorrowController.getAllBorrows(out borrowError);
            borrowBindingList = (new BorrowBinding()).getBindedBorrows(borrowList);
            memberPicker.DataSource = memberList;
            bookPicker.DataSource = bookList;
            BorrowGridView.DataSource = borrowBindingList;
            foreach (GridViewColumn column in BorrowGridView.Columns)
            {
                column.TextAlignment = ContentAlignment.MiddleCenter;
            }
            try
            {
                if (borrowList.Count > 0)
                {
                    lastId = borrowList
                      .OrderBy(x => x.Id)
                      .Select(x => x.Id)
                      .Last();
                }
               
                validateDbConn(berror);
                validateDbConn(merror);
                validateDbConn(borrowError);
            }
            catch(Exception ex)
            {

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

        private void Addnew_Click(object sender, EventArgs e)
        {
            Member m;
            Book b;
            Borrow borrow;
            errorCount = 0;
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (errorCount > -2)
                    MessageBox.Show("Plz fill selected inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        String error, outError;
                        int indexb = bookPicker.SelectedIndex;
                        int indexm = memberPicker.SelectedIndex;
                        m = memberList[indexm];
                        BooksBinding boo = bookList[indexb];
                        b = boo.reverseBind();
                        DateTime dateOut = dateBorow.Value;
                        DateTime dateIn = dateBorow.Value;
                        borrow = new Borrow(0, m, b, dateIn, dateOut);
                        BorrowController.addBorrow(borrow, out error);
                        if (!String.IsNullOrEmpty(error))
                        {
                            MessageBox.Show(error, "Error Inserting to data Base");
                            return;
                        }
                        else
                        {
                            BooksController.bookOut(b,out outError);
                            if (!String.IsNullOrEmpty(outError))
                            {
                                MessageBox.Show(error, "Error Updating Books Quantity");
                                return;
                            }
                            borrow.Id = ++lastId;
                            BorrowBinding bb = new BorrowBinding(borrow);
                            borrowBindingList.Add(bb);
                            BorrowGridView.DataSource = null;
                            BorrowGridView.DataSource = borrowBindingList;
                            BorrowGridView.Refresh();
                            formPanel.Visible = false;
                            gridPanel.Visible = true;
                            MessageBox.Show("Added successfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    } catch(Exception ex)
                    {

                    }
                   
                }
            }
        }
        private void validateDbConn(String error)
        {
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Error Inserting to data Base",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void BookPicker_Validating(object sender, CancelEventArgs e)
        {
            if (bookPicker.SelectedValue is null)
            {
                e.Cancel = false;
                errorProvider1.SetError(bookPicker, "Please pick a book");
                errorCount++;
            }
            else
            {
                int indexb = bookPicker.SelectedIndex;
                BooksBinding boo = bookList[indexb];
                Book b = boo.reverseBind();
                if (b.CurrentQuantity < 0)
                {
                    e.Cancel = false;
                    errorProvider1.SetError(bookPicker, "This book '"+b.BookReference+"' is not avaible now");
                    bookPicker.SelectedIndex = -1;
                    errorCount++;
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(bookPicker, null);
                    errorCount--;
                }
            }
          
        }

        private void MemberPicker_Validating(object sender, CancelEventArgs e)
        {
            if (this.memberPicker.SelectedValue is null)
            {
                e.Cancel = false;
                errorProvider1.SetError(memberPicker, "Please pick the member that will borrow the book");
                errorCount++;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(memberPicker, null);
                errorCount--;
            }
        }

        private void BorrowGridView_CellClick(object sender, GridViewCellEventArgs e)
        {
            Borrow b = ((BorrowBinding)BorrowGridView.CurrentRow.DataBoundItem).getReverseBinding(borrowList);
            if (b != null)
            {
                this.selectedBook = b.Book;
                MessageBox.Show(b.Book.CurrentQuantity+"");
                ReturnBtn.Visible = true;
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            String errorIn;
            BooksController.bookIn(selectedBook, out errorIn);
            if (!String.IsNullOrEmpty(errorIn))
            {
                MessageBox.Show(errorIn, "Error Updating Books Quantity");
                return;
            }
            MessageBox.Show("Book Recived And Quantity Updated", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
