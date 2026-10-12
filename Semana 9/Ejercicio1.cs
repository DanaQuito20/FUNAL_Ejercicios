using System;
using IMC___Biblioteca;

namespace Semana_9
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("|                     Ejercicio 1                     |");
            Console.WriteLine("|     Calculando el Índice de Masa Corporal (IMC)     |");
            Console.WriteLine("------------------------------------------------------");

            //Llamo a mi biblioteca "IMC - Biblioteca"
            //1. En el Explorador de soluciones, dar click derecho en Referencias
            //2. Seleccionamos la opción "Agregar referencia..."
            //3. Buscamos el botón "Examinar..." y damos click
            //4. Se abre el Explorador de Windows y buscamos el archivo que contiene la biblioteca (.dll)
            //5. Aceptamos dando clic en "Agregar"
            //6. Lo llamamos desde nuestras bibliotecas

            Salud.IngresoDatos();

            //Llamamos al método para calcular el IMC
            double valorIMC = Salud.CalculaIMC();

            Console.WriteLine($"\nEl Índice de Masa Corporal (IMC) es: {(Math.Round(valorIMC, 2))}\nUsted tiene: {Salud.CondicionIMC(valorIMC)}");
            
            Console.ReadKey();
        }
    }
}