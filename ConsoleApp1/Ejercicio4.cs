using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {
            double largo, ancho, area;

            Console.Write("Ingrese el largo del rectángulo: ");
            largo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el ancho del rectángulo: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            area = AreaRectangulo(largo, ancho);

            Console.WriteLine($"\nEl área del rectángulo es de: {area}");

            Console.ReadKey();
        }

        static double AreaRectangulo(double largo, double ancho)
        {
            return (largo * ancho);
        }
    }
}