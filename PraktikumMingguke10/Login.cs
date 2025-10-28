using Npgsql;
using DotNetEnv;

namespace PraktikumMingguke10
{
    public partial class Login : Form
    {
        private string connstring;
        public Login()
        {
            InitializeComponent();

            Env.Load();

            string db_host = Environment.GetEnvironmentVariable("DB_HOST");
            string db_user = Environment.GetEnvironmentVariable("DB_USER");
            string db_pass = Environment.GetEnvironmentVariable("DB_PASS");
            string db_name = Environment.GetEnvironmentVariable("DB_NAME");

            connstring = $"Host={db_host};Username={db_user};Password={db_pass};Database={db_name};";
            //MessageBox.Show(connstring);

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = tbusername.Text;
            string password = tbpassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("USERNMAE DAN PASSWORD TIDAK BOLEH KOSONG", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new NpgsqlConnection(connstring))
            {
                conn.Open();
                string query = "SELECT * FROM akun WHERE username=@username AND password=@password";

                using (var conn2 = new NpgsqlCommand(query, conn))
                {
                    conn2.Parameters.AddWithValue("@username", username);
                    conn2.Parameters.AddWithValue("@password", password);

                    using (var reader = conn2.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("SELAMAT ANDA BERHASIL LOGIN", "SUKSES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbusername.Clear();
                            tbpassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show("MAAF ANDA GAGAL LOGIN", "LOGIN GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbusername.Clear();
                            tbpassword.Clear();
                        }
                    }
                }

            }



        }

        private void btnregist_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }
    }
}
