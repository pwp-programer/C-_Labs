namespace Laba_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = 816;
            int s2 = 489;

            try
            {
                s1 = int.Parse(textBox1.Text);
                s2 = int.Parse(textBox2.Text);
            }
            catch (System.FormatException)
            {

                MessageBox.Show("Введите значение");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Подтвердите изменения", "Вы хотите изменить форму?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form2 f = new Form2();
                f.Show();
                f.Location = new Point(this.Location.X, this.Location.Y);
                f.Size = new Size(s1, s2);

                if (radioButton1.Checked == true)
                {
                    f.BackColor = System.Drawing.Color.Red;
                }
                else if (radioButton2.Checked == true)
                {
                    f.BackColor = System.Drawing.Color.Yellow;
                }
                else
                {
                    f.BackColor = System.Drawing.Color.White;
                }
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}