using System;
using Common;

namespace Ficha13
{
    public class Ficha13solucao
    {
        /// <summary>
        /// Corre todos os exercicios da ficha 13
        /// </summary>
        public static void Ficha13()
        {
            int ex;

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
                        Calculadora();
                        break;
                    case 2:
                        JogoDoGalo();
                        break;
                    case 3:
                        JogoDaForca();
                        break;
                }
            }
        }


        private static decimal LerNumEConverter2()
        {
            decimal n = 0;
            Console.WriteLine("\nEscreva um número: ");
            while (69!=420)
            {
                try
                {
                    n = Convert.ToDecimal(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nEntrada inválida: ");
                    Console.WriteLine("\nEscreva um número: ");
                }
            }
            return n;
        }

        #region Calculadora

        /// <summary>
        /// Calculadora
        /// </summary>
        public static void Calculadora()
        {
            char op;
            decimal n=0;
            bool firstrun = true;

            Console.WriteLine("\nCalculadora");
            while (true)
            {
                if (firstrun)
                {
                    n = LerNumEConverter2();
                    firstrun = false;
                }
                Console.WriteLine("\nPara sair escolha 'X'");
                Console.WriteLine("Para apagar escolha 'C'\n");
                Console.WriteLine("Qual a operação\n");
                op = Console.ReadLine()[0];
                
                switch (op)
                {
                    case 'X':
                        return;
                    case 'C':
                        n = 0;
                        firstrun = true;
                        Console.Clear();
                        break;
                    case '+':
                        n=Soma(n);
                        break;
                    case '-':
                        n = Minus(n);
                        break;
                    case '*':
                        n = Times(n);
                        break;
                    case '/':
                        n = Div(n);
                        break;
                }
            }
        }

        public static Decimal Soma(decimal n1)
        {
            decimal n2;
            n2 = LerNumEConverter2();
            var n3 = n1 + n2;
            Console.WriteLine($"{n1}+{n2}={n3}");
            return n3;
        }

        public static Decimal Minus(decimal n1)
        {
            decimal n2;
            n2 = LerNumEConverter2();
            var n3 = n1 - n2;
            Console.WriteLine($"{n1}-{n2}={n3}");
            return n3;
        }

        public static Decimal Times(decimal n1)
        {
            decimal n2;
            n2 = LerNumEConverter2();
            var n3 = n1 * n2;
            Console.WriteLine($"{n1}*{n2}={n3}");
            return n3;
        }

        public static Decimal Div(decimal n1)
        {
            decimal n2, n3;
            n3 = 0;
            while (true)
            {
                try
                {
                    n2 = LerNumEConverter2();
                    n3 = n1 / n2;
                    break;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Can't divide by 0");
                    Console.WriteLine("Choose another number");
                }
            }
            Console.WriteLine($"{n1}/{n2}={n3}");
            return n3;
        }
        #endregion

        #region Jogo do Galo
        private static void JogoDoGalo()
        {
            char n1 = ' ', n2 = ' ', n3 = ' ', n4 = ' ', n5 = ' ', n6 = ' ', n7 = ' ', n8 = ' ', n9 = ' ';
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nJogo do Galo");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n{n1}|{n2}|{n3}\n-----\n{n4}|{n5}|{n6}\n-----\n{n7}|{n8}|{n9}\n");
            for (int i = 0; true; i++)
            {
                if (i%2==0)
                {
                    Jogada(i, 1, ref n1, ref n2, ref n3, ref n4, ref n5, ref n6, ref n7, ref n8, ref n9);
                    Console.WriteLine($"\n{n1}|{n2}|{n3}\n-----\n{n4}|{n5}|{n6}\n-----\n{n7}|{n8}|{n9}\n");
                    var e = VictCond(1, ref n1, ref n2, ref n3, ref n4, ref n5, ref n6, ref n7, ref n8, ref n9);
                    if (e)
                        return;
                }
                else
                {
                    Jogada(i, 2, ref n1, ref n2, ref n3, ref n4, ref n5, ref n6, ref n7, ref n8, ref n9);
                    Console.WriteLine($"\n{n1}|{n2}|{n3}\n-----\n{n4}|{n5}|{n6}\n-----\n{n7}|{n8}|{n9}\n");
                    var e = VictCond(2, ref n1, ref n2, ref n3, ref n4, ref n5, ref n6, ref n7, ref n8, ref n9);
                    if (e)
                        return;
                }
            }

        }

        private static void Jogada(int j, int p, ref char n1, ref char n2, ref char n3, ref char n4,
                                   ref char n5, ref char n6, ref char n7, ref char n8, ref char n9)
        {
            while (true)
            {
                Console.WriteLine($"Jogador {p}: Escolha 1 quadrante vazio");
                Console.WriteLine($"\n1|2|3\n-----\n4|5|6\n-----\n7|8|9\n");
                var n = Console.ReadLine();
                switch (n)
                {
                    case "1":
                        if (n1==' ')
                        {
                            if (p==1)
                                n1='O';
                            else
                                n1 = 'X';
                            return;
                        }
                    break;
                    case "2":
                        if (n2 == ' ')
                        {
                            if (p == 1)
                                n2 = 'O';
                            else
                                n2 = 'X';
                            return;
                        }
                        break;
                    case "3":
                        if (n3 == ' ')
                        {
                            if (p == 1)
                                n3 = 'O';
                            else
                                n3 = 'X';
                            return;
                        }
                        break;
                    case "4":
                        if (n4 == ' ')
                        {
                            if (p == 1)
                                n4 = 'O';
                            else
                                n4 = 'X';
                            return;
                        }
                        break;
                    case "5":
                        if (n5 == ' ')
                        {
                            if (p == 1)
                                n5 = 'O';
                            else
                                n5 = 'X';
                            return;
                        }
                        break;
                    case "6":
                        if (n6 == ' ')
                        {
                            if (p == 1)
                                n6 = 'O';
                            else
                                n6 = 'X';
                            return;
                        }
                        break;
                    case "7":
                        if (n7 == ' ')
                        {
                            if (p == 1)
                                n7 = 'O';
                            else
                                n7 = 'X';
                            return;
                        }
                        break;
                    case "8":
                        if (n8 == ' ')
                        {
                            if (p == 1)
                                n8 = 'O';
                            else
                                n8 = 'X';
                            return;
                        }
                        break;
                    case "9":
                        if (n9 == ' ')
                        {
                            if (p == 1)
                                n9 = 'O';
                            else
                                n9 = 'X';
                            return;
                        }
                        break;
                }
            }
            
        }

        private static bool VictCond(int p, ref char n1, ref char n2, ref char n3, ref char n4,
                                   ref char n5, ref char n6, ref char n7, ref char n8, ref char n9)
        {
            bool endgame = false, test=false;
            test = (n1 == n2 && n1 == n3 && n1 != ' ' ||
                    n4 == n5 && n4 == n6 && n4 != ' ' ||
                    n7 == n8 && n7 == n9 && n7 != ' ' ||
                    n1 == n4 && n1 == n7 && n1 != ' ' ||
                    n2 == n5 && n2 == n8 && n2 != ' ' ||
                    n3 == n6 && n3 == n9 && n3 != ' ' ||
                    n1 == n5 && n1 == n9 && n1 != ' ' ||
                    n3 == n5 && n3 == n7 && n3 != ' ');

            if (test)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O Jogador {p} Ganhou!");
                Console.ForegroundColor = ConsoleColor.White;
                endgame = true;
            }
            else if (n1!=' '&& n2 != ' ' && n3 != ' ' && n4 != ' ' 
                    && n5 != ' ' && n6 != ' ' && n7 != ' ' && n8 != ' ' && n9 != ' ')
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"O Jogo Acabou Empatado.");
                Console.ForegroundColor = ConsoleColor.White;
                endgame = true;
            }
            return endgame;
        }

        #endregion

        #region Jogo da Forca

        private static void JogoDaForca()
        {
            int fails = 0;
            string wordGame = "", WordTry = "";
            Printer.PrintHeader("Jogo Da Forca", 2, 2, ConsoleColor.Green, ConsoleColor.Yellow, '#');
            PrintForca(fails);
            wordGame = GetGameWord(out int length);
            for (int i = 0; i < length; i++)
            {
                WordTry += "_";
            }
            Console.WriteLine("\nPalavra a descobrir:");
            Console.WriteLine($"  {WordTry}");
            Console.WriteLine("\nEscolha uma letra:");
            

        }

        /// <summary>
        /// Prints the image for the current number on attempts, if win==true it displays the victory image
        /// </summary>
        private static void PrintForca(int fails,bool win=false)
        {
            string s = "";
            if (win)
            {
                Printer.PrintHeader("Victory!", 2, 3, ConsoleColor.DarkGreen, ConsoleColor.Green, '▓');
                s += "      _______\n";
                s += "     |/      |\n";
                s += "     |       |\n";
                s += "     |\n";
                s += "     |\n";
                s += "     |            -----     @\n";
                s += "     |              --   .^/L.\n";
                s += "     |           ----   , /-,\n";
                s += " ____|____               ` /\n";
            }
            else if (fails==0)
            {
                s+= "      _______\n";
                s+= "     |/      |\n";
                s+= "     |       |\n";
                s+= "     |\n";
                s+= "     |\n";
                s+="     |\n";
                s+="     |\n";
                s+="     |\n";
                s+=" ____|____\n";
            }
            else if (fails==1)
            {
                s += "      _______\n";
                s += "     |/      |\n";
                s += "     |       |\n";
                s += "     |      (_)\n";
                s += "     |\n";
                s += "     |\n";
                s += "     |\n";
                s += "     |\n";
                s += " ____|____\n";
            }
            else if (fails == 2)
            {
                s += "      _______\n";
                s += "     |/      |\n";
                s += "     |       |\n";
                s += "     |      (_)\n";
                s += "     |       |\n";
                s += "     |       |\n";
                s += "     |\n";
                s += "     |\n";
                s += " ____|____\n";
            }
            else if (fails == 3)
            {
                s += "      _______\n";
                s += "     |/      |\n";
                s += "     |       |\n";
                s += "     |      (_)\n";
                s += "     |      /|\n";
                s += "     |       |\n";
                s += "     |\n";
                s += "     |\n";
                s += " ____|____\n";
            }
            else if (fails == 4)
            {
                s += "      _______\n";
                s += "     |/      |\n";
                s += "     |       |\n";
                s += "     |      (_)\n";
                s += "     |      /|\\\n";
                s += "     |       |\n";
                s += "     |\n";
                s += "     |\n";
                s += " ____|____\n";
            }
            else if (fails == 5)
            {
                s += "      _______\n";
                s += "     |/      |\n";
                s += "     |       |\n";
                s += "     |      (_)\n";
                s += "     |      /|\\\n";
                s += "     |       |\n";
                s += "     |      /\n";
                s += "     |\n";
                s += " ____|____\n";
            }
            else if (fails == 6)
            {
                s += "      _______\n";
                s += "     |/      |\n";
                s += "     |       |\n";
                s += "     |      (_)\n";
                s += "     |      /|\\\n";
                s += "     |       |\n";
                s += "     |      / \\\n";
                s += "     |\n";
                s += " ____|____\n";
                Printer.PrintHeader("Game Over!", 2, 3, ConsoleColor.DarkRed, ConsoleColor.Red, '▓');
            }
             Console.WriteLine(s);
        }

        /// <summary>
        /// Returns a random word from a selection of ten an the lenght of the word
        /// </summary>
        private static string GetGameWord(out int length)
        {
            Random rdm = new Random();
            int r = rdm.Next(1, 11);
            string word="";
            switch (r)
            {
                case 1:
                    word = "ola";
                    break;
                case 2:
                    word = "banana";
                    break;
                case 3:
                    word = "gorila";
                    break;
                case 4:
                    word = "material";
                    break;
                case 5:
                    word = "arroz";
                    break;
                case 6:
                    word = "fogo";
                    break;
                case 7:
                    word = "fernando";
                    break;
                case 8:
                    word = "feriado";
                    break;
                case 9:
                    word = "alperce";
                    break;
                case 10:
                    word = "dez";
                    break;
            }
            length = word.Length;
            return word;
        }
        #endregion
    }
}
