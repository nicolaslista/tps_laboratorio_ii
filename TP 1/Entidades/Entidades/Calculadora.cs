using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            switch (ValidarOperador(operador))
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
                default:
                    return 0;
            }
        }

        private static char ValidarOperador(char operador)
        {
            char[] operators = { '+', '-', '*', '/' };
            for (int i = 0; i < operators.Length; i++)
            {
                if(operators[i] == operador)
                    return operador;
            }
            return '+';
        }
    }
}
