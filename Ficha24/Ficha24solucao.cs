using System;
using System.Collections.Generic;
using Recodme.Formacao.Modulo4Fichas.Common;


namespace Recodme.Formacao.Modulo4Fichas.Fichas.Exercicios
{
    public class Ficha24solucao
    {
        /// <summary>
        /// Corre todos os exercicios da ficha 24
        /// </summary>
        public static void Ficha24()
        {
            int ex;

            Console.Clear();
            Printer.PrintHeader("Ficha 24", 2, 3, ConsoleColor.Yellow, ConsoleColor.White, '#');
            while (true)
            {
                Console.WriteLine("\nQual o exercicio?");
                Console.WriteLine("Para voltar escolha 0");
                Console.WriteLine("Para fechar a aplicação escolha -1");
                ex = Conversoes.ConverterStringParaInt(Console.ReadLine());
                switch (ex)
                {
                    case -1:
                        Environment.Exit(0);
                        break;
                    case 0:
                        return;
                    case 2:
                        Ex2();
                        break;/*
                    case 2:
                        JogoDoGalo();
                        break;
                    case 3:
                        JogoDaForca();
                        break;
                    case 4:
                        Start();
                        break;*/
                }
            }
        }

        static void Ex2()
        {

        }
    }

    public class carro
    {

    }

}
