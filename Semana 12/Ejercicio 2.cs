using System;

namespace Semana_12
{
    internal class Ejercicio_2
    {
        //Método para mostrar arreglo
        public static void MuestraArreglo(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"{arreglo[i]} | ");
            }
        }

        static void Main(string[] args)
        {
            int independiente;

            //Creamos un arreglo con 5 valores
            int[] Valor = {15, 10, 7, 11, 5};
            MuestraArreglo (Valor);

            for (int i = 0; i < Valor.Length - 1; i++)
            {
                for (int j = 0; j < Valor.Length - 1 - i; j++)
                {
                    if (Valor[j] > Valor[j + 1])
                    {
                        independiente = Valor[j + 1];
                        Valor[j + 1] = Valor[j];
                        Valor[j] = independiente;
                    }
                    MuestraArreglo(Valor);
                    Console.ReadKey();
                }
            }
        }
    }
}