namespace PraktikumMingguke10
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbusername = new TextBox();
            tbpassword = new TextBox();
            label3 = new Label();
            btnlogin = new Button();
            btnregist = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(277, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 35);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 102);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // tbusername
            // 
            tbusername.Location = new Point(201, 126);
            tbusername.Margin = new Padding(2, 2, 2, 2);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(241, 27);
            tbusername.TabIndex = 3;
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(201, 189);
            tbpassword.Margin = new Padding(2, 2, 2, 2);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(241, 27);
            tbpassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 161);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "password";
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(201, 234);
            btnlogin.Margin = new Padding(2, 2, 2, 2);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(240, 27);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnregist
            // 
            btnregist.Location = new Point(467, 234);
            btnregist.Name = "btnregist";
            btnregist.Size = new Size(94, 29);
            btnregist.TabIndex = 7;
            btnregist.Text = "register";
            btnregist.UseVisualStyleBackColor = true;
            btnregist.Click += btnregist_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnregist);
            Controls.Add(btnlogin);
            Controls.Add(label3);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbusername;
        private TextBox tbpassword;
        private Label label3;
        private Button btnlogin;
        private Button btnregist;
    }
}
