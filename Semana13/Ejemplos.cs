using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana13
{
    internal class Ejemplos
    {
        static void Main(string[] args)
        {
            //Cadenas de caracteres -> Char / String
            //Char: Representa un único símbolo. Solo acepta una letra, número, símbolo o espacio en blanco. Se delimita con 'A', 'a', '7' o '@'. Es un número pequeño que contiene el standar ascii. Ocupa en memoria 1 o 2 bytes.
            //String: Secuencia ordenada de uno o más caracteres. Podemos guardar frases, palabras, nombres o párrafos. Se delimita cin comillas (""). Ejemplos -> "Hola mundo...", "Bienvenidos a la clase...", "" (Cadena vacía). Es un vector y cada letra ocupa una posición específica dentro del vector.

            Console.WriteLine("- Ejemplos de variables Char");
            //Declaramos una variable Char
            char letra = 'A', letra2;
            Console.WriteLine($"La letra que contiene la variable 'letra' es {letra}");

            //ingresar por teclado una variable del tipo Char
            Console.Write("Ingrese una letra del abecedario: ");
            letra2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"La letra en la variable 'letra2' es: {letra2}\n");

            Console.WriteLine("- Ejemplo de variable String");
            string opcion = "";
            opcion = "Hola mundo...";
            Console.WriteLine($"El valor de la variable 'opcion' es: {opcion}\n");

            //Funciones de manipulación de caracteres
            //a) Propiedad .Length: Cuenta el total de caracteres que tiene un string incluyendo los espacios en blanco. No es una función ni método (no lleva paréntesis al final), es una propiedad.
            Console.WriteLine("- Ejemplo de la propiedad .Length");
            string curso = "Fundamentos de Algoritmos"; Console.WriteLine($"La variable 'curso' contiene la frase: {curso}\nLa cantidad de caracteres de 'curso' es: {curso.Length}\n");

            //b) Función .ToUpper(): Convierte todos los caracteres de un string a mayúsculas.

            //c) Función .ToLower(): Convierte todos los caracteres de un string a minúsculas.

            //d) Función .Trim(): Elimina los espacios en blanco al inicio y al final de un string.
            Console.WriteLine("- Ejemplo de la función .Trim()");
            string saludo = "   Hola, buenos días   "; Console.WriteLine($"El valor de la variable 'saludo' es: {saludo}");
            string limpio = saludo.Trim(); Console.WriteLine($"El valor de la variable 'saludo' es: {limpio}\n");

            //e) Función .Substring(): Permite extraer parte de los caracteres de un string. Recibe como parámetros la posición inicial y la cantidad de caracteres a extraer.
            Console.WriteLine("- Ejemplo de la función .Substring()");
            string codigo = "PER-2026-LIM", año = codigo.Substring(4, 4);
            Console.WriteLine($"El valor de la variable 'código' es: {codigo}\nLo recuperado es: {año}\n");

            //f) Función .IndexOf(): Permite buscar la posición de un carácter o palabra dentro de un string. Recibe como parámetro el carácter o palabra a buscar y devuelve la posición en la que se encuentra. Si no lo encuentra devuelve -1.
            Console.WriteLine("- Ejemplo de la función .IndexOf()");
            string frase = "Fundamentos de Algoritmos"; //Deseamos buscar dentro del texto la palabra "de"
            int posicion = frase.IndexOf("python"); Console.WriteLine($"La palabra buscada se encuentra en la posición: {posicion}\n");

            //g) Función .Contains(): Permite buscar si un carácter o palabra se encuentra dentro de un string. Recibe como parámetro el carácter o palabra a buscar y devuelve true si lo encuentra y false si no lo encuentra.
            Console.WriteLine("- Ejemplo de la función .Contains()");
            Console.Write("Ingrese su correo electrónico: "); string email = Console.ReadLine();
            if (email.Contains("@")) Console.WriteLine("El correo ingresado sí existe."); else Console.WriteLine("El correo ingresado no existe.");

            //h) Función .Replace(): Permite reemplazar un carácter o palabra por otro dentro de un string. Recibe como parámetros el carácter o palabra a reemplazar y el nuevo carácter o palabra.
            Console.WriteLine("\n- Ejemplo de la función .Replace()");
            string fecha = "16/11/2026", fechaGuion = fecha.Replace("/", "-");
            Console.WriteLine($"La fecha se reemplazó por: {fechaGuion}\n");

            //i) Función .Split(): Permite separar un string en un arreglo unidimensional. Recibe como parámetro el carácter que se utilizará como separador y devuelve un vector con las subcadenas.
            Console.WriteLine("- Ejemplo de la función .Split()");
            string objetos = "Celular, mesa, cartera, sillón, taza"; Console.WriteLine($"Los objetos ingresados son {objetos}");
            string[] listaObjetos = objetos.Split(',');
            for (int i = 0; i < listaObjetos.Length; i++)
            {
                listaObjetos[i] = listaObjetos[i].Trim();
                Console.WriteLine($"Objeto {i + 1}: {listaObjetos[i]}");
            }
        }
    }
}