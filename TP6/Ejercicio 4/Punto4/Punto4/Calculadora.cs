using System;
using System.Collections.Generic;
using System.Text;

namespace Punto4
{
    public class Calculadora
    {
        private int resultado = 0;
        private int num1;
        private int num2;
        private int valor;

        public int Resultado { get => resultado; set => resultado = value; }
        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public int Valor { get => valor; set => valor = value; }

        static public int suma(int num1, int num2)
        {
            return num1 + num2;
        }
        static public int resta(int num1, int num2)
        {
            return num1 - num2;
        }
        static public int multiplic(int num1, int num2)
        {
            return num1 * num2;
        }
        static public int div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
