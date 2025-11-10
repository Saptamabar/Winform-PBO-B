using PraktikumMingguke10.Controller;
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

namespace PraktikumMingguke10.View.Product
{
    public partial class V_Products : Form
    {
        private ProductController productController;
        private M_Product M_Product = new M_Product();
        public V_Products()
        {
            InitializeComponent();

            dgProduct.AutoGenerateColumns = false;

            productController = new ProductController();
        }

        private void RefreshData()
        {
            List<M_Product> DaftarProduk = productController.Products();

            dgProduct.DataSource = DaftarProduk;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            V_CreateEdit_Product v_CreateEdit_Product = new V_CreateEdit_Product();
            v_CreateEdit_Product.ShowDialog();
            if (v_CreateEdit_Product.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Produk berhasil ditambahkan", "SUKSES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
            }
            else
            {
                MessageBox.Show("Produk gagal ditambahkan", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void dgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string btnitem = dgProduct.Columns[e.ColumnIndex].Name;
            M_Product selectedItem = (M_Product)dgProduct.Rows[e.RowIndex].DataBoundItem;
            M_Product = selectedItem;

            if (btnitem == "Edit")
            {
                V_CreateEdit_Product v_CreateEdit_Product = new V_CreateEdit_Product(M_Product);
                v_CreateEdit_Product.ShowDialog();
                RefreshData();
                //MessageBox.Show("Anda klik edit", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else if (btnitem == "Delete")
            {
                productController.Delete(selectedItem.Id);
                RefreshData();
            }
        }
    }
}
