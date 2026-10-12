using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            int numDado;

            Console.WriteLine("Presione 'Enter' para lanzar el dado.");

            Console.ReadKey();

            numDado = LanzarDado();

            Console.WriteLine($"\nEl número del dado es: {numDado}.");

            if (numDado == 6) Console.WriteLine("¡Obtuviste el puntaje más alto!");

            Console.ReadKey();
        }

        static int LanzarDado()
        {
            int valor;

            Random aleatorio = new Random();
            valor = aleatorio.Next(1, 7);

            return valor;
        }
    }
}