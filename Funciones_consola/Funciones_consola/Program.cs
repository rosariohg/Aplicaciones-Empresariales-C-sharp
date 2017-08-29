using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static void Raiz()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es {1}", i, Math.Sqrt(i));
            }
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }

        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        static double Division(int a, int b)
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
                    Console.WriteLine("{0} es número primo ", i);
                }
                cont = 0;
            }
        }

        static double Celsius(int f)
        {
            return (5 * (f - 32) / 9);
        }

        static double Farenhei(int c)
        {
            return ((9 * c) / 5) + 32;
        }

        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicación de dos números");
                Console.WriteLine("[5] División de dos números");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos");
                Console.WriteLine("[7] Convertir a Grados Celsius");
                Console.WriteLine("[8] Convertir a Grados Farenheit");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                int a = 0;
                int b = 0;
                if (Convert.ToInt32(opcion) != 2 && Convert.ToInt32(opcion) != 6 && Convert.ToInt32(opcion) != 7 && Convert.ToInt32(opcion) != 8)
                {
                    Console.WriteLine("Ingrese el primer número");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número");
                    b = Convert.ToInt32(Console.ReadLine());
                }

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("La resta de {0} y {1} es {2}", a, b, Resta(a, b));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", a, b, Multiplicacion(a, b));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("La división de {0} y {1} es {2}", a, b, Division(a, b));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese número en grados farenheit");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El número {0} en grados Celsius es {1}", a, Celsius(a));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese número en grados celsius");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El número {0} en grados Farenheit es {1}", a, Farenhei(a));
                        Console.ReadKey();
                        break;

                }
            } while (!opcion.Equals("0"));

        }
    }
}
