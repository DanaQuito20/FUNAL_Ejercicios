using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_8___Ejercicios
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            int radio;
            double pi, area;

            Console.Write("Ingrese el radio del círculo: ");
            radio = Convert.ToInt32(Console.ReadLine());

            pi = ValorPi();
            area = CalcularArea(radio, pi);

            Console.WriteLine($"\nEl valor del área del círculo es de: {area}");

            Console.ReadKey();
        }

        static double ValorPi()
        {
            double pi = 3.1416;
            return (pi);
        }

        static double CalcularArea(int radio, double pi)
        {
            double area = (Math.Pow(radio, 2) * pi);
            return area;
        }
    }
}