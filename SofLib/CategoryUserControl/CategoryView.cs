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

namespace SofLib.CategoryUserControl
{
    public partial class CategoryView : UserControl
    {
        private List<Category> categoriesList;
        private List<Category> clone;
        private Boolean ValidError=false;
        private long lastId ;
        private HashSet<int> rowIndexs = new HashSet<int>();
        public CategoryView()
        {
            InitializeComponent();
            this.Load += new EventHandler(load_Category_View);
            panel6.AutoScroll = true;
        }

        public void load_Category_View(object sender, EventArgs e)
        {
            this.CategoryGridView.TableElement.TableHeaderHeight = 50;
            this.CategoryGridView.TableElement.GroupHeaderHeight = 50;
            this.CategoryGridView.TableElement.RowHeight = 50;
            this.CategoryGridView.TableElement.TextAlignment = ContentAlignment.MiddleLeft;
            String error;
            categoriesList = CategoriesController.getAllCategories(out error);
            clone = categoriesList;
            CategoryGridView.DataSource = clone;
            if(clone.Count>0)
                lastId = clone.Select(c => c.Id).Last();
            clearBtn.Visible = false;

            foreach (GridViewColumn column in CategoryGridView.Columns)
            {
                column.TextAlignment = ContentAlignment.MiddleCenter;
            }
        }

        private void TitleBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(this.categoryName.Text))
            {
                e.Cancel = false;
                categoryName.Focus();
                errorProvider1.SetError(categoryName, "The Category Name can't be empty");
                ValidError = true;
            }
            else
            {
                e.Cancel = false;
                ValidError = false;
                errorProvider1.SetError(categoryName, null);
            }
        }

        private void Addnew_Click(object sender, EventArgs e)
        {
            Category c;
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (ValidError)
                    MessageBox.Show("Plz fill selected inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String error;
                    c = new Category(0, categoryName.Text);
                    CategoriesController.addCategory(c,out error);
                    if (!String.IsNullOrEmpty(error))
                    {
                        MessageBox.Show(error,"Error DataBase",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                       
                        c.Id = ++lastId;
                        clone.Add(c);
                        categoriesList = clone;
                        CategoryGridView.DataSource = null;
                        CategoryGridView.DataSource = clone;
                        CategoryGridView.Refresh();
                        this.categoryName.ResetText();
                        MessageBox.Show("Category Added successfull","Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }


        private void CategoryGridView_EditorRequired(object sender, Telerik.WinControls.UI.EditorRequiredEventArgs e)
        {
            String colName = CategoryGridView.CurrentColumn.HeaderText;
            if (colName.ToLower().Equals("id") )
            {
                CategoryGridView.CurrentColumn.ReadOnly = true;
            }
        }

        private void CategoryGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

        }

        private void CategoryGridView_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
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
                Category c = clone[i];
                CategoriesController.UpdateCategory(c, out error);
                if (!String.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error, "Error DataBase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("Changed with successfull", rowIndexs.Count + "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.saveModif.Visible = false;


        }
        public void cancelModifications()
        {
            this.saveModif.Visible = false;
            this.ValidError = false;
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.clone = categoriesList;
            this.CategoryGridView.DataSource = null;
            this.CategoryGridView.DataSource = this.clone;
            this.saveModif.Visible = false;
            this.rowIndexs.Clear();
            clearBtn.Visible = false;
        }
    }
}
