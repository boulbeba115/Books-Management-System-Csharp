using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbConn;
using MySql.Data.MySqlClient;

namespace Models
{
    public class Category
    {
        long id;
        String categoryName;
        static List<Book> booksList;

        public Category()
        {
        }

        public Category(long id, string categoryName)
        {
            this.Id = id;
            this.CategoryName = categoryName;
        }

        public long Id { get => id; set => id = value; }

        public string CategoryName { get => categoryName; set => categoryName = value; }
        public static List<Book> BooksList { get => booksList; set => booksList = value; }

        public override string ToString()
        {
            return this.categoryName;
        }
        public static List<Category> getAllCategories(out String error)
        {

            List<Category> categoryList = new List<Category>();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from category order by id;", DbConnection.GetInstance());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category(reader.GetInt64(0), reader.GetString(1));
                    categoryList.Add(c);
                }
                error = "";
                DbConnection.GetInstance().Close();
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
         
            }
            return categoryList;
        }
        public static Category getCategoryByName(String cat,out String error)
        {

            Category category = new Category() ;
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from category where category_name = @catName ;", DbConnection.GetInstance());
                cmd.Parameters.AddWithValue("@catName", cat);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    category =  new Category(reader.GetInt64(0), reader.GetString(1));
                }
                error = "succes";
                DbConnection.GetInstance().Close();
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();

            }
            return category;
        }

        public static void AddCategory(Category c, out String error)
        {
            try
            {
                String strSQL = "insert into category (`id`, `category_name`) VALUES(Null,@catName);";
                MySqlCommand cmd = new MySqlCommand(strSQL, DbConnection.GetInstance());
                cmd.Parameters.AddWithValue("@catName", c.CategoryName);
                cmd.ExecuteNonQuery();
                DbConnection.GetInstance().Close();
                error = "";
            }
            catch (Exception e)
            {
                error = e.Message;
                
            }
        }

        public static void UpadateCategory(Category c, out string error)
        {
            try
            {
                string strSQL = "update category SET `category_name` = @catName  WHERE id like @id ;";
                MySqlCommand cmd = new MySqlCommand(strSQL, DbConnection.GetInstance());
                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.Parameters.AddWithValue("@catName", c.CategoryName);
                int n = cmd.ExecuteNonQuery();
                DbConnection.GetInstance().Close();
                error = "";
            }
            catch (Exception e)
            {
                error = e.Message;
            }
        }
    }
}
