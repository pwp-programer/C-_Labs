using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XDocument d = XDocument.Load("C:\\github\\Csharp_Labs\\Laba 29\\lab29\\users.xml");
            XElement users = d.Element("users");
            foreach (var user in users.Elements("user"))
            {
                comboBox1.Items.Add(user.Element("login").Value);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isGetAcces = false;
            XDocument d = XDocument.Load("C:\\github\\Csharp_Labs\\Laba 29\\lab29\\users.xml");
            XElement users = d.Element("users");

            foreach (var user in users.Elements("user"))
                if (user.Element("login").Value == comboBox1.Text && user.Element("password").Value == textBox1.Text)
                {
                    isGetAcces = true;
                }

            if (isGetAcces)
            {
                MessageBox.Show($"Вы вошли как {comboBox1.Text}.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                new Form2().Show();
            }
            else
            {
                MessageBox.Show("Вы ввели неправильный пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = String.Empty;
            }
        }
    }
}