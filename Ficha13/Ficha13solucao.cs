using System;
using System.Threading;
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

            Console.Clear();
            while (true)
            {
                Console.WriteLine("\nQual o exercicio?");
                Console.WriteLine("Para voltar escolha 0");
                Console.WriteLine("Para fechar a aplicação escolha -1");
                Console.WriteLine("1 - Calculadora");
                Console.WriteLine("2 - Jogo Do Galo");
                Console.WriteLine("3 - Jogo Da Forca");
                Console.WriteLine("4 - Pedra, Papel ou Tesoura\n");
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
                    case 4:
                        Start();
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
        private static void Calculadora()
        {
            char op;
            decimal n=0;
            bool firstrun = true;
            Console.Clear();
            Printer.PrintHeader("Calculadora", 2, 2, ConsoleColor.White, ConsoleColor.White, '#');
            while (true)
            {
                if (firstrun)
                {
                    PrintCalc();
                    n = LerNumEConverter2();
                    PrintCalc(n.ToString());
                    firstrun = false;
                }
                Console.WriteLine("\nPara sair escolha 'X'");
                Console.WriteLine("Para apagar escolha 'C'\n");
                Console.WriteLine("Qual a operação\n");
                op = Console.ReadLine()[0];
                if(op == '+' || op == '-' || op == '*' || op == '/' || op == '%')
                    PrintCalc(n.ToString()+op);
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
                    case '%':
                        n = Res(n);
                        break;
                }
            }
        }

        private static Decimal Soma(decimal n1)
        {
            decimal n2;
            n2 = LerNumEConverter2();
            var n3 = n1 + n2;
            PrintCalc($"{n1}+{n2}={n3}");
            return n3;
        }

        private static Decimal Minus(decimal n1)
        {
            decimal n2;
            n2 = LerNumEConverter2();
            var n3 = n1 - n2;
            PrintCalc($"{n1}-{n2}={n3}");
            return n3;
        }

        private static Decimal Times(decimal n1)
        {
            decimal n2;
            n2 = LerNumEConverter2();
            var n3 = n1 * n2;
            PrintCalc($"{n1}*{n2}={n3}");
            return n3;
        }

        private static Decimal Div(decimal n1)
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
            PrintCalc($"{n1}/{n2}={n3}");
            return n3;
        }

        private static Decimal Res(decimal n1)
        {
            decimal n2, n3;
            n3 = 0;
            while (true)
            {
                try
                {
                    n2 = LerNumEConverter2();
                    n3 = n1 % n2;
                    break;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Can't divide by 0");
                    Console.WriteLine("Choose another number");
                }
            }
            PrintCalc($"{n1}%{n2}={n3}");
            return n3;
        }


        private static void PrintCalc(string display = "               ")
        {
            Console.Clear();
            while (display.Length<21)
            {
                display = " " + display;
            }
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n                    ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" X ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("\n ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(display);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.Write("\n             C     =   ");
            Console.Write("\n   7    8    9     %   ");
            Console.Write("\n   4    5    6     /   ");
            Console.Write("\n   1    2    3     *   ");
            Console.Write("\n   0    .    +     -   \n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion

        #region Jogo do Galo
        private static void JogoDoGalo()
        {
            char n1 = ' ', n2 = ' ', n3 = ' ', n4 = ' ', n5 = ' ', n6 = ' ', n7 = ' ', n8 = ' ', n9 = ' ';
            Console.Clear();
            Printer.PrintHeader("Jogo Do Galo", 2, 2, ConsoleColor.Green, ConsoleColor.Yellow, '#');
            Console.WriteLine($"\n{n1}|{n2}|{n3}\n-----\n{n4}|{n5}|{n6}\n-----\n{n7}|{n8}|{n9}\n");
            for (int i = 0; true; i++)
            {
                if (i%2==0)
                {
                    Jogada(i, 1, ref n1, ref n2, ref n3, ref n4, ref n5, ref n6, ref n7, ref n8, ref n9);
                    Console.Clear();
                    Console.WriteLine($"\n{n1}|{n2}|{n3}\n-----\n{n4}|{n5}|{n6}\n-----\n{n7}|{n8}|{n9}\n");
                    var e = VictCond(1, ref n1, ref n2, ref n3, ref n4, ref n5, ref n6, ref n7, ref n8, ref n9);
                    if (e)
                        return;
                }
                else
                {
                    Jogada(i, 2, ref n1, ref n2, ref n3, ref n4, ref n5, ref n6, ref n7, ref n8, ref n9);
                    Console.Clear();
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
            sbyte suc;
            string wordGame = "", wordTry = "", usedLts = "";
            string ls = "abcdefghijklmnopqrstuvxwyz";
            Console.Clear();
            Printer.PrintHeader("Jogo Da Forca", 2, 2, ConsoleColor.Green, ConsoleColor.Yellow, '#');
            PrintForca(fails);
            wordGame = GetGameWord(out int length);
            for (int i = 0; i < length; i++)
            {
                wordTry += "-";
            }
            suc = GameRounds(ref wordGame, ref wordTry, ref usedLts, ref ls, true);
            fails = (suc == -1) ? fails + 1 : fails;
            Console.Clear();
            PrintForca(fails);
            while (fails<6)
            {
                suc = GameRounds(ref wordGame, ref wordTry, ref usedLts, ref ls);
                fails = (suc==-1) ? fails+1 : fails;
                if (suc < 1 && fails < 6)
                {
                    Console.Clear();
                    PrintForca(fails);
                }
                else if (suc==1)
                {
                    Console.WriteLine($"\nA Palavra é {wordGame}\n");
                    PrintForca(fails, true);
                    return;
                }
            }
            Console.Clear();
            Console.BackgroundColor=ConsoleColor.DarkRed;
            Console.Write($"\nA Palavra era {wordGame}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            PrintForca(fails);
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
                s += "\n      _______\n";
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

        /// <summary>
        /// Takes a string with the valid leters and returns a valid letter from the user 
        /// </summary>
        private static char GetCharacter(string ls)
        {
            string r;
            char l;
            Console.WriteLine("\nEscolha uma letra:");
            while (true)
            {
                r = Console.ReadLine().ToLower();
                l = r[0];
                if (ls.Contains(l))
                    break;
                else
                    Console.WriteLine($" '{l}' Não É uma Letra Válida!\nEscolha uma letra diferente:");
            }
            return l;
        }

        /// <summary>
        /// Takes the word you're trying to guess and returns true if you guess it and false if you don't
        /// </summary>
        private static bool GuessWord(string wordGame)
        {
            Console.WriteLine("Qual a palavra?");
            if (Console.ReadLine().ToLower() == wordGame)
                return true;
            return false;
        }

        /// <summary>
        /// Has the code to run a round of playing it changes the values of wordGame, wordTry, usedLts and ls.
        /// Returns -1 if failed to get a correct letter; 0 if it got a correct letter and 1 if it got the word
        /// </summary>
        private static sbyte GameRounds(ref string wordGame, ref string wordTry, ref string usedLts, ref string ls, bool round1=false)
        {
            char l;
            string ans="n";
            bool suc = false;
            if (round1)
            {
                Console.WriteLine("\nPalavra a descobrir:");
                Console.WriteLine($"  {wordTry}");
            }
            else
            {
                Console.WriteLine("\nPalavra a descobrir:");
                Console.WriteLine($"  {wordTry}");
                Console.WriteLine("\nLetras Usadas:");
                Console.WriteLine($"  {usedLts}");
                Console.WriteLine("\nQueres tentar advinhar a palavra? (responde s ou n)");
                while (true)
                {
                    ans = Console.ReadLine();
                    if (ans == "n" | ans == "s")
                        break;
                    else
                        Console.WriteLine("\nQueres tentar advinhar a palavra? (responde s ou n)");
                }
            }
            if (ans=="n")
            {
                l = GetCharacter(ls);
                for (int i = 0; i < ls.Length; i++)
                {
                    if (l==ls[i])
                    {
                        ls=ls.Remove(i,1);
                        break;
                    }
                }
                for (int i = 0; i < wordGame.Length; i++)
                {
                    if (l==wordGame[i])
                    {
                        suc = true;
                        wordTry=wordTry.Remove(i,1);
                        wordTry=wordTry.Insert(i,l.ToString());
                    }
                }
                usedLts += $"{l}, ";
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Palavra a descobrir:");
                Console.WriteLine($"  {wordTry}");
                bool w = GuessWord(wordGame);
                if (w)
                    return 1;
            }
            if (suc)
                if (wordGame == wordTry)
                    return 1;
                else
                    return 0;
            else
                return -1;
        }
        #endregion

        #region PedraPapelOuTesoura

        private static void Start()
        {
            int jogadasV, winsJ=0, winsC=0;
            string nome, jogadaJ, jogadaC;
            Console.Clear();
            Printer.PrintHeader("Pedra, Papel ou Tesoura", 2, 2, ConsoleColor.Green, ConsoleColor.Yellow, '#');
            jogadasV = InputRequest.RequestInt("Quantas jogadas são necessárias para um jogador vencer?", true);
            nome = InputRequest.RequestString("Qual o nome do jogador?");
            while (nome.Length > 20)
                nome = InputRequest.RequestString("O nome tem de ter menos de 20 caracteres");
            while (true)
            {
                Console.Clear();
                Pontuacao(nome, winsJ, winsC, jogadasV);
                jogadaJ = JogadaJ();
                jogadaC = JogadaC();
                Console.WriteLine($"Computador:\n{jogadaC}");
                int w = RoundW(jogadaC, jogadaJ);
                if (w == -1)
                {
                    winsC++;
                    Console.WriteLine("Vitória do Computador!\n");
                }
                else if (w == 1)
                {
                    winsJ++;
                    Console.WriteLine($"Vitória do Jogador {nome}!\n");
                }
                else
                    Console.WriteLine("Empate!\n");
                if (winsJ == jogadasV)
                {
                    Console.WriteLine("");
                    Pontuacao(nome, winsJ, winsC, jogadasV);
                    Printer.PrintHeader("Victory!", 2, 3, ConsoleColor.DarkGreen, ConsoleColor.Green, '▓');
                    return;
                }
                else if (winsC == jogadasV)
                {
                    Console.WriteLine("");
                    Pontuacao(nome, winsJ, winsC, jogadasV);
                    Printer.PrintHeader("Game Over!", 2, 3, ConsoleColor.DarkRed, ConsoleColor.Red, '▓');
                    return;
                }
                Console.WriteLine("Perssione qualquer tecla para continuar");
                Console.ReadKey();
            }



        }

        /// <summary>
        /// Escolhe uma jogada aleatoria para o computador
        /// </summary>
        private static string JogadaC()
        {
            int j = new Random().Next(1,4);
            string jogada="";
            switch (j)
            {
                case 1:
                    jogada = "pedra";
                    break;
                case 2:
                    jogada = "papel";
                    break;
                case 3:
                    jogada = "tesoura";
                    break;
            }
            return jogada;
        }

        /// <summary>
        /// Devolve a jogada escolhida pelo user
        /// </summary>
        private static string JogadaJ()
        {
            string jogada = InputRequest.RequestString("Qual a tua jogada?").ToLower();
            while (jogada!="tesoura" && jogada!="pedra" && jogada !="papel")
            {
                jogada = InputRequest.RequestString("Tens de escolher pedra, papel ou tesoura.").ToLower();
            }
            return jogada;
        }

        /// <summary>
        /// Devolve 1 se o jogador ganhar, -1 se o computador ganhar e 0 se for empate
        /// </summary>
        private static int RoundW(string jogadaC, string jogadaJ)
        {
            if (jogadaC == jogadaJ)
            {
                switch (jogadaC)
                {
                    case "pedra":
                        Display('r', 'r');
                        break;
                    case "tesoura":
                        Display('t', 't');
                        break;
                    case "papel":
                        Display('p', 'p');
                        break;
                }
                return 0;
            }
            else if (jogadaC == "pedra")
            {
                if (jogadaJ == "papel")
                {
                    Display('p', 'r');
                    return 1;
                }
                else
                {
                    Display('t', 'r');
                    return -1;
                }
            }
            else if (jogadaC == "papel")
            {
                if (jogadaJ == "pedra")
                {
                    Display('r', 'p');
                    return -1;
                }
                else
                {
                    Display('t', 'p');
                    return 1;
                }
            }
            else
            {
                if (jogadaJ == "pedra")
                {
                    Display('r', 't');
                    return 1;
                }
                else
                {
                    Display('p', 't');
                    return -1;
                }
            }
        }

        /// <summary>
        /// Imprime uma tabela com a pontuação
        /// </summary>
        private static void Pontuacao(string nome, int winsJ, int winsC, int jogadasV) 
        {
            string s;
            nome += ":  ";
            while (nome.Length<22)
                nome += " ";
            s = "╔═══════════════════════╗\n";
            s += $"║Jogadas para vencer:  {jogadasV}║";
            s += $"\n║-----------------------║";
            s += $"\n║Computador:           {winsC}║";
            s += $"\n║{nome}{winsJ}║";
            s += "\n╚═══════════════════════╝\n";
            Console.WriteLine(s);
        }

        private static void Display(char p1, char p2, int rounds = 3)
        {
            for (var i = 0; i < rounds; i++)
            {
                var @switch = false;
                var pos = 0;
                while (!(@switch && pos == 0))
                {
                    Console.Clear();
                    if (i == rounds - 1 && pos == 2)
                    {
                        DisplayResult(pos, p1, p2);
                        Thread.Sleep(500);
                        break;
                    }
                    else
                    {
                        DisplayResult(pos, 'r', 'r');
                    }
                    Thread.Sleep(50);
                    pos = pos + (@switch ? -1 : 1);
                    if (pos == 4) @switch = !@switch;
                }
            }
        }

        private static void DisplayResult(int lines, char p1, char p2)
        {
            while (lines > 0)
            {
                Console.WriteLine();
                lines--;
            }
            //1
            Console.Write("          _______");
            Console.CursorLeft = 30;
            Console.WriteLine(p2 == 'r' ? "  _______" : p2 == 'p' ? "       _______" : "       _______");

            //2
            Console.Write(p1 == 'r' ? "      ---'   ____)" : p1 == 'p' ? "      ---'   ____)____ " : "      ---'   ____)____");
            Console.CursorLeft = 30;
            Console.WriteLine(p2 == 'r' ? " (____   '---      " : p2 == 'p' ? "  ____(____   '---      " : "  ____(____   '---      ");

            //3
            Console.Write(p1 == 'r' ? "            (_____)" : "                ______)");
            Console.CursorLeft = 30;
            Console.WriteLine(p2 == 'r' ? "(____   '---      " : " (______");

            //4
            Console.Write(p1 == 'r' ? "            (_____)" : p1 == 'p' ? "                _______)" : "             __________)");
            Console.CursorLeft = 30;
            Console.WriteLine(p2 == 'r' ? "(_____)" : p2 == 'p' ? "(_______" : "(__________");

            //5
            Console.Write(p1 == 'r' ? "             (____)" : p1 == 'p' ? "               _______)" : "            (____)");
            Console.CursorLeft = 30;
            Console.WriteLine(p2 == 'r' ? "(____)" : p2 == 'p' ? " (_______" : "     (____)");

            //6
            Console.Write(p1 == 'r' ? "      ---.__(___) " : p1 == 'p' ? "      ---.__________)" : "      ---.__(___)");
            Console.CursorLeft = 30;
            Console.WriteLine(p2 == 'r' ? "  (___)__.---" : p2 == 'p' ? "   (__________.---" : "      (___)__.---");
        }

        #endregion
    }
}
