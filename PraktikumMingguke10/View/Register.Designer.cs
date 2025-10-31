namespace PraktikumMingguke10
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbusername = new TextBox();
            tbPassword = new TextBox();
            btnRegister = new Button();
            tbConfirmPassword = new TextBox();
            label4 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 43);
            label1.Name = "label1";
            label1.Size = new Size(167, 54);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 117);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 185);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // tbusername
            // 
            tbusername.Location = new Point(276, 140);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(211, 27);
            tbusername.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(276, 208);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(211, 27);
            tbPassword.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(276, 319);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(211, 29);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(276, 275);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PasswordChar = '*';
            tbConfirmPassword.Size = new Size(211, 27);
            tbConfirmPassword.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 252);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 6;
            label4.Text = "ConfirmPassword";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(509, 319);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(tbConfirmPassword);
            Controls.Add(label4);
            Controls.Add(btnRegister);
            Controls.Add(tbPassword);
            Controls.Add(tbusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbusername;
        private TextBox tbPassword;
        private Button btnRegister;
        private TextBox tbConfirmPassword;
        private Label label4;
        private Button btnLogin;
    }
}