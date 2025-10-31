using Npgsql;
using PraktikumMingguke10.DbAccess;
using PraktikumMingguke10.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PraktikumMingguke10.Controller
{
    public class AuthController
    {
        private DbContext Context;
        public AuthController()
        {
            Context = new DbContext();
        }
        public bool Login(User user)
        {
            using (var conn = new NpgsqlConnection(Context.connstring))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE username=@username AND password=@password";

                using (var conn2 = new NpgsqlCommand(query, conn))
                {
                    conn2.Parameters.AddWithValue("@username", user.Username);
                    conn2.Parameters.AddWithValue("@password", user.Password);

                    using (var reader = conn2.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
        public bool Register(User user)
        {
            using (var conn = new NpgsqlConnection(Context.connstring))
            {
                conn.Open();
                string query = "INSERT INTO users (username,password) VALUES (@username, @password)";

                using (var conn2 = new NpgsqlCommand(query, conn))
                {
                    conn2.Parameters.AddWithValue("@username", user.Username);
                    conn2.Parameters.AddWithValue("@password", user.Password);

                    int var = conn2.ExecuteNonQuery();
                    if (var > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;                        
                    }
                }
            }
        }
        public void Login(Form view)
        {
            view.Hide();
            Login login = new Login();
            login.Show();
        }
        public void Register(Form view)
        {
            view.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
