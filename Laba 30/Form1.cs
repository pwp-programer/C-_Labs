using System.Drawing.Drawing2D;

namespace Laba_30
{
    public partial class Form1 : Form
    {
        Color c = Color.Black;

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawEllipse(int x = 300, int y = 200)
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(c, 2);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawEllipse(myPen, new Rectangle(x, y, 150, 100));
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void DrawRectangle(int x = 300, int y = 150)
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(new SolidBrush(c), new Rectangle(x, y, 150, 100));
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void DrawLine(int x = 300, int y = 200)
        {
            Pen pen = new Pen(c, 2);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(pen, x, y, 450, 250);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    DrawRectangle(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                }
                else if (radioButton2.Checked)
                {
                    DrawEllipse(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                }
                else if (radioButton3.Checked)
                {
                    DrawLine(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                }
                else
                {
                    DrawRectangle();
                    DrawEllipse();
                    DrawLine();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("¬ведите координаты");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            c = colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics g;
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
        }
    }
}