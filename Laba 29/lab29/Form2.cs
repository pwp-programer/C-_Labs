using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace lab29
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) 
                return;
            FileStream fn = (FileStream)openFileDialog1.OpenFile();
            pictureBox1.Image = Image.FromStream(fn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Вы не открыли ничего чтобы, сохранить.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                FileStream fn = (FileStream)saveFileDialog1.OpenFile();
                if (saveFileDialog1.FilterIndex == 1)
                    pictureBox1.Image.Save(fn, ImageFormat.Bmp);
                else if (saveFileDialog1.FilterIndex == 2)
                    pictureBox1.Image.Save(fn, ImageFormat.Jpeg);
                else if (saveFileDialog1.FilterIndex == 3)
                    pictureBox1.Image.Save(fn, ImageFormat.Gif);
            }
                 
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Application.OpenForms[0].Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new Form3().Show();
        }
    }
}