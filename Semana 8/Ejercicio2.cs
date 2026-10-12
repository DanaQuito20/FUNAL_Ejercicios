using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("Programa de Bienvenida");

            nombre = LeerNombre();

            Console.WriteLine($"\n¡Bienvenido {nombre}, a nuestro programa de Bienvenida!");

            Console.ReadKey();
        }

        public static string LeerNombre()
        {
            string saludo;

            Console.Write("Ingrese su nombre completo: ");
            saludo = Console.ReadLine().ToUpper();

            return saludo;
        }
    }
}