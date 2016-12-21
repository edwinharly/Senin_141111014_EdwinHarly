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
        public void resetAddField()
        {
            txtAddKode.Text = txtAddNama.Text = txtAddJlhAwal.Text = txtAddHrgHPP.Text = txtAddHrgJual.Text = "";
            txtAddID.Text = generateID();
        }

        public class Products
        {
            public string id { get; set; }
            public string code { set; get; }
            public string name { set; get; }
            public int qty { set; get; }
            public long cost { set; get; }
            public long price { set; get; }
        }
        public void refillProductsList()
        {
            productsList = new List<Products>();
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
        }
        //public struct Products
        //{
        //    public string id;
        //    public string code;
        //    public string name;
        //    public int qty;
        //    public long cost;
        //    public long price;
        //}

        public static List<Products> productsList = new List<Products>();

        public void refreshEditPage(int n)
        {
            //productsList.Sort();
            
            txtUpdateID.Text = productsList[n].id;
            txtUpdateKode.Text = productsList[n].code;
            txtUpdateNama.Text = productsList[n].name;
            txtUpdateJlhAwal.Text = productsList[n].qty.ToString();
            txtUpdateHargaHPP.Text = productsList[n].cost.ToString();
            txtUpdateHargaJual.Text = productsList[n].price.ToString();
            
        }
        public void refreshDGVBarang()
        {
            //var bindingList = new BindingList<Products>(productsList);
            var srcDGVBarang = new BindingSource();
            srcDGVBarang.DataSource = productsList;
            DGVBarang.DataSource = srcDGVBarang;
        }
        public int currentViewOnEdit = 0;

        public FormBarang()
        {
            InitializeComponent();
            
        }
        private void FormBarang_Load(object sender, EventArgs e)
        {
            
            txtAddID.Text = generateID();
            refillProductsList();
            refreshEditPage(currentViewOnEdit);
            refreshDGVBarang();
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

        #region Add Barang
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
                            resetAddField();
                            txtAddKode.Focus();

                            Products tmp = new Products();
                            tmp.id = txtAddID.Text;
                            tmp.code = txtAddKode.Text;
                            tmp.name = txtAddNama.Text;
                            tmp.qty = Convert.ToInt16(txtAddJlhAwal.Text);
                            tmp.cost = Convert.ToInt64(txtAddHrgHPP.Text);
                            tmp.price = Convert.ToInt64(txtAddHrgJual.Text);
                            productsList.Add(tmp);
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
            resetAddField();
            txtAddID.Focus();
            
        }
        #endregion
// ==================================================================================
        #region Edit Barang
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
                string sql = "update barang set kode = @kode, nama = @nama, jumlahawal = @jlhawal, hargahpp = @hargahpp, hargajual = @hargajual, updates_on = now() where id = @id;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand comm = new MySqlCommand(sql, conn))
                    {
                        conn.Open();
                        //MessageBox.Show(conn.ConnectionString);
                        comm.Parameters.AddWithValue("@id", txtUpdateID.Text);
                        comm.Parameters.AddWithValue("@kode", txtUpdateKode.Text);
                        comm.Parameters.AddWithValue("@nama", txtUpdateNama.Text);
                        comm.Parameters.AddWithValue("@jlhawal", txtUpdateJlhAwal.Text);
                        comm.Parameters.AddWithValue("@hargahpp", txtUpdateHargaHPP.Text);
                        comm.Parameters.AddWithValue("@hargajual", txtUpdateHargaJual.Text);

                        if (comm.ExecuteNonQuery() == 1)
                        {
                            using (new CenterWinDialog(this))
                            {

                            }
                            editAlertBox.Visible = true;
                            editAlertBox.Text = "The data has been successfully updated";
                            txtUpdateKode.Focus();
                            refillProductsList();
                            refreshEditPage(currentViewOnEdit);
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

        private void firstBtn_Click(object sender, EventArgs e)
        {
            currentViewOnEdit = 0;
            refreshEditPage(currentViewOnEdit);
        }
        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentViewOnEdit <= 0) return;
            currentViewOnEdit -= 1;
            refreshEditPage(currentViewOnEdit);
        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentViewOnEdit >= productsList.Count - 1) return;
            currentViewOnEdit += 1;
            refreshEditPage(currentViewOnEdit);
        }
        private void lastBtn_Click(object sender, EventArgs e)
        {
            currentViewOnEdit = productsList.Count - 1;
            refreshEditPage(currentViewOnEdit);
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            refreshEditPage(currentViewOnEdit);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==  DialogResult.Yes)
            {
                try
                {
                    string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
                    string sql = "delete from barang where id = @id;";

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand comm = new MySqlCommand(sql, conn))
                        {
                            conn.Open();
                            //MessageBox.Show(conn.ConnectionString);

                            comm.Parameters.AddWithValue("@id", txtUpdateID.Text);

                            if (comm.ExecuteNonQuery() == 1)
                            {
                                using (new CenterWinDialog(this))
                                {

                                }
                                editAlertBox.Visible = true;
                                editAlertBox.Text = "The data has been successfully deleted";
                                txtUpdateKode.Focus();
                                refillProductsList();
                                refreshEditPage(currentViewOnEdit);
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
            else
            {
                
            }
        }
        #endregion
    }
}
