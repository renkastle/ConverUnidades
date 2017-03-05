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
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.0352739200000000003);
            }

            ///MILIGRAMO CONTRA TODOS
            if (from == "Miligramo" && to == "Tonelada")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.000000001);
            }
            if (from == "Miligramo" && to == "Kilogramo")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.000001);
            }
            if (from == "Miligramo" && to == "Gramo")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.001);
            }
            if (from == "Miligramo" && to == "Libra")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.000002204623);
            }
            if (from == "Miligramo" && to == "Onza")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.00003527396);
            }

            ///LIBRAS CONTRA TODOS
            if (from == "Libra" && to == "Tonelada")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.000453592);
            }
            if (from == "Libra" && to == "Kilogramo")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.453592);
            }
            if (from == "Libra" && to == "Gramo")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 453.592);
            }
            if (from == "Libra" && to == "Miligramo")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 453592);
            }
            if (from == "Libra" && to == "Onza")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 16);
            }

            ///ONZA CONTRA TODOS
            if (from == "Onza" && to == "Tonelada")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.00002834952);
            }
            if (from == "Onza" && to == "Kilogramo")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.0283495);
            }
            if (from == "Onza" && to == "Gramo")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 28.3495);
            }
            if (from == "Onza" && to == "Miligramo")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 28349.5);
            }
            if (from == "Onza" && to == "Libra")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.0625);
            }

            ///METRO CONTRA TODOS
            if (from == "Metro" && to == "Yarda")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1.09361);
            }
            if (from == "Metro" && to == "Vara")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.835);
            }
            if (from == "Metro" && to == "Milla")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.000621371);
            }
            if (from == "Metro" && to == "Kilometro")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1000);
            }
            if (from == "Metro" && to == "Pie")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 3.28084);
            }
            if (from == "Metro" && to == "Pulgada")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 39.3701);
            }
            ///YARDA CONTRA TODOS
            if (from == "Yarda" && to == "Metro")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.9144);
            }
            if (from == "Yarda" && to == "Vara")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1.093904211603);
            }
            if (from == "Yarda" && to == "Milla")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.000568182);
            }
            if (from == "Yarda" && to == "Kilometro")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.0009144);
            }
            if (from == "Yarda" && to == "Pie")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 3);
            }
            if (from == "Yarda" && to == "Pulgada")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 36);
            }
            ///

            if (from == to)
            {
                MessageBox.Show("Has introducido las mismas unidades");
            }
        }
    }
}
