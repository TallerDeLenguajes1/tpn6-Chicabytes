using System;

namespace TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int final = 0;
            Console.WriteLine("El numero es: " + numero);
            while(numero >= 0)
            {   
                if(numero>=10)
                {
                    int resto = numero % 10;
                    numero /= 10;
                    final = resto + final*10;
                }
                else{
                    final = (final*10) + numero;
                    numero = 0;
                    break;
                }
                
            }
            Console.WriteLine("El numero invertido es:" + final);
        }
    }
}
