using Npgsql;
using DotNetEnv;
using PraktikumMingguke10.Model;
using PraktikumMingguke10.Controller;

namespace PraktikumMingguke10
{
    public partial class Login : Form
    {        
        private AuthController authController;
        private ProductController productController;
        public Login()
        {
            InitializeComponent();           
            authController = new AuthController();
            productController = new ProductController();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = tbusername.Text;
            user.Password = tbpassword.Text;

            if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
            {
                MessageBox.Show("USERNMAE DAN PASSWORD TIDAK BOLEH KOSONG", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else {
                if (authController.Login(user))
                {
                    MessageBox.Show("SELAMAT ANDA BERHASIL LOGIN", "SUKSES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbusername.Clear();
                    tbpassword.Clear();
                    productController.Product(this);
                }
                else
                {
                    MessageBox.Show("MAAF ANDA GAGAL LOGIN", "LOGIN GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbusername.Clear();
                    tbpassword.Clear();
                }
            }                       
        }

        private void btnregist_Click(object sender, EventArgs e)
        {
            authController.Register(this);
        }
    }
}
