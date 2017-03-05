﻿using System;
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
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1.1963081929167);
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
            ///VARA CONTRA TODOS
            if (from == "Vara" && to == "Metro")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.835905);
            }
            if (from == "Vara" && to == "Yarda")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.91415682414698);
            }
            if (from == "Vara" && to == "Milla")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.00051940728644715);
            }
            if (from == "Vara" && to == "Kilometro")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.000835905);
            }
            if (from == "Vara" && to == "Pie")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 2.7424704724409);
            }
            if (from == "Vara" && to == "Pulgada")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 32.909645669291);
            }
            ///MILLA CONTRA TODOS
            if (from == "Milla" && to == "Metro")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1609.344);
            }
            if (from == "Milla" && to == "Yarda")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1760);
            }
            if (from == "Milla" && to == "Vara")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1925.2714124213);
            }
            if (from == "Milla" && to == "Kilometro")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1.609344);
            }
            if (from == "Milla" && to == "Pie")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 5280);
            }
            if (from == "Milla" && to == "Pulgada")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 63360);
            }
            ///KILOMETRO CONTRA TODOS
            if (from == "Kilometro" && to == "Metro")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1000);
            }
            if (from == "Kilometro" && to == "Yarda")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1093.6132983377);
            }
            if (from == "Kilometro" && to == "Vara")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1196.3081929167);
            }
            if (from == "Kilometro" && to == "Milla")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.62137119223733);
            }
            if (from == "Kilometro" && to == "Pie")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 3280.8398950131);
            }
            if (from == "Kilometro" && to == "Pulgada")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 39370.078740157);
            }
            ///PIE CONTRA TODOS
            if (from == "Pie" && to == "Metro")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.3048);
            }
            if (from == "Pie" && to == "Yarda")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.33333333333333);
            }
            if (from == "Pie" && to == "Vara")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.364634737201);
            }
            if (from == "Pie" && to == "Milla")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.00018939393939394);
            }
            if (from == "Pie" && to == "Kilometro")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.0003048);
            }
            if (from == "Pie" && to == "Pulgada")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 12);
            }
            ///PULGADA CONTRA TODOS
            if (from == "Pulgada" && to == "Metro")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.0254);
            }
            if (from == "Pulgada" && to == "Yarda")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.027777777777778);
            }
            if (from == "Pulgada" && to == "Vara")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.030386228100083);
            }
            if (from == "Pulgada" && to == "Milla")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.000016);
            }
            if (from == "Pulgada" && to == "Kilometro")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.00002540000);
            }
            if (from == "Pulgada" && to == "Pie")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.083333333333333);
            }
            ///HORAS  CONTRA TODOS
            if (from == "Horas" && to == "Minutos")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 60);
            }
            if (from == "Horas" && to == "Segundos")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 3600);
            }
            if (from == "Horas" && to == "Dia")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.0416667);
            }
            ///MINUTOS CONTRA TODOS
            if (from == "Minutos" && to == "Horas")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.0166667);
            }
            if (from == "Minutos" && to == "Segundos")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 60);
            }
            if (from == "Minutos" && to == "Dia")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.000694444);
            }
            ///SEGUDOS CONTRA TODOS
            if (from == "Segundos" && to == "Horas")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.000277778);
            }
            if (from == "Segundos" && to == "Minutos")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.0166667);
            }
            if (from == "Segundos" && to == "Dia")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.0000115741);
            }
            ///DIAS CONTRA TODOS
            if (from == "Dia" && to == "Horas")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 24);
            }
            if (from == "Dia" && to == "Minutos")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 1440);
            }
            if (from == "Dia" && to == "Segundos")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 86400);
            }
            if (from == to)
            {
                MessageBox.Show("Has introducido las mismas unidades");
            }
        }
    }
}
