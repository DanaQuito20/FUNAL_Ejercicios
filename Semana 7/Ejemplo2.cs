using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7
{
    internal class Ejemplo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================================");
            Console.WriteLine("       PROGRAMA PARA CALCULAR EL ÁREA DEL CUADRADO       ");
            Console.WriteLine("=========================================================");

            AreaCuadrado();

            Console.ReadKey();
        }

        static void AreaCuadrado()
        {
            double lado, area;

            Console.Write("Ingrese la distancia del lado del cuadrado: ");
            lado = double.Parse(Console.ReadLine());

            area = lado * lado;

            Console.WriteLine($"\nEl área del cuadrado es de {area}.");
        }
    }
}