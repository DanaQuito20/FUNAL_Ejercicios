using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora___Biblioteca
{
    public class Operaciones
    {
        public static double num1 = 0, num2 = 0, resultado = 0;

        public static void Numeros()
        {
            Console.Write("\nIngrese el primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Ingrese el segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());
        }

        public static double Suma()
        {
            resultado = num1 + num2;
            return resultado;
        }

        public static double Resta()
        {
            resultado = num1 - num2;
            return resultado;
        }

        public static double Multiplicacion()
        {
            resultado = num1 * num2;
            return resultado;
        }

        public static double Division()
        {
            if (num1 == 0) Console.WriteLine("Número no válido");
            else resultado = num1 / num2;
            return resultado;
        }
    }
}