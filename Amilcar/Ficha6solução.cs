using System;

namespace Ficha6
{
    public class Ficha6solucao
    {
        /// <summary>
        /// Ficha6 ex1.1
        /// lê um nome e escreve olá nome
        /// </summary>
        public static void OlaNome()
        {
            Console.WriteLine("Escreve o teu nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("\nOlá " + nome);
        }

        /// <summary>
        /// Ficha6 ex1.2
        /// soma 2 numeros
        /// </summary>
        public static void Soma1()
        {
            Console.WriteLine("Escreva um numero: ");
            var n1 = Console.ReadLine();
            Console.WriteLine("Escreva um numero: ");
            var n2 = Console.ReadLine();
            Console.WriteLine(n1 + "+" + n2 + "=" + (Convert.ToInt32(n1) + Convert.ToInt32(n2)));
        }

        public static int ConverterStringParaInt(string num)
        {
            return int.Parse(num);
        }

        /// <summary>
        /// Ficha6 ex1.3 soma 10 numeros
        /// </summary>

        public static void Soma2()
        {   
            int soma = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Escreva um numero: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                soma += n1;
            }

            Console.WriteLine("Resultado: " + Convert.ToString(soma));
        }

        /// <summary>
        /// Ficha6 ex1.4 trac dois numeros
        /// </summary>
        public static void Troca()
        {
            Console.WriteLine("Escreva um numero A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva um numero B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            int C = A;
            A = B;
            B = C;
            Console.WriteLine("A=" + A + " e B=" + B);
        }

        /// <summary>
        /// Ficha6 ex1.5
        /// </summary>
        public static void Operações()
        {

        }
    }
}
