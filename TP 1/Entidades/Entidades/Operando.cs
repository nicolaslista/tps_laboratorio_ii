using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        private double ValidarOperando(string strNumero)
        {
            double numericValue;
            bool isNumber = double.TryParse(strNumero, out numericValue);
            if (isNumber)
                return numericValue;
            return 0;
        }
        private string Numero {
            set { this.numero = ValidarOperando(value); }
        }

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        private bool EsBinario(string binario)
        {
            foreach (var c in binario)
                if (c != '0' && c != '1')
                    return false;
            return true;
        }

        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
                return Convert.ToInt64(binario, 2).ToString();
            return "Valor inválido";
        }
        public string DecimalBinario(string numero)
        { 
            string binar = Convert.ToString(Int32.Parse(numero), 2);
            if (EsBinario(binar))
                return binar;
            return "Valor inválido";
        }
        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }


        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
                return Double.MinValue;
            return n1.numero / n2.numero;
        }

    }
}
