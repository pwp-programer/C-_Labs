using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_31
{
    public partial class Form1 : Form
    {
        int x = 300;
        int y = 200;

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawEllipse(int x = 300, int y = 200)
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(Brushes.Black, 2);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawEllipse(myPen, new Rectangle(x, y, 50, 50));
            myPen.Dispose();
            formGraphics.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Right.Start();

            Clear.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Drawing.Graphics g;
            g = this.CreateGraphics();
            g.Clear(Color.White);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DrawEllipse(x, y);
            x += 1;
        }

        private void Left_Tick(object sender, EventArgs e)
        {
            DrawEllipse(x, y);
            x -= 1;
        }

        private void Up_Tick(object sender, EventArgs e)
        {
            DrawEllipse(x, y);
            y -= 1;
        }
        private void Down_Tick(object sender, EventArgs e)
        {
            DrawEllipse(x, y);
            y += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Right.Stop();
            Up.Stop();
            Down.Stop();
            Clear.Stop();

            Left.Start();
            Clear.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Left.Stop();
            Up.Stop();
            Down.Stop();
            Clear.Stop();

            Right.Start();
            Clear.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Left.Stop();
            Right.Stop();
            Down.Stop();
            Clear.Stop();

            Up.Start();
            Clear.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Left.Stop();
            Right.Stop();
            Up.Stop();
            Clear.Stop();

            Down.Start();
            Clear.Start();
        }
    }
}