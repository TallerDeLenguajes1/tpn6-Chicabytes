using System;

namespace Punto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Operaciones-----");
            Console.WriteLine("Ingrese un numero: ");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Valor Absoluto: " + Math.Abs(num1));
            Console.WriteLine("Su cuadrado: " + Math.Pow(num1, 2));
            Console.WriteLine("Su raiz cuadrada: " + Math.Sqrt(num1));
            Console.WriteLine("Seno: " + Math.Sin(num1));
            Console.WriteLine("Coseno: " + Math.Cos(num1));
            Console.WriteLine("La parte entera: " + Math.Round(num1));
            Console.WriteLine("-----Maximo y Minimo-----");
            Console.WriteLine("Ingrese el primer numero : ");
            float num2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero : ");
            float num3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("El maximo entre los dos numeros: " + Math.Max(num2, num3));
            Console.WriteLine("El minimo entre los dos numeros: " + Math.Min(num2, num3));
        }
    }
}
