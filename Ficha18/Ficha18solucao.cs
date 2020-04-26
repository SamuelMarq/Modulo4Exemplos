using System;
using System.Collections.Generic;
using Recodme.Formacao.Modulo4Fichas.Common;

namespace Recodme.Formacao.Modulo4Fichas.Fichas.Exercicios
{
    public class Ficha18solucao
    {
        /// <summary>
        /// Corre todos os exercicios da ficha 18
        /// </summary>
        public static void Ficha18()
        {
            int ex;

            Console.Clear();
            Printer.PrintHeader("Ficha 18", 2, 3, ConsoleColor.Yellow, ConsoleColor.White, '#');
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
                    case 1:
                        Ex1();
                        break;
                    case 5:
                        Ex5();
                        break;
                    case 6:
                        Ex6();
                        break;
                    case 10:
                        Ex10();
                        break;
                }
            }
        }

        /// <summary>
        /// ex1 Contar o número de anos bissextos entre dois anos
        /// </summary>
        static void Ex1()
        {
            var a1 = InputRequest.RequestInt("Escolhe um ano",true);
            var a2 = -1;
            while (a1>=a2)
            {
                a2 = InputRequest.RequestInt("Escolhe um ano maior");
            }
            int b = 0;

            for (int ano=a1; ano <= a2; ano++)
            {
                if (DateTime.IsLeapYear(ano)) b++;
            }

            Console.WriteLine($"Número de anos bissextos entre {a1} e {a2}: {b}");
        }

        /// <summary>
        /// ex5 Apresentar a data de amanhã.
        /// </summary>
        static void Ex5()
        {
            var hoje = DateTime.Now;
            Console.Write("Amanhã é: ");
            Console.WriteLine(hoje.AddDays(1).ToString("dd/MM/yyyy"));
        }

        /// <summary>
        /// ex6 Apresentar a data de amanhã.
        /// </summary>
        static void Ex6()
        {
            var hoje = DateTime.Now;
            Console.Write("Ontem foi: ");
            Console.WriteLine(hoje.AddDays(-1).ToString("dd/MM/yyyy"));
        }

        /// <summary>
        /// ex10 Apresentar uma data num formato especifico
        /// </summary>
        static void Ex10()
        {
            var hoje = DateTime.Now;
            var mes = new string[13]{"","Janeiro","Fevereiro","Março","Abril","Maio","Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro" };
            Console.WriteLine($"Hoje, {TranslateWeekDay(hoje.DayOfWeek.ToString())}, dia {hoje.Day} do mês de {mes[hoje.Month]} de {hoje.Year}" +
                $", às {hoje.Hour} horas, {hoje.Minute} minutos e {hoje.Second} segundos, estudei");
        }

        /// <summary>
        /// Traduz o dia da semana para portugues
        /// </summary>
        static string TranslateWeekDay(string wd)
        {
            switch (wd)
            {
                    case "Monday": wd = "Segunda"; break;
                    case "Tuesday": wd = "Terça"; break;
                    case "Wednesday": wd = "Quarta"; break;
                    case "Thursday": wd = "Quinta"; break;
                    case "Friday": wd = "Sexta"; break;
                    case "Saturday": wd = "Sábado"; break;
                    case "Sunday": wd = "Domingo"; break;
                    default: break;
            }
            return wd;
        }
    }
}
