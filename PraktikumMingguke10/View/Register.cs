using Npgsql;
using PraktikumMingguke10.Controller;
using PraktikumMingguke10.DbAccess;
using PraktikumMingguke10.Model;
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
        private AuthController authController;
        public Register()
        {
            InitializeComponent();
            authController = new AuthController();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {           
            if (tbPassword.Text == tbConfirmPassword.Text && !string.IsNullOrEmpty(tbusername.Text) && !string.IsNullOrEmpty(tbPassword.Text))
            {
                User user = new User();
                user.Password = tbConfirmPassword.Text;
                user.Username = tbusername.Text;

                if (authController.Register(user))
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
            else
            {
                MessageBox.Show("PASSWORD DAN CONFIMR PASSWORD TIDAK SESUAI", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            authController.Login(this);
        }
    }
}
