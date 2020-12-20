using DbConn;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Member
    {   
        private long id;
        private String code;
        private String cin;
        private String first_name;
        private String last_name;
        private String email;
        private DateTime birth_date;

        public Member(long id, string code, string cin, string first_name, string last_name, string email, DateTime birth_date)
        {
            this.Id = id;
            this.Code = code;
            this.Cin = cin;
            this.First_name = first_name;
            this.Last_name = last_name;
            this.Email = email;
            this.Birth_date = birth_date;
        }

        public Member()
        {
        }

        public long Id { get => id; set => id = value; }
        public string Code { get => code; set => code = value; }
        public string Cin { get => cin; set => cin = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Birth_date { get => birth_date; set => birth_date = value; }

        public override string ToString()
        {
            return "Id "+this.Id
            + " Code " + this.Code +" Cin "+this.Cin+" First Name "+ this.First_name +" Last Name "+this.Last_name +" Email "+this.Email
            +" Birth Date "+this.Birth_date;
        }

        public static List<Member> getAllMembers(out String error)
        {

            List<Member> membersList = new List<Member>();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from members order by id;", DbConnection.GetInstance());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Member m = new Member(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6));
                    membersList.Add(m);
                }
                error = "";
                DbConnection.GetInstance().Close();
            }
            catch (Exception ex)
            {
                error = ex.ToString();

            }
            return membersList;
        }

        public static void AddMember(Member m, out String error)
        {
            try
            {
                String strSQL = "insert into members (`id`, `code`, `first_name`, `last_name`, `cin`, `email`, `birth_date`)" +
                    " VALUES(Null,@code,@fname,@lname,@cin,@email,@bdate);";
                MySqlCommand cmd = new MySqlCommand(strSQL, DbConnection.GetInstance());
                cmd.Parameters.AddWithValue("@code", m.Code);
                cmd.Parameters.AddWithValue("@fname", m.First_name);
                cmd.Parameters.AddWithValue("@lname", m.Last_name);
                cmd.Parameters.AddWithValue("@cin", m.Last_name);
                cmd.Parameters.AddWithValue("@email", m.Email);
                cmd.Parameters.AddWithValue("@bdate", m.Birth_date);
                cmd.ExecuteNonQuery();
                DbConnection.GetInstance().Close();
                error = "";
            }
            catch (Exception e)
            {
                error = e.Message;
            }
        }

        public static void UpadateMembers(Member m, out string error)
        {
            try
            {
                string strSQL = "update members SET `first_name` = @fname, `last_name` = @lname, `cin` = @cin, `email` = @email , `birth_date` = @bdate WHERE id like @id ;";
                MySqlCommand cmd = new MySqlCommand(strSQL, DbConnection.GetInstance());
                cmd.Parameters.AddWithValue("@id", m.Id);
                cmd.Parameters.AddWithValue("@fname", m.First_name);
                cmd.Parameters.AddWithValue("@lname", m.Last_name);
                cmd.Parameters.AddWithValue("@cin", m.Last_name);
                cmd.Parameters.AddWithValue("@email", m.Email);
                cmd.Parameters.AddWithValue("@bdate", m.Birth_date);
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
