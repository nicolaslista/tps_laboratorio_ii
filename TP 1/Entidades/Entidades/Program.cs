using System;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Operando op1 = new Operando();
            Operando op2 = new Operando(5);
            //char operando = Char.Parse("e");
            //Console.WriteLine(Calculadora.Operar(op1, op2, operando));

            Console.WriteLine(op1.BinarioDecimal("111"));
            Console.WriteLine(op1.DecimalBinario("2"));
            Console.WriteLine(op1.DecimalBinario(2));
        }
    }
}