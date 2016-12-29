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
            refillLstProduct();
            refillLstCustomer();
            refillLstSupplier();
            refreshCmbBeliProduct();
            refreshCmbJualProduct();
            refreshCmbCustomer();
            refreshCmbSupplier();
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
            public long cost;
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

        public void refillLstProduct()
        {
            lstProduct.Clear();
            string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = "SELECT ID, Nama, JumlahAwal, HargaHPP, HargaJual from barang";
                using (MySqlCommand comm = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        MySqlDataReader reader = comm.ExecuteReader();

                        while (reader.Read())
                        {
                            //queryRes = reader.GetString(0);
                            Product tmp = new Product();
                            tmp.id = reader.GetString(0);
                            tmp.name = reader.GetString(1);
                            tmp.qty = reader.GetInt16(2);
                            tmp.cost = reader.GetInt64(3);
                            tmp.price = reader.GetInt64(4);

                            lstProduct.Add(tmp);
                        }
                        reader.Close();

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }
        public void refillLstCustomer()
        {
            lstCustomer.Clear();
            string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = "SELECT id, name from customer";
                using (MySqlCommand comm = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        MySqlDataReader reader = comm.ExecuteReader();

                        while (reader.Read())
                        {
                            //queryRes = reader.GetString(0);
                            Customer tmp = new Customer();
                            tmp.id = reader.GetString(0);
                            tmp.name = reader.GetString(1);

                            lstCustomer.Add(tmp);
                        }
                        reader.Close();

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }
        public void refillLstSupplier()
        {
            lstSupplier.Clear();
            string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = "SELECT id, name from supplier";
                using (MySqlCommand comm = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        MySqlDataReader reader = comm.ExecuteReader();

                        while (reader.Read())
                        {
                            //queryRes = reader.GetString(0);
                            Supplier tmp = new Supplier();
                            tmp.id = reader.GetString(0);
                            tmp.name = reader.GetString(1);

                            lstSupplier.Add(tmp);
                        }
                        reader.Close();

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

        public void refreshCmbBeliProduct()
        {
            cmbBeliProdName.Items.Clear();
            for (int i=0; i<lstProduct.Count; i++)
            {
                cmbBeliProdName.Items.Add(lstProduct[i].name);
            }
        }
        public void refreshCmbJualProduct()
        {
            cmbJualProdName.Items.Clear();
            for (int i = 0; i < lstProduct.Count; i++)
            {
                cmbJualProdName.Items.Add(lstProduct[i].name);
            }
        }
        public void refreshCmbCustomer()
        {
            cmbJualCustName.Items.Clear();
            for (int i=0; i<lstCustomer.Count; i++)
            {
                cmbJualCustName.Items.Add(lstCustomer[i].name);

            }
        }
        public void refreshCmbSupplier()
        {
            cmbBeliSuppName.Items.Clear();
            for (int i=0; i<lstSupplier.Count; i++)
            {
                cmbBeliSuppName.Items.Add(lstSupplier[i].name);
            }
        }

        private void cmbBeliProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbBeliProdName.SelectedItem.ToString());
            int index = -1;
            for (int i=0; i<lstProduct.Count; i++)
            {
                if (lstProduct[i].name== cmbBeliProdName.SelectedItem.ToString())
                {
                    index = i;
                }
            }
            if (index>=0)
            {
                txtBeliProdID.Text = lstProduct[index].id;
                txtBeliPrice.Text = lstProduct[index].price.ToString();
                numBeliQty.Text = "0";
            }
        }

        private void cmbJualProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < lstProduct.Count; i++)
            {
                if (lstProduct[i].name == cmbJualProdName.SelectedItem.ToString())
                {
                    index = i;
                }
            }
            if (index >= 0)
            {
                txtJualProdID.Text = lstProduct[index].id;
                txtJualPrice.Text = lstProduct[index].price.ToString();
                numJualQty.Text = "0";
            }
        }

        private void cmbJualCustName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < lstCustomer.Count; i++)
            {
                if (lstCustomer[i].name == cmbJualCustName.SelectedItem.ToString())
                {
                    index = i;
                }
            }
            if (index >= 0)
            {
                txtJualCustID.Text = lstCustomer[index].id;
                
            }
        }

        private void cmbBeliSuppName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < lstSupplier.Count; i++)
            {
                if (lstSupplier[i].name == cmbBeliSuppName.SelectedItem.ToString())
                {
                    index = i;
                }
            }
            if (index >= 0)
            {
                txtBeliSuppID.Text = lstSupplier[index].id;

            }
        }

        private void numBeliQty_ValueChanged(object sender, EventArgs e)
        {
            long res = Convert.ToInt64(txtBeliPrice.Text) * (int)numBeliQty.Value;
            txtBeliTotal.Text = res.ToString();
        }

        private void numJualQty_ValueChanged(object sender, EventArgs e)
        {
            long res = Convert.ToInt64(txtJualPrice.Text) * (int)numJualQty.Value;
            txtJualTotal.Text = res.ToString();
        }

        private void btnBeliReset_Click(object sender, EventArgs e)
        {
            refreshCmbSupplier();
            refreshCmbBeliProduct();
            txtBeliProdID.Text = "Select a Product";
            txtBeliSuppID.Text = "Select a Supplier";
            txtBeliPrice.Text = "0";
            txtBeliTotal.Text = "0";
            numBeliQty.Value = 0;
        }

        private void btnJualReset_Click(object sender, EventArgs e)
        {
            refreshCmbCustomer();
            refreshCmbJualProduct();
            txtJualProdID.Text = "Select a Product";
            txtJualCustID.Text = "Select a Customer";
            txtJualPrice.Text = "0";
            txtJualTotal.Text = "0";
            numJualQty.Value = 0;
        }

        private void btnBeliSubmit_Click(object sender, EventArgs e)
        {
            if (txtBeliProdID.Text == "Select a Product" ||
                txtBeliSuppID.Text == "Select a Supplier" ||
                txtBeliPrice.Text == "0" ||
                txtBeliTotal.Text == "0" ||
                numBeliQty.Value <= 0)
            {
                MessageBox.Show("Please fill out the form completely and correctly");
                return;
            }
            try
            {
                string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
                string sql = "insert into beli values (@id, @suppid, @prodid, @qty);";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand comm = new MySqlCommand(sql, conn))
                    {
                        conn.Open();
                        //MessageBox.Show(conn.ConnectionString);
                        comm.Parameters.AddWithValue("@id", txtBeliID.Text);
                        comm.Parameters.AddWithValue("@suppid", txtBeliSuppID.Text);
                        comm.Parameters.AddWithValue("@prodid", txtBeliProdID.Text);
                        comm.Parameters.AddWithValue("@qty", numBeliQty.Text);

                        if (comm.ExecuteNonQuery() == 1)
                        {
                            using (new CenterWinDialog(this))
                            {

                            }
                            alertBeli.Visible = true;

                            //txtAddName.Focus();

                            
                        }
                        else
                        {
                            using (new CenterWinDialog(this))
                            {

                            }
                            alertBeli.kind = (FlatUI.FlatAlertBox._Kind)1;
                            alertBeli.Text = "Oops! Looks like something went wrong.";
                            alertBeli.Visible = true;
                        }
                        conn.Close();
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                if (ex.Message.IndexOf("Duplicate") >= 1)
                {

                }
            }
        }

        private void btnJualSubmit_Click(object sender, EventArgs e)
        {
            if (txtJualProdID.Text == "Select a Product" ||
                txtJualCustID.Text == "Select a Customer" ||
                txtJualPrice.Text == "0" ||
                txtJualTotal.Text == "0" ||
                numJualQty.Value <= 0)
            {
                MessageBox.Show("Please fill out the form completely");
                return;
            }
            try
            {
                string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
                string sql = "insert into jual values (@id, @custid, @prodid, @qty);";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand comm = new MySqlCommand(sql, conn))
                    {
                        conn.Open();
                        //MessageBox.Show(conn.ConnectionString);
                        comm.Parameters.AddWithValue("@id", txtJualID.Text);
                        comm.Parameters.AddWithValue("@custid", txtJualCustID.Text);
                        comm.Parameters.AddWithValue("@prodid", txtJualTotal.Text);
                        comm.Parameters.AddWithValue("@qty", numJualQty.Text);

                        if (comm.ExecuteNonQuery() == 1)
                        {
                            using (new CenterWinDialog(this))
                            {

                            }
                            alertJual.Visible = true;

                            //txtAddName.Focus();


                        }
                        else
                        {
                            using (new CenterWinDialog(this))
                            {

                            }
                            alertJual.kind = (FlatUI.FlatAlertBox._Kind)1;
                            alertJual.Text = "Oops! Looks like something went wrong.";
                            alertJual.Visible = true;
                        }
                        conn.Close();
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                if (ex.Message.IndexOf("Duplicate") >= 1)
                {

                }
            }
        }
    }
}
