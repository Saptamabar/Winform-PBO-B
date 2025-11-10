namespace PraktikumMingguke10.View.Product
{
    partial class V_Products
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
            dgProduct = new DataGridView();
            lblProduct = new Label();
            btnTambah = new Button();
            Id = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Stok = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgProduct).BeginInit();
            SuspendLayout();
            // 
            // dgProduct
            // 
            dgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProduct.Columns.AddRange(new DataGridViewColumn[] { Id, Nama, Deskripsi, Harga, Stok, Edit, Delete });
            dgProduct.Location = new Point(108, 94);
            dgProduct.Name = "dgProduct";
            dgProduct.RowHeadersWidth = 51;
            dgProduct.Size = new Size(557, 318);
            dgProduct.TabIndex = 0;
            dgProduct.CellContentClick += dgProduct_CellContentClick;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(98, 33);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(60, 20);
            lblProduct.TabIndex = 1;
            lblProduct.Text = "Product";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(571, 50);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // Nama
            // 
            Nama.DataPropertyName = "Name";
            Nama.HeaderText = "Nama";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            // 
            // Deskripsi
            // 
            Deskripsi.DataPropertyName = "Description";
            Deskripsi.HeaderText = "Deskripsi";
            Deskripsi.MinimumWidth = 6;
            Deskripsi.Name = "Deskripsi";
            // 
            // Harga
            // 
            Harga.DataPropertyName = "Price";
            Harga.HeaderText = "Harga";
            Harga.MinimumWidth = 6;
            Harga.Name = "Harga";
            // 
            // Stok
            // 
            Stok.DataPropertyName = "Stock";
            Stok.HeaderText = "Stok";
            Stok.MinimumWidth = 6;
            Stok.Name = "Stok";
            // 
            // Edit
            // 
            Edit.DataPropertyName = "Id";
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.DataPropertyName = "Id";
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // V_Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTambah);
            Controls.Add(lblProduct);
            Controls.Add(dgProduct);
            Name = "V_Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Index";
            Load += Products_Load;
            ((System.ComponentModel.ISupportInitialize)dgProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProduct;
        private Label lblProduct;
        private Button btnTambah;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Deskripsi;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Stok;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}