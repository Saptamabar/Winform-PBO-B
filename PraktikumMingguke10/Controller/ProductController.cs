using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using PraktikumMingguke10.DbAccess;
using PraktikumMingguke10.Model;
using PraktikumMingguke10.View.Product;
using PraktikumMingguke10.View.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumMingguke10.Controller
{
    public class ProductController
    {
        private DbContext Context;
        public ProductController()
        {
            Context = new DbContext();
        }
        public void Product(Form view)
        {
            view.Hide();
            V_Products product = new V_Products();
            product.Show();
        }
        public List<M_Product> Products() 
        { 
            List<M_Product> products = new List<M_Product>();
            using (var conn = new NpgsqlConnection(Context.connstring))
            {
                conn.Open();
                string query = "SELECT * FROM product";

                using (var conn2 = new NpgsqlCommand(query, conn))
                {                   
                    using (var reader = conn2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new M_Product
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Description = reader.GetString(2),
                                Price = reader.GetInt32(3),
                                Stock = reader.GetInt32(4),
                            });
                        }
                    }
                }
            }
            return products;
        }
        public bool Create(M_Product product)
        {
            using (var conn = new NpgsqlConnection(Context.connstring))
            {
                conn.Open();
                string query = "INSERT INTO product (name,description,price,stock) VALUES (@name,@description,@price,@stock)";

                using (var conn2 = new NpgsqlCommand(query, conn))
                {
                    conn2.Parameters.AddWithValue("@name", product.Name);
                    conn2.Parameters.AddWithValue("@description", product.Description);
                    conn2.Parameters.AddWithValue("@price", product.Price);
                    conn2.Parameters.AddWithValue("@stock", product.Stock);

                    int var = conn2.ExecuteNonQuery();
                    if (var > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public bool Delete(int id) 
        {
            using (var conn = new NpgsqlConnection(Context.connstring))
            {
                conn.Open();
                string query = "DELETE FROM product WHERE id = @id";

                using (var conn2 = new NpgsqlCommand(query, conn))
                {
                    conn2.Parameters.AddWithValue("@id", id);

                    int var = conn2.ExecuteNonQuery();
                    if (var > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public bool Update(M_Product product)
        {
            using (var conn = new NpgsqlConnection(Context.connstring))
            {
                conn.Open();
                string query = "UPDATE product SET name = @name, description = @description,price = @price,stock = @stock WHERE id = @id";

                using (var conn2 = new NpgsqlCommand(query, conn))
                {
                    conn2.Parameters.AddWithValue("@name", product.Name);
                    conn2.Parameters.AddWithValue("@description", product.Description);
                    conn2.Parameters.AddWithValue("@price", product.Price);
                    conn2.Parameters.AddWithValue("@stock", product.Stock);
                    conn2.Parameters.AddWithValue("@id", product.Id);

                    int var = conn2.ExecuteNonQuery();
                    if (var > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
