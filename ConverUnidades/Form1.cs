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
            ///TONELADAS CONTRA TODOS ///
            if (from == "Tonelada" && to == "Kilogramo")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1000);
            }
            if (from == "Tonelada" && to == "Gramo")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1000000);
            }
            if (from == "Tonelada" && to == "Miligramo")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1000000000);
            }
            if (from == "Tonelada" && to == "Libra")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 2204.62);
            }
            if (from == "Tonelada" && to == "Onza")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 35274);
            }
            ///KILOGRAMO CONTRA TODOS///
            if (from == "Kilogramo" && to == "Tonelada")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.001);
            }
            if (from == "Kilogramo" && to == "Gramo")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1000);
            }
            if (from == "Kilogramo" && to == "Miligramo")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1000000);
            }
            if (from == "Kilogramo" && to == "Libra")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 2.20462);
            }
            if (from == "Kilogramo" && to == "Onza")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 35.274);
            }

            ///GRAMO CONTRA TODOS
            if (from == "Gramo" && to == "Tonelada")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.000001);
            }
            if (from == "Gramo" && to == "Kilogramo")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.001);
            }
            if (from == "Gramo" && to == "Miligramo")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1000);
            }
            if (from == "Gramo" && to == "Libra")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.00220462);
            }
            if (from == "Gramo" && to == "Onza")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0, 0352739200000000003);
            }

            ///
            if (from == to)
            {
                MessageBox.Show("Has introducido las mismas unidades");
            }
        }
    }
}
