using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_27
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void задание1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Location = new Point(this.Location.X, this.Location.Y);
            this.Close();
            f.Show();
        }

        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = $"Имя: {textBox2.Text}" + Environment.NewLine +
                $"Дата рождения: {dateTimePicker1.Text}\n" +
                $"Пол: {(radioButton1.Checked == true ? 'М' : 'Ж')}\n";

            if (radioButton3.Checked == true)
            {
                s += "Образование: Среднее\n";
            }
            else if (radioButton4.Checked)
            {
                s += "Образование: ПТО\n";
            }
            else if (radioButton5.Checked)
            {
                s += "Образование: ССО\n";
            }
            else
            {
                s += "Образование: ВУЗ\n";
            }

            if (checkBox1.Checked)
            {
                s += checkBox1.Text;
            }
            else if (checkBox2.Checked)
            {
                s += checkBox2.Text;
            }
            else if (checkBox3.Checked)
            {
                s += checkBox3.Text;
            }

            textBox1.Text = s;
        }
    }
}
