using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador, numero, contPosi = 0, sumaPosi = 0;

            for (contador = 0; contador < 10; contador++)
            {
                Console.Write($"Ingrese el número {contador + 1}: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    contPosi++;
                    sumaPosi += numero;
                }
            }

            Console.WriteLine($"Los números positivos son {contPosi} y su suma es {sumaPosi}");
        }
    }
}