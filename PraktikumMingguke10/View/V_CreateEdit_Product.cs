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

namespace PraktikumMingguke10.View
{
    public partial class V_CreateEdit_Product : Form
    {
        private ProductController productController;
        private M_Product M_Product = new M_Product();
        private string state = "Tambah";

        public V_CreateEdit_Product()
        {
            productController = new ProductController();
            InitializeComponent();
        }
        public V_CreateEdit_Product(M_Product m_Product)
        {
            state = "Edit";
            InitializeComponent();
            M_Product = m_Product;
            productController = new ProductController();
            tbnama.Text = M_Product.Name;
            tbdeskripsi.Text = M_Product.Description;
            tbharga.Text = M_Product.Price.ToString();
            tbstok.Text = M_Product.Stock.ToString();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {

            M_Product.Name = tbnama.Text;
            M_Product.Description = tbdeskripsi.Text;
            M_Product.Price = int.Parse(tbharga.Text);
            M_Product.Stock = int.Parse(tbstok.Text);

            if(state == "Tambah")
            {
                productController.Create(M_Product);
            }
            else if (state == "Edit") 
            {
                productController.Update(M_Product);
            }
                this.DialogResult = DialogResult.OK;
        }
    }
}
