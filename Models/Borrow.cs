using DbConn;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Borrow
    {
        private long id;
        private Member member;
        private Book book;
        private DateTime dateBringback;
        private DateTime dateBorrow;

        public Borrow()
        {
        }

        public Borrow(long id, Member member, Book book, DateTime dateBringback, DateTime dateBorrow)
        {
            this.Id = id;
            this.Member = member;
            this.Book = book;
            this.DateBringback = dateBringback;
            this.DateBorrow = dateBorrow;
        }

        public override string ToString()
        {
            return this.Id +"  "+ this.Member.ToString() + "  " + this.Book.ToString() + "  " +this.DateBringback + "  " + this.DateBorrow;
        }

        public long Id { get => id; set => id = value; }
        public Member Member { get => member; set => member = value; }
        public Book Book { get => book; set => book = value; }
        public DateTime DateBringback { get => dateBringback; set => dateBringback = value; }
        public DateTime DateBorrow { get => dateBorrow; set => dateBorrow = value; }


        public static List<Borrow> getAllBorrows(out String error)
        {

            List<Borrow> borrowList = new List<Borrow>();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM borrow bor INNER JOIN members m on m.id = bor.member_id "+
                    "INNER join book b on b.id = bor.book_id "+
                    "inner JOIN category c on c.id = b.category_id;", DbConnection.GetInstance());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category(reader.GetInt64(22), reader.GetString(23));
                    Book b = new Book(reader.GetInt64(2),reader.GetString(13), reader.GetString(14), reader.GetString(15),
                        reader.GetInt32(16), reader.GetInt32(17), reader.GetInt32(18), reader.GetInt32(19),
                        reader.GetInt32(21), reader.GetInt32(20), c);
                    Member m = new Member(reader.GetInt64(1), reader.GetString(6), reader.GetString(9), reader.GetString(7), reader.GetString(8), reader.GetString(10), reader.GetDateTime(11));
                    Borrow borrow = new Borrow(reader.GetInt64(0),m,b, reader.GetDateTime(3), reader.GetDateTime(4));
                    borrowList.Add(borrow);
                }
                error = "";
                DbConnection.GetInstance().Close();
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();

            }
            return borrowList;
        }
 

        public static void AddBorrow(Borrow bor, out String error)
        {
            try
            {
                String strSQL = "insert into borrow  (`id`, `book_id`, `member_id`, `date_borrow`, `date_bringback`) VALUES(Null,@book,@member,@dataB,@dataf);";
                MySqlCommand cmd = new MySqlCommand(strSQL, DbConnection.GetInstance());
                cmd.Parameters.AddWithValue("@book", bor.Book.Id);
                cmd.Parameters.AddWithValue("@member", bor.Member.Id);
                cmd.Parameters.AddWithValue("@dataB", bor.DateBorrow);
                cmd.Parameters.AddWithValue("@dataf", bor.DateBringback);
                cmd.ExecuteNonQuery();
                DbConnection.GetInstance().Close();
                error = "";
            }
            catch (Exception e)
            {
                error = e.Message;

            }
        }

        public static void UpadateBorrowing(Borrow bor, out string error)
        {
            try
            {
                string strSQL = "update borrow SET `date_borrow` = @dataB,`date_bringback` = @dataf WHERE id like @id ;";
                MySqlCommand cmd = new MySqlCommand(strSQL, DbConnection.GetInstance());
                cmd.Parameters.AddWithValue("@id", bor.Id);
                cmd.Parameters.AddWithValue("@dataB", bor.DateBorrow);
                cmd.Parameters.AddWithValue("@dataf", bor.DateBringback);
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
