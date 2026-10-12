using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC___Biblioteca
{
    public class Salud
    {
        //Variables globales -> Funcionan en todos los métodos de la clase
        public static double peso = 0, estatura = 0, imc = 0;

        public static void IngresoDatos()
        {
            //Ingresamos el nombre del paciente
            Console.Write("Ingrese nombre del paciente: ");
            //Variable local -> Solo funciona dentro del método
            string nombre = Console.ReadLine().ToUpper();

            //Ingresamos el peso del paciente
            Console.Write("Ingrese el peso del paciente en Kg.: ");
            peso = Convert.ToDouble(Console.ReadLine());

            //Ingresamos la estatura del paciente
            Console.Write("Ingrese la estatura del paciente en Metros: ");
            estatura = Convert.ToDouble(Console.ReadLine());
        }

        //Método para calcular el IMC
        //Método sin parámetros pero con retorno
        public static double CalculaIMC()
        {
            imc = peso / (Math.Pow(estatura, 2));
            return imc;
        }

        //Método para evaluar el IMC
        //Método que recibe un parámetro y retorna un valor
        public static string CondicionIMC(double indice)
        {
            if (indice > 40) return "Obesidad grado III.";
            else if (indice >= 35) return "Obesidad grado II.";
            else if (indice >= 30) return "Obesidad grado I.";
            else if (indice >= 25) return "Sobrepeso.";
            else if (indice >= 18.5) return "Peso normal.";
            else return "Bajo peso.";
        }
    }
}