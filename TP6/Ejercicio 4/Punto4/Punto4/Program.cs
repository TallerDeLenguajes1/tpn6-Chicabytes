using System;
using System.Threading;
using Punto4;

namespace Punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una cadena de caracteres: ");
            string cadena = Console.ReadLine();
            
            Random rando = new Random();
            
            Console.Write("Letras obtenidas: ");
            foreach (char letra in cadena)
            {
                int numero = rando.Next(3)+1;
                if(numero == 3)
                {
                    Console.Write(letra + " ");
                }
            }
            
            int largo = cadena.Length;
            Console.WriteLine("\nEl largo de la cadena es: " + largo);
            
            Console.Write("Por favor ingrese otra cadena: ");
            string cad2 = Console.ReadLine();
            Console.WriteLine("La cadena concatenada es: " + cadena + " " + cad2);

            Console.WriteLine("Parte de la cadena es: " + cad2.Substring(4));

            int valor1 = 10;
            int valor2 = 2;

            int resultado = Calculadora.suma(valor1, valor2);

            string aux1 = valor1.ToString();
            string aux2 = valor2.ToString();
            string aux3 = resultado.ToString();

            Console.WriteLine("La suma de " + aux1 + " mas " + aux2 + " es " + aux3);

            int resultado2 = Calculadora.resta(valor1, valor2);
            string aux4 = resultado2.ToString();

            Console.WriteLine("La resta de " + aux1 + " menos " + aux2 + " es " + aux4);

            int resultado3 = Calculadora.multiplic(valor1, valor2);
            string aux5 = resultado3.ToString();

            Console.WriteLine("El producto de " + aux1 + " por " + aux2 + " es " + aux5);

            int resultado4 = Calculadora.div(valor1, valor2);
            string aux6 = resultado4.ToString();

            Console.WriteLine("El cociente de " + aux1 + " sobre " + aux2 + " es " + aux6);

            foreach (char letraCadena in cadena)
            {
                Console.Write(letraCadena);
            }

            string mayus = cadena.ToUpper();

            Console.WriteLine(mayus);

            string minus = cad2.ToLower();

            Console.WriteLine(minus);

        }
    }
}