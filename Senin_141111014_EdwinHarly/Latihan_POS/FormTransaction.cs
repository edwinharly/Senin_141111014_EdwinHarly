using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    public partial class FormTransaction : Form
    {
        public FormTransaction()
        {
            InitializeComponent();
        }

        private void FormTransaction_Load(object sender, EventArgs e)
        {
            txtBeliID.Text = generateIDBeli();
            txtJualID.Text = generateIDJual();
            lstCustomer = new List<Customer>();
            lstProduct = new List<Product>();
            lstSupplier = new List<Supplier>();
            ///////////////////////////////////////////////////////////////////

        }

        public struct Customer
        {
            public string name;
            public string id;
        }
        public struct Supplier
        {
            public string name;
            public string id;
        }
        public struct Product
        {
            public string id;
            public string name;
            public long price;
            public int qty;
        }
        public List<Customer> lstCustomer;
        public List<Supplier> lstSupplier;
        public List<Product> lstProduct;



        public string generateIDJual()
        {
            string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                Random rnd = new Random();
                string res = rnd.Next(999999).ToString();
                string sql = "SELECT ID from jual WHERE ID = " + res;
                using (MySqlCommand comm = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        string queryRes = "";
                        queryRes = (string)comm.ExecuteScalar();
                        //MessageBox.Show("Hasil query : " + queryRes);
                        if (queryRes == res)
                        {
                            conn.Close();
                            return generateIDJual();
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    conn.Close();
                }
                return res;
            }
        }
        public string generateIDBeli()
        {
            string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                Random rnd = new Random();
                string res = rnd.Next(999999).ToString();
                string sql = "SELECT ID from beli WHERE ID = " + res;
                using (MySqlCommand comm = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        string queryRes = "";
                        queryRes = (string)comm.ExecuteScalar();
                        //MessageBox.Show("Hasil query : " + queryRes);
                        if (queryRes == res)
                        {
                            conn.Close();
                            return generateIDBeli();
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    conn.Close();
                }
                return res;
            }
        }
    }
}
