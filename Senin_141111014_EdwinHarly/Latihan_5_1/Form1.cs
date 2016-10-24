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

namespace Latihan_5_1
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
            
            richTextBox1.Clear();

            this.toolStripComboBox3.ComboBox.DrawItem += new DrawItemEventHandler(tscbFontColor_DrawItem);
            richTextBox1.SelectionFont = new Font(toolStripComboBox2.Items.ToString(), (float)toolStripComboBox1.SelectedIndex + 1);
            richTextBox1.Update();
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
            richTextBox1.SelectionFont = new Font(toolStripComboBox2.Items.ToString(), (float)toolStripComboBox1.SelectedIndex + 1);
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 11;
            toolStripComboBox2.Text = "Calibri";
            toolStripComboBox3.Text = "Black";
            richTextBox1.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMyFile();
        }

        public void SaveMyFile()
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        public void LoadMyFile()
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMyFile();
        }
    }
}
