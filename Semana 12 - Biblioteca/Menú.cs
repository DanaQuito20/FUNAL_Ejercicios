using System;
using System.Reflection.Emit;

namespace Semana_12___Biblioteca
{
    public class Menú
    {
        static bool salir = false;

        static string[] opciones =
        {
                "|          1. Registrar estudiante           |",
                "|           2. Listar estudiante             |",
                "|          3. Modificar estudiante           |",
                "|          4. Eliminar estudiante            |",
                "|                 5. Salir                   |"
        };

        //Creamos un método para recuperar la opción elegida
        public static int opcionElegida()
        {
            //Declaramos variables
            int seleccion = 0;
            bool salir = false;

            //Desactivamos el cursor
            Console.CursorVisible = false;

            while (!salir)
            {
                Encabezado();

                //Llamamos un método para mostrar opciones
                ElegirOpcion(seleccion);

                seleccion = RetornaOpcion(seleccion);
            }

            //Retornamos la opción seleccionada
            return seleccion;
        }

        //Método para imprimir el encabezado
        static void Encabezado()
        {
            //Limpiamos la pantalla
            Console.Clear();

            Console.WriteLine("=============================================");
            Console.WriteLine("|     Sistema de registro de estudiantes     |");
            Console.WriteLine("---------------------------------------------");
        }

        //Método para imprimir el encabezado
        static void ElegirOpcion(int seleccion)
        {
            for (int i = 0; i < opciones.Length; i++)
            {
                if (i == seleccion)
                {
                    //Configuramos el color de fondo
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    //Configuramos el color de letra
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($"{opciones[i]} <-");
                    Console.ResetColor();
                }
                else Console.WriteLine(opciones[i]);
            }
            Console.WriteLine("=============================================");
        }

        //Método para evaluar las flechas
        static int RetornaOpcion(int seleccion)
        {
            int retorna = 0;

            //Creamos una variables del tipo tecla
            ConsoleKey tecla = Console.ReadKey(true).Key;

            //Evaluamos si la tecla presionada es flecha arriba
            if (tecla == ConsoleKey.UpArrow)
            {
                if (seleccion == 0) seleccion = opciones.Length - 1;
                else seleccion = seleccion - 1;
            }

            else if (tecla == ConsoleKey.DownArrow)
            {
                if (seleccion == opciones.Length - 1) seleccion = 0;
                else seleccion = seleccion + 1;
            }

            else if (tecla == ConsoleKey.Enter)
            {
                retorna = seleccion;
                salir = true;
            }

            return retorna;
        }
    }
}