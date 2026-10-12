using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora___Biblioteca;

namespace Semana_9._2
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("|                     Ejercicio 2                     |");
            Console.WriteLine("|                     Calculadora                     |");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("|                         Menú                        |");
            Console.WriteLine("|                       1. Suma                       |");
            Console.WriteLine("|                       2. Resta                      |");
            Console.WriteLine("|                  3. Multiplicación                  |");
            Console.WriteLine("|                     4. División                     |");
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Ingrese una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            string conti;
            Operaciones.Numeros();

            switch (opcion)
            {
                case 1:
                    double suma = Operaciones.Suma();
                    Console.WriteLine($"\nLa suma es: {suma}");
                    break;

                case 2:
                    double resta = Operaciones.Resta();
                    Console.WriteLine($"\nLa resta es: {resta}");
                    break;

                case 3:
                    double multiplicacion = Operaciones.Multiplicacion();
                    Console.WriteLine($"\nLa multiplicación es: {multiplicacion}");
                    break;

                case 4:
                    double division = Operaciones.Division();
                    Console.WriteLine($"\nLa división es: {division}");
                    break;

                default:
                    Console.WriteLine("Ingrese un número correctamente.");
                    break;
            }

            /*do
            {
                switch (opcion)
                {
                    case 1:
                        double suma = Operaciones.Suma();
                        Console.WriteLine($"\nLa suma es: {suma}");
                        continue;

                    case 2:
                        double resta = Operaciones.Resta();
                        break;

                    case 3:
                        double multiplicacion = Operaciones.Multiplicacion();
                        break;

                    case 4:
                        double division = Operaciones.Division();
                        break;

                    default:
                        Console.WriteLine("Ingrese un número correctamente.");
                        break;
                }

                Console.Write("¿Desea continuar? (s / n): ");
                conti = Console.ReadLine();
            } while (conti == "s");*/
            Console.ReadKey();
        }
    }
}