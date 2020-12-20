using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbConn;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Models
{
    public class Book
    {

        private long id;
        private String bookReference;
        private String booktitle;
        private String author;
        private int releaseYear;
        private int nbPages;
        private int nbChapter;
        private int edition;
        private int currentQuantity;
        private int totalQuantity;
        private Category category;

        public Book()
        {
           
        }

        public Book(long id, string bookReference, string booktitle, string author, int releaseYear, int nbPages, int nbChapter, int edition, int currentQuantity, int totalQuantity, Category category)
        {
            this.Id = id;
            this.BookReference = bookReference;
            this.Booktitle = booktitle;
            this.Author = author;
            this.ReleaseYear = releaseYear;
            this.NbPages = nbPages;
            this.NbChapter = nbChapter;
            this.Edition = edition;
            this.CurrentQuantity = currentQuantity;
            this.TotalQuantity = totalQuantity;
            this.Category = category;
        }


        public long Id { get => id; set => id = value; }
        public string BookReference { get => bookReference; set => bookReference = value; }
        public string Booktitle { get => booktitle; set => booktitle = value; }
        public string Author { get => author; set => author = value; }
        public int ReleaseYear { get => releaseYear; set => releaseYear = value; }
        public int NbPages { get => nbPages; set => nbPages = value; }
        public int NbChapter { get => nbChapter; set => nbChapter = value; }
        public int Edition { get => edition; set => edition = value; }
        public int CurrentQuantity { get => currentQuantity; set => currentQuantity = value; }
        public int TotalQuantity { get => totalQuantity; set => totalQuantity = value; }
        public Category Category { get => category; set => category = value; }

        public override bool Equals(object obj)
        {
            return obj is Book book &&
                   BookReference == book.BookReference;
        }

        public static List<Book> getAllBooks(out String error)
        {
           
            List<Book> bookList = new List<Book>();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from book b join category c on b.category_id = c.id;", DbConnection.GetInstance());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category(reader.GetInt64(9), reader.GetString(12));
                    Book b = new Book(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6),reader.GetInt32(7), reader.GetInt32(9), reader.GetInt32(8), c);
                    bookList.Add(b);
                }
                error = "";
                DbConnection.GetInstance().Close();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return bookList;
        }
        public static void updateBook(Book b, out String error)
        {
            try
            {
                string strSQL = "UPDATE book SET `book_title` = @title, `author`= @author," +
                    "`release_year` = @year , `nb_pages` = @pages ,`nbChapter` = @nbchap," +
                    " `edition`= @edition, `category_id`= @catid , `total_quantity`= @totalQ , `current_quantity`= @currentQ  WHERE id like @id ;";
                MySqlCommand cmd = new MySqlCommand(strSQL, DbConnection.GetInstance());

                cmd.Parameters.AddWithValue("@id", b.Id);
                cmd.Parameters.AddWithValue("@title", b.Booktitle);
                cmd.Parameters.AddWithValue("@author", b.Author);
                cmd.Parameters.AddWithValue("@year", b.ReleaseYear);
                cmd.Parameters.AddWithValue("@pages", b.NbPages);
                cmd.Parameters.AddWithValue("@nbchap", b.NbChapter);
                cmd.Parameters.AddWithValue("@edition", b.Edition);
                cmd.Parameters.AddWithValue("@currentQ", b.CurrentQuantity);
                cmd.Parameters.AddWithValue("@totalQ", b.totalQuantity);
                cmd.Parameters.AddWithValue("@catid", b.Category.Id); 
                int n = cmd.ExecuteNonQuery();
                DbConnection.GetInstance().Close();
                error = "";
            }
            catch (Exception e)
            {
                error = e.Message;
            }

        }
        public static void bookOut(Book b, out String error)
        {
            try
            {
                string strSQL = "UPDATE `book` SET `current_quantity` = @currentQ WHERE `book`.`id` = @id;";
                MySqlCommand cmd = new MySqlCommand(strSQL, DbConnection.GetInstance());
                int q = b.CurrentQuantity - 1;
                cmd.Parameters.AddWithValue("@id", b.Id);
                cmd.Parameters.AddWithValue("@currentQ", q);
                int n = cmd.ExecuteNonQuery();
                DbConnection.GetInstance().Close();
                error = "";
            }
            catch (Exception e)
            {
                error = e.Message;
            }

        }
        public static void bookIn(Book b, out String error)
        {
            try
            {
                if (b.TotalQuantity >= b.CurrentQuantity)
                {
                    string strSQL = "UPDATE `book` SET `current_quantity` = @currentQ WHERE `book`.`id` = @id; ";
                    MySqlCommand cmd = new MySqlCommand(strSQL, DbConnection.GetInstance());
                    int q = b.CurrentQuantity + 1;
                    cmd.Parameters.AddWithValue("@id", b.Id);
                    cmd.Parameters.AddWithValue("@currentQ", q);
                    int n = cmd.ExecuteNonQuery();
                    DbConnection.GetInstance().Close();
                    error = "";
                }
                error = "";
            }
            catch (Exception e)
            {
                error = e.Message;
                //MessageBox.Show(e.ToString());
            }

        }
        public static void AddBook(Book b, out String error)
        {
            try
            {
                String strSQL = "insert into book (`id`, `book_reference`, `book_title`, `author`, `release_year`, `nb_pages`, `nbChapter`, `edition`, `category_id`, `total_quantity` , `current_quantity`) " +
                    "VALUES(Null,@reference,@title,@author,@year,@pages,@nbchap,@edition,@catid,@totalQ,@currentQ);";
                MySqlCommand cmd = new MySqlCommand(strSQL, DbConnection.GetInstance());
                cmd.Parameters.AddWithValue("@reference", b.BookReference);
                cmd.Parameters.AddWithValue("@title", b.Booktitle);
                cmd.Parameters.AddWithValue("@author", b.Author);
                cmd.Parameters.AddWithValue("@year", b.ReleaseYear);
                cmd.Parameters.AddWithValue("@pages", b.NbPages);
                cmd.Parameters.AddWithValue("@nbchap", b.nbChapter);
                cmd.Parameters.AddWithValue("@edition", b.Edition);
                cmd.Parameters.AddWithValue("@currentQ", b.CurrentQuantity);
                cmd.Parameters.AddWithValue("@totalQ", b.totalQuantity);
                cmd.Parameters.AddWithValue("@catid", b.Category.Id);
                cmd.ExecuteNonQuery();
                DbConnection.GetInstance().Close();
                error = "";
            }
            catch (Exception e)
            {
                error = e.Message;
            }
        }
        public string getfulledition()
        {
            return "Edition "+this.Edition; 
        }

        public override string ToString()
        {
            return this.Id + " / " + this.BookReference + " / " + this.Booktitle + " / " + this.Author
                + " / " + this.ReleaseYear + " / " + this.NbPages + " / "+ this.NbChapter + " / "
                + this.Edition + " / "+this.Category.ToString(); 

        }

        public override int GetHashCode()
        {
            var hashCode = -744832110;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BookReference);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Booktitle);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Author);
            hashCode = hashCode * -1521134295 + ReleaseYear.GetHashCode();
            hashCode = hashCode * -1521134295 + NbPages.GetHashCode();
            hashCode = hashCode * -1521134295 + NbChapter.GetHashCode();
            hashCode = hashCode * -1521134295 + Edition.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Category>.Default.GetHashCode(Category);
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BookReference);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Booktitle);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Author);
            hashCode = hashCode * -1521134295 + ReleaseYear.GetHashCode();
            hashCode = hashCode * -1521134295 + NbPages.GetHashCode();
            hashCode = hashCode * -1521134295 + NbChapter.GetHashCode();
            hashCode = hashCode * -1521134295 + Edition.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Category>.Default.GetHashCode(Category);
            return hashCode;
        }
    }
}
