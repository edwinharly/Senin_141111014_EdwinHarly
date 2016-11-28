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
    public partial class DaftarBarang : Form
    {
        public DaftarBarang()
        {
            InitializeComponent();
        }

        private void DaftarBarang_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn;
            string connectionString = "server=localhost;uid=root;" + "pwd=root;database=pos_schema;";
            

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                //MessageBox.Show(conn.ConnectionString);
                string sql = "insert into barang values ('" +this.textBox1.Text+ "', '" + this.textBox2.Text + "', '" + this.textBox3.Text + "', '" + this.textBox4.Text + "', '" + this.textBox5.Text + "', '" + this.textBox6.Text + "');";

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
