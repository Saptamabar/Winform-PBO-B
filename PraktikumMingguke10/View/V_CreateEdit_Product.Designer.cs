namespace PraktikumMingguke10.View
{
    partial class V_CreateEdit_Product
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
            lblproduct = new Label();
            label1 = new Label();
            tbnama = new TextBox();
            label2 = new Label();
            tbdeskripsi = new TextBox();
            label3 = new Label();
            tbharga = new TextBox();
            label4 = new Label();
            tbstok = new TextBox();
            btnsimpan = new Button();
            SuspendLayout();
            // 
            // lblproduct
            // 
            lblproduct.AutoSize = true;
            lblproduct.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblproduct.Location = new Point(279, 32);
            lblproduct.Name = "lblproduct";
            lblproduct.Size = new Size(217, 38);
            lblproduct.TabIndex = 0;
            lblproduct.Text = "Tambah Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 79);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "Nama Produk";
            // 
            // tbnama
            // 
            tbnama.Location = new Point(108, 107);
            tbnama.Name = "tbnama";
            tbnama.Size = new Size(125, 27);
            tbnama.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 152);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Deskripsi";
            // 
            // tbdeskripsi
            // 
            tbdeskripsi.Location = new Point(108, 175);
            tbdeskripsi.Name = "tbdeskripsi";
            tbdeskripsi.Size = new Size(125, 27);
            tbdeskripsi.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(506, 86);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "Harga";
            // 
            // tbharga
            // 
            tbharga.Location = new Point(506, 109);
            tbharga.Name = "tbharga";
            tbharga.Size = new Size(125, 27);
            tbharga.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(506, 152);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 7;
            label4.Text = "Stok";
            // 
            // tbstok
            // 
            tbstok.Location = new Point(506, 175);
            tbstok.Name = "tbstok";
            tbstok.Size = new Size(125, 27);
            tbstok.TabIndex = 8;
            // 
            // btnsimpan
            // 
            btnsimpan.Location = new Point(326, 254);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(116, 42);
            btnsimpan.TabIndex = 9;
            btnsimpan.Text = "Simpan";
            btnsimpan.UseVisualStyleBackColor = true;
            btnsimpan.Click += btnsimpan_Click;
            // 
            // V_CreateEdit_Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsimpan);
            Controls.Add(tbstok);
            Controls.Add(label4);
            Controls.Add(tbharga);
            Controls.Add(label3);
            Controls.Add(tbdeskripsi);
            Controls.Add(label2);
            Controls.Add(tbnama);
            Controls.Add(label1);
            Controls.Add(lblproduct);
            Name = "V_CreateEdit_Product";
            Text = "V_CreateEdit_Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblproduct;
        private Label label1;
        private TextBox tbnama;
        private Label label2;
        private TextBox tbdeskripsi;
        private Label label3;
        private TextBox tbharga;
        private Label label4;
        private TextBox tbstok;
        private Button btnsimpan;
    }
}