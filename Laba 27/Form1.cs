namespace Laba_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void �������1ToolStripMenuItem_Click(object sender, EventArgs e)
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
                MessageBox.Show("������� �����");
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
                MessageBox.Show("������� �����");
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
                MessageBox.Show("������� �����");
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
                MessageBox.Show("������� �����");
            }
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Yellow;
        }
    }
}