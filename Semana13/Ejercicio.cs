using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana13
{
    internal class Ejercicio
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("===== MENÚ DE GESTIÓN DE ESTUDIANTES =====");
                    Console.WriteLine("             1. Registrar");
                    Console.WriteLine("             2. Mostrar");
                    Console.WriteLine("             3. Buscar");
                    Console.WriteLine("             4. Modificar");
                    Console.WriteLine("             5. Eliminar");
                    Console.WriteLine("             6. Ordenar");
                    Console.WriteLine("             7. Salir");
                    Console.WriteLine("==========================================");
                    Console.Write("Seleccione una opción: ");
                    string entrada = Console.ReadLine();

                    if (!int.TryParse(entrada, out opcion) || opcion < 1 || opcion > 7)
                    {
                        Console.Write("\nEntrada inválida. Presione una tecla para intentarlo nuevamente...");
                        Console.ReadKey();
                    }
                } while (opcion < 1 || opcion > 7);

                switch (opcion)
                {
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 5: break;
                    case 6: break;
                    case 7: Console.WriteLine("\n¡Gracias por usar el programa! Saliendo..."); return;
                }

                if (opcion != 7) Console.Write("\nPresione una tecla para regresar al menú..."); Console.ReadKey();
            } while (opcion != 7);
        }
    }
}