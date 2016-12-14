using MaterialSkin.Controls;
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
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Latihan_POS
{
    public partial class FormBarang : Form
    {
        
        public string generateID()
        {
            string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                //MySqlCommand comm = conn.CreateCommand();

                Random rnd = new Random();
                string res = rnd.Next(999999).ToString();
                string sql = "SELECT ID from barang WHERE ID = " + res;
                using (MySqlCommand comm = new MySqlCommand(sql, conn))
                {
                    //comm.CommandText = "SELECT ID from barang WHERE ID = @nome";
                    //comm.Parameters.AddWithValue("@nome", res);
                    try
                    {
                        conn.Open();
                        string queryRes = "";
                        queryRes = (string)comm.ExecuteScalar();
                        //MySqlDataReader reader = comm.ExecuteReader();
                        /*
                        while (reader.Read())
                        {
                            queryRes = reader.GetString(0);
                        }
                        reader.Close();
                        */
                        //MessageBox.Show("Hasil query : " + queryRes);
                        if (queryRes == res)
                        {
                            conn.Close();
                            return generateID();
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
        public void resetField()
        {
            txtAddKode.Text = txtAddNama.Text = txtAddJlhAwal.Text = txtAddHrgHPP.Text = txtAddHrgJual.Text = "";
            txtAddID.Text = generateID();
        }
        public struct Products
        {
            public string id;
            public string code;
            public string name;
            public int qty;
            public long cost;
            public long price;
        }
        public static List<Products> productsList = new List<Products>();

        public FormBarang()
        {
            InitializeComponent();
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
                string sql = "insert into barang values (@id, @kode, @nama, @jlhawal, @hargahpp, @hargajual, NOW(), NOW());";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand comm = new MySqlCommand(sql, conn))
                    {
                        conn.Open();
                        //MessageBox.Show(conn.ConnectionString);

                        comm.Parameters.AddWithValue("@id", txtAddID.Text);
                        comm.Parameters.AddWithValue("@kode", txtAddKode.Text);
                        comm.Parameters.AddWithValue("@nama", txtAddNama.Text);
                        comm.Parameters.AddWithValue("@jlhawal", txtAddJlhAwal.Text);
                        comm.Parameters.AddWithValue("@hargahpp", txtAddHrgHPP.Text);
                        comm.Parameters.AddWithValue("@hargajual", txtAddHrgJual.Text);

                        if (comm.ExecuteNonQuery() == 1)
                        {
                            using (new CenterWinDialog(this))
                            {
                                
                            }
                            addAlertBox.Visible = true;
                            resetField();
                            txtAddKode.Focus();
                        }
                        else
                        {
                            using (new CenterWinDialog(this))
                            {
                                
                            }
                            addAlertBox.kind = (FlatUI.FlatAlertBox._Kind)1;
                            addAlertBox.Text = "Oops! Looks like something went wrong.";
                            addAlertBox.Visible = true;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetField();
            txtAddID.Focus();
            
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            txtAddID.Text = generateID();

            

            string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = "SELECT ID, Kode, Nama, JumlahAwal, HargaHPP, HargaJual from barang";
                using (MySqlCommand comm = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        MySqlDataReader reader = comm.ExecuteReader();
                        
                        while (reader.Read())
                        {
                            //queryRes = reader.GetString(0);
                            Products tmp = new Products();
                            tmp.id = reader.GetString(0);
                            tmp.code = reader.GetString(1);
                            tmp.name = reader.GetString(2);
                            tmp.qty = reader.GetInt16(3);
                            tmp.cost = reader.GetInt64(4);
                            tmp.price = reader.GetInt64(5);

                            productsList.Add(tmp);
                        }
                        reader.Close();
                        
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }


                }
            }

                


            //txtAddKode.Focus();
            //flatLabel1.TabStop = false;
            //flatLabel2.TabStop = false;
            //flatLabel3.TabStop = false;
            //flatLabel4.TabStop = false;
            //flatLabel5.TabStop = false;
            //flatLabel6.TabStop = false;
            //productsTabControl.TabPages.Remove(deleteProductsPage);
            //productsTabControl.TabPages.Insert(2, deleteProductsPage);
        }
    }
}
