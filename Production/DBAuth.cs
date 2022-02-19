using System;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Security.Cryptography;



namespace Production
{
    public class DBAuth
    {

        private static readonly string dataSource = "Data Source=DB.db;Version=3;";
        public static void InitializeDatabase()
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    string sql_command = "CREATE TABLE users("
                    + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                    + "login TEXT, "
                    + "password TEXT; ";
                    cmd.CommandText = sql_command;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Dispose();
            }
        }
        public int UsersCount()
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    string sql_command = "SELECT count(id) FROM users";
                    cmd.CommandText = sql_command;
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch
            {
                return -1;
            }
            finally
            {
                conn.Dispose();
            }
            return -1;
        }

        public static bool ValidUser(string login, string password)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format("SELECT * "
                    + "FROM users "
                    + "where login = '{0}' AND "
                    + "password = '{1}'",
                    login, Hash(password));
                    SQLiteDataReader usersCount = cmd.ExecuteReader();
                    return usersCount.HasRows;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return false;
        }


        private static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

    }
}