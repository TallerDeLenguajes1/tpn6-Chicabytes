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

            //Comparar

            Console.WriteLine("Ingrese una cadena a comparar: ");
            string cad3 = Console.ReadLine();

            int Comp = cadena.CompareTo(cad3);

            if(Comp == 0)
            {
                Console.WriteLine("Las cadenas son iguales");
            }
            else
            {
                Console.WriteLine("Las cadenas no son iguales");
            }

            //Separar
            Console.WriteLine("Ingrese una frase separada por '/': ");
            string cad4 = Console.ReadLine();
            string[] sepadado = cad4.Split('/');
            foreach (string palabra in sepadado)
            {
                Console.WriteLine(palabra);
            }

            //Calcular

            Console.WriteLine("Ingrese una operacion: ");
            string operacion = Console.ReadLine();
            int opera = 0;
            if (operacion.Contains('+'))
            {
                string[] ArreOperacion = operacion.Split('+');
                opera = Calculadora.suma(Convert.ToInt32(ArreOperacion[0]), Convert.ToInt32(ArreOperacion[1]));
                Console.WriteLine("El resultado es " + Convert.ToString(opera));
            }
            else if (operacion.Contains('-'))
            {
                string[] ArreOperacion = operacion.Split('+');
                opera = Calculadora.resta(Convert.ToInt32(ArreOperacion[0]), Convert.ToInt32(ArreOperacion[1]));
                Console.WriteLine("El resultado es " + Convert.ToString(opera));
            }
            else if (operacion.Contains('*'))
            {
                string[] ArreOperacion = operacion.Split('+');
                opera = Calculadora.multiplic(Convert.ToInt32(ArreOperacion[0]), Convert.ToInt32(ArreOperacion[1]));
                Console.WriteLine("El resultado es " + Convert.ToString(opera));
            }
            else if (operacion.Contains('/'))
            {
                string[] ArreOperacion = operacion.Split('+');
                if(ArreOperacion[2] != "0")
                {
                    opera = Calculadora.div(Convert.ToInt32(ArreOperacion[0]), Convert.ToInt32(ArreOperacion[1]));
                    Console.WriteLine("El resultado es " + Convert.ToString(opera));
                }
                else
                {
                    Console.WriteLine("No se pudo realizar la operacion");
                }
            }
        }
    }
}