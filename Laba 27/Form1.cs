namespace Laba_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void задание1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Num1 = int.Parse(textBox1.Text);
                int Num2 = int.Parse(textBox2.Text);

                label4.Text = (Num1 + Num2).ToString();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите числа");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Num1 = int.Parse(textBox1.Text);
                int Num2 = int.Parse(textBox2.Text);

                label4.Text = (Num1 - Num2).ToString();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите числа");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int Num1 = int.Parse(textBox1.Text);
                int Num2 = int.Parse(textBox2.Text);

                label4.Text = (Num1 * Num2).ToString();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите числа");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int Num1 = int.Parse(textBox1.Text);
                int Num2 = int.Parse(textBox2.Text);

                label4.Text = (Num1 / Num2).ToString();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите числа");
            }
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
        }

        private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
        }

        private void жёлтыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Yellow;
        }
    }
}