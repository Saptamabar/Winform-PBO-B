using Npgsql;
using PraktikumMingguke10.DbAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PraktikumMingguke10
{
    public partial class Register : Form
    {
        public string username;
        public string password;
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            username = tbusername.Text;
            password = tbPassword.Text;
            if (tbPassword.Text == tbConfirmPassword.Text)
            {

                using (var conn = new NpgsqlConnection(DbContext.connstring))
                {
                    conn.Open();
                    string query = "INSERT INTO akun (username,password) VALUES (@username, @password)";

                    using (var conn2 = new NpgsqlCommand(query, conn))
                    {
                        conn2.Parameters.AddWithValue("@username", username);
                        conn2.Parameters.AddWithValue("@password", password);

                        int var = conn2.ExecuteNonQuery();
                        if (var > 0)
                        {

                            MessageBox.Show("SELAMAT ANDA BERHASIL REGISTER", "SUKSES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbusername.Clear();
                            tbPassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show("MAAF ANDA GAGAL REGISTER", "LOGIN GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbusername.Clear();
                            tbPassword.Clear();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("PASSWORD DAN CONFIMR PASSWORD TIDAK SESUAI", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
