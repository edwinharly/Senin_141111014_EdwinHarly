using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime today = DateTime.Today;

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = vScrollBar1.Value.ToString();
            DateTime maxDate = new DateTime(today.Year - Convert.ToInt16(label1.Text),today.Month,today.Day);
            dateTimePicker1.MaxDate = maxDate;
        }

        private void vScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = vScrollBar2.Value.ToString();
            DateTime minDate = new DateTime(today.Year - Convert.ToInt16(label2.Text), today.Month, today.Day);
            dateTimePicker1.MinDate = minDate;
        }
    }
}
