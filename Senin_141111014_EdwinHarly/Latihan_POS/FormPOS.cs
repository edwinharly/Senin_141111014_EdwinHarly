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
        public FormPOS()
        {
            InitializeComponent();
        }

        private void btnFrmBrg_Click(object sender, EventArgs e)
        {
            
            FormBarang frmBrg = new FormBarang();
            frmBrg.Show();
        }

        private void btnFrmCust_Click(object sender, EventArgs e)
        {
            FormCustomer frmCust = new FormCustomer();
            frmCust.Show();
        }

        private void btnFrmSupp_Click(object sender, EventArgs e)
        {
            FormSupplier frmSupp = new FormSupplier();
            frmSupp.Show();
        }

        private void btnFrmBeli_Click(object sender, EventArgs e)
        {
            FormTransaction frmTrns = new FormTransaction();
            frmTrns.Show();
        }
    }
}
