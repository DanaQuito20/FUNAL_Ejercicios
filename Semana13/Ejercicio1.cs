using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana13
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            string nombres = "Mayu, Jossimar, Miguel, Aira, Fran";
            string[] listaNombres = nombres.Split(',');

            Console.Write("Ingrese el nombre a buscar: ");
            string buscarNombre = Console.ReadLine();

            int posicion = -1;

            for (int i = 0; i < listaNombres.Length; i++)
            {
                listaNombres[i] = listaNombres[i].Trim();
                if (buscarNombre == listaNombres[i]) posicion = i;
            }

            if (posicion != -1) Console.WriteLine($"El nombre buscado se encuentra en la posición: {posicion}");
            else Console.WriteLine("El nombre buscado no se encuentra en el arreglo.");
        }
    }
}