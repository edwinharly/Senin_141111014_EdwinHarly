using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /// Bold setiap hari Sabtu & Minggu
            DateTime tmp = new DateTime(2016,1,2);
            while(tmp.Year<=2016)
            {
                if (tmp.DayOfWeek == DayOfWeek.Saturday || tmp.DayOfWeek == DayOfWeek.Sunday)
                {
                    monthCalendar1.AddBoldedDate(tmp);
                    tmp.AddDays(1);
                }
                else
                {
                    tmp.AddDays(5);
                }
            }


            
        }

        /// Penambahan bolded date melalui tombol tambah
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tmp = new DateTime(2016, domainUpDown1.SelectedIndex + 1, (int)numericUpDown1.Value);
                monthCalendar1.AddAnnuallyBoldedDate(tmp);
            }
            catch (Exception e)
            {

            }
        }
    }
}
