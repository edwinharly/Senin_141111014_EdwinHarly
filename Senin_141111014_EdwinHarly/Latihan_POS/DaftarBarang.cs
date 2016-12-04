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
using MaterialSkin.Controls;

namespace Latihan_POS
{
    public partial class DaftarBarang : Form
    {
        static MySqlConnection conn = new MySqlConnection(connectionString);
        static string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
        static MySqlCommand comm = conn.CreateCommand();

        public string generateID()
        {
            
            Random rnd = new Random();
            string res = rnd.Next(999999999).ToString();
            comm.CommandText = "SELECT ID from barang WHERE ID = @nome";
            comm.Parameters.AddWithValue("@nome", res);
            try
            {
                conn.Open();
                string queryRes = "";
                MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    queryRes += reader.ToString();
                }
                MessageBox.Show(queryRes);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            conn.Close();
            return res;
        }

        public DaftarBarang()
        {
            InitializeComponent();
        }

        private void DaftarBarang_Load(object sender, EventArgs e)
        {
            generateID();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtKode.Text = txtNama.Text = txtJlhAwal.Text = txtHargaHPP.Text = txtHargaJual.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                conn.Open();
                //MessageBox.Show(conn.ConnectionString);
                string sql = "insert into barang values ('" +this.txtID.Text+ "', '" + this.txtKode.Text + "', '" + this.txtNama.Text + "', '" + this.txtJlhAwal.Text + "', '" + this.txtHargaHPP.Text + "', '" + this.txtHargaJual.Text + "', NOW(), NOW());";
                MySqlCommand comm = new MySqlCommand(sql, conn);

                if (comm.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data berhasil disimpan !");
                }
                else
                {
                    MessageBox.Show("Data gagal disimpan !");
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                if (ex.Message.IndexOf("Duplicate") >= 1)
                {

                }
            }
            
        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
