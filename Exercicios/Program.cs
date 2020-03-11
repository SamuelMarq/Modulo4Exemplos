using System;
using Ficha6;
using Ficha7;
using Ficha12;
using Conversoes_;


namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            run();   
        }

        private static void run()
        {
            while (true)
            {
                Console.WriteLine("\nQual a Ficha?");
                Console.WriteLine("Para sair escolha 0\n");
                int f = Conversoes.ConverterStringParaInt(Console.ReadLine());

                switch (f)
                {
                    case 0:
                        return;
                    case 6:
                        Ficha6solucao.Ficha6();
                        break;
                    case 7:
                        Ficha7solucao.Ficha7();
                        break;
                    case 12:
                        Ficha12solucao.Ficha12();
                        break;
                }
            }
        }
    }
}
