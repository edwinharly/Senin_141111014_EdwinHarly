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

namespace Latihan_POS
{
    public partial class FormPOS : Form
    {
        
        public string generateID()
        {
            string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand comm = conn.CreateCommand();

            Random rnd = new Random();
            string res = rnd.Next(999999).ToString();
            comm.CommandText = "SELECT ID from barang WHERE ID = @nome";
            comm.Parameters.AddWithValue("@nome", res);
            try
            {
                conn.Open();
                string queryRes = "";
                MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    queryRes = reader.GetString(0);
                }
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
            return res;
        }
        public void resetField()
        {
            txtKode.Text = txtNama.Text = txtJlhAwal.Text = txtHrgHPP.Text = txtHrgJual.Text = "";
            txtID.Text = generateID();
        }


        public FormPOS()
        {
            InitializeComponent();
            flatLabel1.TabStop = false;
            flatLabel2.TabStop = false;
            flatLabel3.TabStop = false;
            flatLabel4.TabStop = false;
            flatLabel5.TabStop = false;
            flatLabel6.TabStop = false;
        }

        private void FormPOS_Load(object sender, EventArgs e)
        {
            txtID.Text = generateID();
            txtKode.Focus();
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

                        comm.Parameters.AddWithValue("@id", txtID.Text);
                        comm.Parameters.AddWithValue("@kode", txtKode.Text);
                        comm.Parameters.AddWithValue("@nama", txtNama.Text);
                        comm.Parameters.AddWithValue("@jlhawal", txtJlhAwal.Text);
                        comm.Parameters.AddWithValue("@hargahpp", txtHrgHPP.Text);
                        comm.Parameters.AddWithValue("@hargajual", txtHrgJual.Text);

                        if (comm.ExecuteNonQuery() == 1)
                        {
                            using (new CenterWinDialog(this))
                            {
                                MessageBox.Show("Data berhasil disimpan !");
                            }
                            resetField();
                            txtKode.Focus();
                        }
                        else
                        {
                            using (new CenterWinDialog(this))
                            {
                                MessageBox.Show("Data gagal disimpan !");
                            } 
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
            txtID.Focus();
        }

    }
}
