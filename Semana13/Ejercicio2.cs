using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana13
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese los nombres de los invitados: ");
            string nombres = Console.ReadLine();
            string[] listaInvitados = nombres.Split(',');

            for (int i = 0; i < listaInvitados.Length; i++)
            {
                listaInvitados[i] = listaInvitados[i].Trim();
                Console.WriteLine(listaInvitados[i]);
            }

            Console.Write("Ingrese el invitado a buscar: ");
            string buscarInvitado = Console.ReadLine().ToLower().ToUpper();
            int posicion = -1;

            for (int i = 0; i < listaInvitados.Length; i++) if (buscarInvitado == listaInvitados[i]) posicion = i;

            if (posicion != -1) Console.WriteLine($"El invitado buscado se encuentra en la posición: {posicion}");
            else Console.WriteLine("El invitado buscado no se encuentra en el arreglo.");
        }
    }
}