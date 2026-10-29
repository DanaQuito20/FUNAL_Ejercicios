using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana11
{
    internal class Ejercicios
    {
        static void Main(string[] args)
        {
            Ejercicio6();
        }

        static void Ejercicio1()
        {
            int[] Num = new int[5];

            for (int i = 0; i < Num.Length; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                Num[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("Números ingresados...");
            foreach (int i in Num) Console.WriteLine($"- {i}");

            Console.ReadKey();
        }

        static void Ejercicio2()
        {
            int[] Num = {-2, 5, -1, 0, 8, -6, 3};

            Console.WriteLine("Números originales");
            foreach (int i in Num) Console.WriteLine($"- {i}");

            Console.WriteLine("\nNúmeros reemplazados");
            for (int i = 0; i < Num.Length; i++)
            {
                if (Num[i] < 0) Num[i] = 0;
                Console.WriteLine($"- {Num[i]}");
            }

            Console.ReadKey();
        }

        static void Ejercicio3()
        {
            int[] Num = {10, 50, 6, 3, 7, 20};

            Console.WriteLine("Números originales");
            foreach (int i in Num) Console.WriteLine($"- {i}");

            int minimo = Num[0], maximo = Num[0];

            for (int i = 1; i < Num.Length; i++)
            {
                if (Num[i] < minimo) minimo = Num[i];
                if (Num[i] > maximo) maximo = Num[i];
            }

            Console.WriteLine($"\nEl mínimo es: {minimo}");
            Console.WriteLine($"El máximo es: {maximo}");

            Console.ReadKey();
        }

        static void Ejercicio4()
        {
            int[] Num = new int[10];

            for (int i = 0; i < Num.Length; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                Num[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("Números ingresados");
            foreach (int i in Num) Console.WriteLine($"- {i}");

            Console.WriteLine("\nLista de pares");
            for (int i = 0; i < Num.Length; i++) if (Num[i] % 2 == 0) Console.WriteLine($"- {Num[i]}");

            Console.ReadKey();
        }

        static void Ejercicio5()
        {
            Console.Write("Ingrese la cantidad de números a registrar: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Clear();

            int[] Num = new int[cantidad];
            int suma = 0;

            for (int i = 0; i < Num.Length; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                Num[i] = int.Parse(Console.ReadLine());
                suma += Num[i];
                Console.Clear();
            }

            Console.WriteLine("Números ingresados");
            foreach (int i in Num) Console.WriteLine($"- {i}");

            Console.WriteLine($"\nLa suma de todos los números es: {suma}");

            Console.ReadKey();
        }

        static void Ejercicio6()
        {
            string[] Productos = new string[5];
            int contador = 0;

            for (int i = 0; contador < Productos.Length; i++)
            {
                Console.Write($"Ingrese el producto {contador + 1}: ");
                string nuevo = Console.ReadLine();
                bool duplicado = false;

                for (int j = 0; j < Productos.Length; j++)
                {
                    if (Productos[j] == nuevo)
                    {
                        Console.WriteLine("¡Producto duplicado!\n");
                        duplicado = true;
                        break;
                    }
                }

                if (!duplicado)
                {
                    Productos[contador] = nuevo;
                    contador++;
                }
            }

            Console.Clear();
            Console.WriteLine("Productos registrados");
            foreach (string i in Productos) Console.WriteLine($"- {i}");

            Console.ReadKey();
        }
    }
}