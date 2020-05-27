using System;
using System.Numerics;

namespace Tp6_Punto2
{
    class Programa2
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int valor = 1;
            int resultado = 0;
            
            while(valor > 0)
            {
                Console.WriteLine("-----Elija la operación-----");
                Console.WriteLine("1.Suma");
                Console.WriteLine("2.Resta");
                Console.WriteLine("3.Multiplicacion");
                Console.WriteLine("4.Division");
                valor = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el primer numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo numero distinto de 0: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 != 0)
                {
                    if(valor == 1)
                    {
                        resultado = num1 + num2;
                    }else if(valor == 2)
                    {
                        if (num1 > num2)
                        {
                            resultado = num1 - num2;
                        }
                        else
                        {
                            resultado = num2 - num1;
                        }
                    }
                    else if(valor == 3)
                    {
                        resultado = num1 * num2;
                    }
                    else
                    {
                        resultado = num1 / num2;
                    }
                    Console.WriteLine("El resultado de la operacion es: " + resultado);
                    Console.WriteLine("Desea realizar otra operacion?");
                    Console.Write("Para salir ingrese 0, para elegir otra operacion ingrese 1.");
                    valor = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("El segundo numero no es adecuado");
                }
            }
        }
    }
}
