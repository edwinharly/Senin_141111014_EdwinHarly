using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> fonts = new List<string>();
            List<string> fontSize = new List<string>();

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
            }

            for (int i=1; i<1638; i++)
            {
                fontSize.Add(i.ToString());
            }

            toolStripComboBox2.Items.AddRange(fonts.ToArray());
            toolStripComboBox1.Items.AddRange(fontSize.ToArray());
        }
    }
}
