using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverUnidades
{
    static class Program
    {
        InitializateComponent();
    }
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        ///Prueba de Edición
        /// </summary>
        [STAThread]
        static void Main()
        {
            private void button1(object sender, EventArgs e)

                String from, to;

                    From = listBoxDesde.SelectedItem.ToString();
                    to = listBoxHasta.SelectdItem.toString();

                if (from == "Gramo (gr)" && == "Kilogramo (kg)")
                {
                    solucion.Txt = convert.ToString(Convert.ToInt32(cantidad.Text) * 1000);
                }
                if (from == "Kilogramo (kg)" && == "Gramo (gr)")
                {
                    solucion.Txt = convert.ToString(Convert.ToInt32(cantidad.Text) * 0.001);
                }
                if (from == "Onza (onz)" && == "Gramo (gr)")
                {
                    solucion.Txt = convert.ToString(Convert.ToInt32(cantidad.Text) * 28.349);
                }
                if (from == "Gramo (gr)" && == "Onza (onz)")
                {
                    solucion.Txt = convert.ToString(Convert.ToInt32(cantidad.Text) * 0.035274);
                }
                if (from == "Gramo (gr)" && == "Miligramo (mg)")
                {
                    solucion.Txt = convert.ToString(Convert.ToInt32(cantidad.Text) * 1000);
                }
                if (from == "Miligramo (ml)" && == "Gramo (gr)")
                {
                    solucion.Txt = convert.ToString(Convert.ToInt32(cantidad.Text) * 0.001);
                }
                if (from == to)
                {
                MessageBox.Show("Has introducido las mismas unidades");
                }
            //Probando//
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
        }
    }
}
