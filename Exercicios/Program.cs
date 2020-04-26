using System;
using C = System.Console;
using Recodme.Formacao.Modulo4Fichas.Common;
using Recodme.Formacao.Modulo4Fichas.Fichas.Exercicios;


namespace Recodme.Formacao.Modulo4Fichas.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();   
        }

        private static void Run()
        {
            Printer.PrintHeader("Módulo 4", 2, 3, ConsoleColor.Yellow, ConsoleColor.White, '#');
            while (true)
            {
                WriteLine("\nQual a Ficha?");
                WriteLine("Para sair escolha 0");
                WriteLine("Fichas disponiveis:");
                WriteLine(" Ficha 10");
                WriteLine(" Ficha 11");
                WriteLine(" Ficha 12");
                WriteLine(" Ficha 13");
                WriteLine(" Ficha 14");
                WriteLine(" Ficha 15");
                WriteLine(" Ficha 16");
                WriteLine(" Ficha 17");
                WriteLine(" Ficha 18");
                WriteLine(" Ficha 24");
                WriteLine(" Ficha 27\n");
                int f = Conversoes.ConverterStringParaInt(C.ReadLine());

                switch (f)
                {
                    case 0:
                        return;
                    case 10:
                        Ficha10solucao.Ficha10();
                        break;
                    case 11:
                        Ficha11solucao.Ficha11();
                        break;
                    case 12:
                        Ficha12solucao.Ficha12();
                        break;
                    case 13:
                        Ficha13solucao.Ficha13();
                        break;
                    case 14:
                        Ficha14solucao.Ficha14();
                        break;
                    case 15:
                        Ficha15solucao.Ficha15();
                        break;
                    case 16:
                        Ficha16solucao.Ficha16();
                        break;
                    case 17:
                        Ficha17solucao.Ficha17();
                        break;
                    case 18:
                        Ficha18solucao.Ficha18();
                        break;
                    case 24:
                        Ficha24solucao.Ficha24();
                        break;
                    case 27:
                        Ficha27solucao.Ficha27();
                        break;
                }
            }
        }

        private static void WriteLine<T>(T v)
        {
            Console.WriteLine(v.ToString());
        }

        private static void Write<T>(T v)
        {
            Console.Write(v.ToString());
        }
    }
}
