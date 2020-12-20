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
using Telerik.WinControls.UI;

namespace SofLib.UsersControl
{
    public partial class UsersView : UserControl
    {
        private List<Member> memberlist;
        private List<Member> clone;
        private String error;
        List<Category> categoryList;
        HashSet<int> rowIndexs = new HashSet<int>();
        private int errorCount;
        private long lastId =0;
        public UsersView()
        {
            InitializeComponent();
            this.Load += new EventHandler(UserView_Load);
            this.MembersGridView.TableElement.TableHeaderHeight = 50;
            this.MembersGridView.TableElement.GroupHeaderHeight = 50;
            this.MembersGridView.TableElement.RowHeight = 50;
            panel6.Location = new Point(0, 0);
            this.MembersGridView.PageSize = (int)(this.Height - 400) / 50;
            this.panel3.Height = this.Height - 150;
            this.gridPanel.Height = this.Height - 150;
            this.MembersGridView.Height = this.gridPanel.Height;
            this.codeBox.Enabled = false;
            panel6.Visible = false;
            panel6.AutoScroll = true;
            MembersGridView.Height = panel3.Height - 100;
            this.cinBox.MaxLength = 8;
            birthDatePicker.MaxDate = DateTime.Today;
            clearBtn.Visible = false;
        }

        public void UserView_Load(object sender, EventArgs e)
        {
            
            memberlist = MembersController.getAllMembers(out error);
            clone = memberlist;
            if (clone.Count > 0)
                lastId = memberlist
                .OrderBy(x => x.Id)
                .Select(x => x.Id)
                .Last();
            else lastId = 0;
            MembersGridView.DataSource = clone;
            this.codeBox.Text = "Member_" + (++lastId).ToString();

            foreach (var column in MembersGridView.Columns)
            {
                column.TextAlignment = ContentAlignment.MiddleCenter;
            }

        }


        private void MembersGridView_EditorRequired(object sender, Telerik.WinControls.UI.EditorRequiredEventArgs e)
        {
            String colName = MembersGridView.CurrentColumn.HeaderText;
            if (colName.ToLower().Equals("id") || colName.ToLower().Equals("code"))
            {
                MembersGridView.CurrentColumn.ReadOnly = true;
            }
        }



        private void BooksGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            String colName = MembersGridView.CurrentColumn.HeaderText;
            if (colName.ToLower().Equals("id") || colName.ToLower().Equals("code"))
            {
                MembersGridView.CurrentColumn.ReadOnly = true;
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
        private void SaveModif_Click(object sender, EventArgs e)
        {
            foreach (var i in rowIndexs)
            {
                String error;
                Member m = clone[i];
                MembersController.UpdateMemeber(m, out error);
                if (!String.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error);
                    return;
                }
            }
            MessageBox.Show("Changed successfully", rowIndexs.Count + "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.saveModif.Visible = false;
        }




        private void Addnew_Click_1(object sender, EventArgs e)
        {
            Member m;
            errorCount = 0;
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (errorCount > -4)
                    MessageBox.Show("Plz fill selected inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String error;
                    m = new Member(0, this.codeBox.Text, this.cinBox.Text, this.fnameBox.Text, this.lastNameBox.Text, this.mailBox.Text, this.birthDatePicker.Value);
                    MembersController.addMemeber(m, out error);
                    if (!String.IsNullOrEmpty(error))
                    {
                        MessageBox.Show(error,"Error Inserting to data Base");
                        return;
                    }
                    else
                    {
                        m.Id = lastId;
                        clone.Add(m);
                        memberlist = clone;
                        MembersGridView.DataSource = null;
                        MembersGridView.DataSource = clone;
                        MembersGridView.Refresh();
                        formPanel.Visible = false;
                        gridPanel.Visible = true;
                        clearForm();
                        MessageBox.Show("Member Added successfull", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }
        public void clearForm()
        {
            this.codeBox.Text = "Member_" + (++lastId).ToString();
            this.cinBox.ResetText();
            this.fnameBox.ResetText();
            this.lastNameBox.ResetText();
            this.mailBox.ResetText();
            this.birthDatePicker.ResetText();
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

        private void CinBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && this.cinBox.Text.Length<=8;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                MessageBox.Show("This field accept only numeric values", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CinBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(this.cinBox.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(cinBox, "The cin number of pages is required");
                errorCount++;
            }
            else if (this.cinBox.Text.Length != 8)
            {
                e.Cancel = false;
                errorProvider1.SetError(cinBox, "The Length of cin number should be 8");
                errorCount++;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cinBox, null);
                errorCount--;
            }
           

        }

        private void FnameBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(this.fnameBox.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(fnameBox, "The First Name is required");
                errorCount++;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(fnameBox, null);
                errorCount--;
            }
        }

        private void LastNameBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(this.lastNameBox.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(this.lastNameBox, "The LastName Name is required");
                errorCount++;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(lastNameBox, null);
                errorCount--;
            }
        }

        private void MailBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(this.mailBox.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(this.mailBox, "The Mail is required");
                errorCount++;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mailBox, null);
                errorCount--;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.clone = memberlist;
            this.MembersGridView.DataSource = null;
            this.MembersGridView.DataSource = this.clone;
            this.saveModif.Visible = false;
            this.rowIndexs.Clear();
            clearBtn.Visible = false;
        }
    }
}
