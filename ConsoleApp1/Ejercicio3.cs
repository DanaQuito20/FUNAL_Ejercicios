using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            int nume;
            double doble;

            Console.Write("Ingrese un número entero: ");
            nume = Convert.ToInt32(Console.ReadLine());

            doble = ConvierteDoble(nume);

            Console.WriteLine($"\nEl valor doble del número ingresado es: {doble}.");

            Console.ReadKey();
        }

        static double ConvierteDoble(int nume)
        {
            double valor;

            valor = nume * 2;

            return valor;
        }
    }
}