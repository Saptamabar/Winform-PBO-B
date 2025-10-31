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
        public V_Products()
        {
            InitializeComponent();
            productController = new ProductController();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            List<M_Product> DaftarProduk = productController.Products();
            dgProduct.DataSource = DaftarProduk;
        }
    }
}
