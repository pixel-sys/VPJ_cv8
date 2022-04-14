using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VPJ_pxl
{
    public partial class Form1 : Form
    {

        String fontName;
        float fontSize;
        Color fontColor;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void otvoritToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "txt (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.InitialDirectory = @"C:\Users\piXel\Desktop";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {   

                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void ulozitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt (*.txt)|*.txt";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = @"C:\Users\piXel\Desktop";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
            }
        }

        private void zmenitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            //fontDialog.ShowDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                fontName = fontDialog.Font.Name;
                fontSize = fontDialog.Font.Size;
                
                toolStripStatusLabel1.Text = (fontName + ": " + fontSize);

                textBox1.Font = new Font(fontName, fontSize);
            }
        }

        private void pismoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }

        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pozadieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            }
        }
    }
}
