using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7___Ejercicios
{
    internal class Ejercicio5
    {
        static void Main(string[] args)
        {
            Sueldo();

            Console.ReadKey();
        }

        static void Sueldo()
        {
            string nombreTrabajador;
            int sueldobasico, horasExtra, pagoExtra, sueldoTotal;

            Console.Write("Ingrese su nombre: ");
            nombreTrabajador = Console.ReadLine();

            Console.Write("Ingrese su sueldo: ");
            sueldobasico = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese sus horas extra trabajadas: ");
            horasExtra = int.Parse(Console.ReadLine());

            pagoExtra = horasExtra * 20;
            sueldoTotal = sueldobasico + pagoExtra;

            Console.WriteLine($"\nSu pago por horas extra es de S/.{pagoExtra}, y su sueldo total es de S/.{sueldoTotal}.");
        }
    }
}