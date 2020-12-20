using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DbConn
{
    public class DbConnection
    {
        private static String chaineCnx = "SERVER=127.0.0.1;" + "DATABASE=bdbook;" + "UID=root;" +
        "PASSWORD=;";
        private static MySqlConnection cnx = new MySqlConnection(chaineCnx);
        public static MySqlConnection GetInstance()
        {
            try
            {
                if (cnx.State != System.Data.ConnectionState.Open)
                    cnx.Open();
            }
            catch (Exception e)
            {
                Console.Write(e.Message + "erreur de connexion");
            }
            return cnx;
        }

        public static void close()
        {
            try
            {
                cnx.Close();
            }
            catch (Exception e)
            {
                Console.Write(e.Message + "erreur de connexion");

            }
        }
    }
}
