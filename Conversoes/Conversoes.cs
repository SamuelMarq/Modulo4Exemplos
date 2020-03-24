using System;

namespace Common
{
    public class Conversoes
    {
        /// <summary>
        /// Usado para converter strings para int de forma segura, devolve 0 se for fornecido um valor não convertivel
        /// </summary>
        public static int ConverterStringParaInt(string num)
        {
            var parseOk = int.TryParse(num, out int parsedNum);
            if (parseOk)
            {
                return parsedNum;
            }
            else
            {
                return 0;
            }
            //= a return parseOk ? parseNum : 0;
            // neste caso também dá "return parsedNum;" porque será = 0 por default se for fornecida uma string
        }

        /// <summary>
        /// Usado para converter strings para decimal de forma segura, devolve 0 se for fornecido um valor não convertivel
        /// </summary>
        public static decimal ConverterStringParaDecimal(string num)
        {
            decimal.TryParse(num, out decimal parsedNum);
            return parsedNum;
        }

        /// <summary>
        /// Usado para converter strings para doubles de forma segura, devolve 0 se for fornecido um valor não convertivel
        /// </summary>
        public static double ConverterStringParaDouble(string num)
        {
            double.TryParse(num, out double parsedNum);
            return parsedNum;
        }
    }
}

