using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

            for (int i=1; i<88; i++)
            {
                fontSize.Add(i.ToString());
                
            }
            
            toolStripComboBox2.Items.AddRange(fonts.ToArray());
            toolStripComboBox1.Items.AddRange(fontSize.ToArray());

            /*
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                    toolStripComboBox3.Items.Add(prop.Name);
            }
            */

            Color clr = new Color();
            PropertyInfo[] colors = clr.GetType().GetProperties();
            this.toolStripComboBox3.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            foreach (PropertyInfo color in colors)
            {
                if (color.PropertyType == typeof(System.Drawing.Color))
                {
                    toolStripComboBox3.Items.Add(color.Name);
                }
            }

            // Inisialisasi
            toolStripComboBox1.SelectedIndex = 11;
            toolStripComboBox2.Text = "Calibri";
            toolStripComboBox3.Text = "Black";

            this.toolStripComboBox3.ComboBox.DrawItem += new DrawItemEventHandler(tscbFontColor_DrawItem);
        }
        
        private void tscbFontColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            // a dropdownlist may initially have no item selected, so skip the highlighting:
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);

                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.toolStripComboBox3.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                // Draw a rectangle and fill it with the current color
                // and add the name to the right of the color
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }


        
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(toolStripComboBox2.Items.ToString(), (float)toolStripComboBox1.SelectedIndex + 1);
            richTextBox1.Update();
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                
                
            }
            FontStyle currentStyle = richTextBox1.SelectionFont.Style;

            richTextBox1.SelectionFont = new Font(toolStripComboBox2.SelectedItem.ToString(), (float)toolStripComboBox1.SelectedIndex + 1, FontStyle.Regular | currentStyle);
            richTextBox1.Update();
        }

        // #################### function ini belum siap
        private void changeFont()
        {
            
        }

        private void ToggleBold()
        {
            if (richTextBox1.SelectionFont != null)
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    if (richTextBox1.SelectionFont.Style == FontStyle.Bold)
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular | richTextBox1.Font.Style);
                    else
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | richTextBox1.Font.Style);
                }
                else
                {
                    if (richTextBox1.SelectionFont.Style == FontStyle.Bold)
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular | richTextBox1.Font.Style);
                    else
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold | richTextBox1.Font.Style);
                }
            }
        }

        private void ToggleItalic()
        {
            if (richTextBox1.SelectionFont != null)
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    if (richTextBox1.SelectionFont.Style == FontStyle.Italic)
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular | richTextBox1.Font.Style);
                    else
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic | richTextBox1.Font.Style);
                }
                else
                {
                    if (richTextBox1.SelectionFont.Style == FontStyle.Italic)
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular | richTextBox1.Font.Style);
                    else
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic | richTextBox1.Font.Style);
                }
            }
        }

        private void ToggleUnderline()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                if (richTextBox1.SelectionFont.Style == FontStyle.Underline)
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular | richTextBox1.Font.Style);
                else
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline | richTextBox1.Font.Style);
            }

            else
            {
                if (richTextBox1.SelectionFont.Style == FontStyle.Underline)
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular | richTextBox1.Font.Style);
                else
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline | richTextBox1.Font.Style);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ToggleBold();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ToggleItalic();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ToggleUnderline();
        }

        private void toolStripComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!toolStripComboBox3.Focused) 
            {
                return; 
            } 

            richTextBox1.SelectionColor = Color.FromName(toolStripComboBox3.Text);
        }
    }
}
