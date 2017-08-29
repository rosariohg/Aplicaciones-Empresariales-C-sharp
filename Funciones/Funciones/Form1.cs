using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funciones
{
    public partial class Form1 : Form
    {
        string func;
        double res;
        public Form1()
        {
            InitializeComponent();
        }
        
        static double Suma(double a, double b)
        {
            return a + b;
        }
        static double Resta(double a, double b)
        {
            return a - b;
        }
        static double Multiplicacion(double a, double b)
        {
            return a * b;
        }
        static double Division(double a, double b)
        {
            if (b == 0)
            {
                return -1;
            }
            else
            {
                return a / b;
            }
        }

        static void Primos()
        {
            int cont = 0;
            for (int i = 2; i <= 30; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cont = cont + 1;
                    }
                }

                if (cont <= 2)
                {
                    //Console.WriteLine("{0} es número primo ", i);
                    MessageBox.Show(i + "\n");
                }
                cont = 0;
            }
        }
        static double Celsius(double f)
        {
            return (5 * (f - 32) / 9);
        }
        static double Farenheit(double c)
        {
            return ((9 * c) / 5) + 32;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double val1 = 0; 
            double val2 = 0;
            func = cmbFunciones.Text;
            
            switch (func)
            {
                case "Suma":
                    val1 = Convert.ToInt32(txtVal1.Text);
                    val2 = Convert.ToInt32(txtVal2.Text);
                    res = Suma(val1, val2);
                    txtRes.Text = Convert.ToString(res);
                    break;
                case "Resta":
                    val1 = Convert.ToInt32(txtVal1.Text);
                    val2 = Convert.ToInt32(txtVal2.Text);
                    res = Resta(val1, val2);
                    txtRes.Text = Convert.ToString(res);
                    break;
                case "Multiplicación":
                    val1 = Convert.ToInt32(txtVal1.Text);
                    val2 = Convert.ToInt32(txtVal2.Text);
                    res = Multiplicacion(val1, val2);
                    txtRes.Text = Convert.ToString(res);
                    break;
                case "División":
                    val1 = Convert.ToInt32(txtVal1.Text);
                    val2 = Convert.ToInt32(txtVal2.Text);
                    res = Division(val1, val2);
                    txtRes.Text = Convert.ToString(res);
                    break;
                case "Convertir a Celsius":
                    val1 = Convert.ToInt32(txtVal1.Text);
                    res = Celsius(val1);
                    txtRes.Text = Convert.ToString(res);
                    break;
                case "Convertir a Farenheit":
                    val1 = Convert.ToInt32(txtVal1.Text);
                    res = Farenheit(val1);
                    txtRes.Text = Convert.ToString(res);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            
        }

        public void limpiar() {
            txtVal1.Clear();
            txtVal2.Clear();
            txtRes.Clear();
        }
        private void cmbFunciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string funcion = cmbFunciones.SelectedItem.ToString();
            switch (funcion)
            {
                case "Suma":
                    limpiar();
                    txtVal1.Enabled = true;
                    txtVal2.Enabled = true;
                    break;
                case "Resta":
                    limpiar();
                    txtVal1.Enabled = true;
                    txtVal2.Enabled = true;
                    break;
                case "Multiplicación":
                    limpiar();
                    txtVal1.Enabled = true;
                    txtVal2.Enabled = true;
                    break;
                case "División":
                    limpiar();
                    txtVal1.Enabled = true;
                    txtVal2.Enabled = true;
                    break;
                case "Convertir a Celsius":
                    limpiar();
                    txtVal1.Enabled = true;
                    txtVal2.Enabled = false;
                    break;
                case "Convertir a Farenheit":
                    limpiar();
                    txtVal1.Enabled = true;
                    txtVal2.Enabled = false;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

        }
    }
}
