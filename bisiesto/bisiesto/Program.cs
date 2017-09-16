using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bisiesto
{
    class Program
    {
        static bool bisiesto(int anio)
        {
            if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 ==0)
            {
                Console.WriteLine("El año es bisiesto");
                return true;
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            Console.WriteLine("Ingrese año");
            opcion = Console.ReadLine();
            bisiesto(Convert.ToInt32(opcion));
            Console.ReadKey();
        }
    }
}
