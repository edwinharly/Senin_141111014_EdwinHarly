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
            DateTime tmp1 = new DateTime(2016, 1, 2);
            DateTime tmp2 = new DateTime(2016, 1, 3);
            for (int i=0; i<53; i++)
            {
                monthCalendar1.AddBoldedDate(tmp1);
                monthCalendar1.AddBoldedDate(tmp2);
                tmp1 = tmp1.AddDays(7);
                tmp2 = tmp2.AddDays(7);
            }
            
            // Hari libur nasional 2016
            DateTime[] hariLibur = new DateTime[15];
            hariLibur[0] = new DateTime(2016, 1, 1);
            hariLibur[1] = new DateTime(2016, 2, 8);
            hariLibur[2] = new DateTime(2016, 3, 9);
            hariLibur[3] = new DateTime(2016, 3, 25);
            hariLibur[4] = new DateTime(2016, 5, 1);
            hariLibur[5] = new DateTime(2016, 5, 5);
            hariLibur[6] = new DateTime(2016, 5, 6);
            hariLibur[7] = new DateTime(2016, 5, 22);
            hariLibur[8] = new DateTime(2016, 6, 7);
            hariLibur[9] = new DateTime(2016, 7, 7);
            hariLibur[10] = new DateTime(2016, 8, 17);
            hariLibur[11] = new DateTime(2016, 9, 12);
            hariLibur[12] = new DateTime(2016, 10, 2);
            hariLibur[13] = new DateTime(2016, 12, 12);
            hariLibur[14] = new DateTime(2016, 12, 25);
            foreach(DateTime i in hariLibur)
            {
                monthCalendar1.AddBoldedDate(i);
            }
            monthCalendar1.UpdateBoldedDates();
            
        }

        /// Penambahan bolded date melalui tombol Tambah
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tmp = new DateTime(2016, domainUpDown1.SelectedIndex + 1, (int)numericUpDown1.Value);
                monthCalendar1.AddBoldedDate(tmp);
                monthCalendar1.UpdateBoldedDates();
            }
            catch (Exception)
            {
                MessageBox.Show("Maaf, tanggal yang anda pilih tidak tersedia, silakan coba lagi");
            }
        }

        /// Penghapusan bolded date melalui tombol Hapus
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tmp = new DateTime(2016, domainUpDown1.SelectedIndex + 1, (int)numericUpDown1.Value);
                monthCalendar1.RemoveBoldedDate(tmp);
                monthCalendar1.UpdateBoldedDates();
            }
            catch (Exception)
            {
                MessageBox.Show("Maaf, tanggal yang anda pilih tidak tersedia, silakan coba lagi");
            }
        }
    }
}
