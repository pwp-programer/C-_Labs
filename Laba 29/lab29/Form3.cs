using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net.Mime;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace lab29
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Microsoft Sans Serif", 8F);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Microsoft Sans Serif", 14F);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Microsoft Sans Serif", 20F);

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Microsoft Sans Serif", this.Font.Size, FontStyle.Regular);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Microsoft Sans Serif", this.Font.Size, FontStyle.Italic);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Microsoft Sans Serif", this.Font.Size, FontStyle.Bold);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.IndianRed;

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Plum;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string file = openFileDialog1.FileName;
            richTextBox1.Text = File.ReadAllText(file);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return; ;
            StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
            for (int i = 0; i < richTextBox1.Text.Length; i++)
            {
                writer.Write(richTextBox1.Text[i].ToString());
            }
            writer.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel) return;
            richTextBox1.Font = fontDialog1.Font;
        }
    }
}