using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverUnidades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String from, to;

            from = listBox1Desde.SelectedItem.ToString();
            to = listBox1Hasta.SelectedItem.ToString();

            if (from == "Gramo (gr)" && == "Kilogramo (kg)")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1000);
            }
            if (from == "Kilogramo (kg)" && == "Gramo (gr)")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.001);
            }
            if (from == to)
            {
                MessageBox.Show("Has introducido las mismas unidades");
            }
        }
    }
}
