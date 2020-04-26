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
                        ();
                        break;
                    case 3:
                        ();
                        break;
                    case 4:
                        ();
                        break;*/
                }
            }
        }

        static void Ex2()
        {
            var car1 = new Carro("Peugeot", "208", 2018, "57-XL-74");
            Console.WriteLine(car1);
            car1.LigarDesligar();
            car1.Acelarar();
            car1.Travar();
            car1.SubirMudanca();
            car1.Acelarar();
            car1.Acelarar();
            car1.Volante = Volante.Direita;
            car1.Acelarar();
            car1.SubirMudanca();
            car1.Acelarar();
            car1.Acelarar();
            car1.SubirMudanca();
            car1.SubirMudanca();
            car1.Acelarar();
            car1.SubirMudanca();
            car1.Acelarar();
            car1.Acelarar();
            car1.SubirMudanca();
            car1.Acelarar();
            car1.Acelarar();
            car1.DescerMudanca();
            car1.Acelarar();
            car1.DescerMudanca();
            car1.DescerMudanca();
            car1.DescerMudanca();
            car1.DescerMudanca();
            car1.Acelarar();
            car1.DescerMudanca();
            car1.Acelarar();
            car1.Travar();
            car1.Travar();
            car1.Travar();
            car1.Travar();
            car1.Volante = Volante.Centro;
            car1.Travar();
            car1.Travar();
            car1.Travar();
            car1.Volante = Volante.Esquerda;
            car1.Travar();
            car1.Travar();
            car1.Travar();
            car1.DescerMudanca();
            car1.Acelarar();
            car1.Acelarar();
            car1.LigarDesligar();
            car1.Acelarar();
            car1.Volante = Volante.Centro;
            car1.Travar();
            car1.Travar();

        }
    }

    public class Carro
    {
        /// <summary>
        /// Car constructer
        /// </summary>
        /// <param name="marca">Car Brand</param>
        /// <param name="modelo">Car Model</param>
        /// <param name="ano">Year of Construction</param>
        /// <param name="matricula">Number Plate</param>
        public Carro(string marca, string modelo, int ano, string matricula)
        {
            _marca = marca;
            _modelo = modelo;
            _ano = ano;
            _matricula = matricula;
            Ligado = false;
            _direcao = 0;
            Volante = 0;
        }
        
        string _marca;
        public string Marca { get=>_marca; }
        string _modelo;
        public string Modelo { get=>_modelo; }
        int _ano;
        public int Ano { get=>_ano; }
        string _matricula;
        public string Matricula { get=>_matricula; }
        public bool Ligado { get; set; }
        int _mudanca;
        public int Mudanca { get => _mudanca; set => _mudanca = (value >= -1 && value < 7) ? value : _mudanca; }
        double _velocidade;
        public double Velocidade { get=>_velocidade; }

        Direcao _direcao;
        public Volante Volante { get; set; }

        /// <summary>
        /// Displays the car's speed
        /// </summary>
        public void ShowSpeed()
        {
            Console.WriteLine($"Velocidade: {Math.Round(Velocidade,2)} Km/h");
        }

        /// <summary>
        /// Displays the direction the car is facing
        /// </summary>
        public void ShowDirection()
        {
            Console.WriteLine($"Direcção: {_direcao}");
        }

        /// <summary>
        /// Turns the car on or off
        /// </summary>
        public void LigarDesligar()
        {
            if (Ligado)
                Ligado = false;
            else
                Ligado = true;
        }

        /// <summary>
        /// raises the current gear
        /// </summary>
        public void SubirMudanca()
        {
            if (Mudanca == 6)
                Console.WriteLine("A mudança não pode subir mais!");
            else
                Mudanca++;
        }

        /// <summary>
        /// lowers the current gear
        /// </summary>
        public void DescerMudanca()
        {
            if (Mudanca == -1)
                Console.WriteLine("A mudança não pode descer mais!");
            else
                Mudanca--;
        }


        /// <summary>
        /// Breaks the car
        /// </summary>
        public void Travar()
        {
            if (Velocidade == 0)
                Console.WriteLine("O carro já está parado!");
            else if ((Velocidade < 5 && Velocidade > 0) || (Velocidade > -5 && Velocidade < 0))
                _velocidade = 0;
            else
                _velocidade *= 0.6;
            if (_velocidade != 0) MudarDirecao();
            ShowDirection();
            ShowSpeed();
        }

        /// <summary>
        /// Chages the direction the car is facing
        /// </summary>
        void MudarDirecao()
        {
            if (Velocidade>0)
            {
                switch (Volante)
                {
                    case Volante.Esquerda:
                        _direcao = (_direcao == Direcao.Sudoeste) ? Direcao.Sul : _direcao - 1;
                        break;
                    case Volante.Direita:
                        _direcao = (_direcao == Direcao.Sul) ? Direcao.Sudoeste : _direcao + 1;
                        break;
                }
            }
            else if (Velocidade < 0)
            {
                switch (Volante)
                {
                    case Volante.Esquerda:
                        _direcao = (_direcao == Direcao.Sul) ? Direcao.Sudoeste : _direcao + 1;
                        break;
                    case Volante.Direita:
                        _direcao = (_direcao == Direcao.Sudoeste) ? Direcao.Sul : _direcao - 1;
                        break;
                }
            }
        }

        /// <summary>
        /// Acelarates the car
        /// </summary>
        public void Acelarar()
        {
            if (!Ligado)
                Console.WriteLine("O carro está desligado!");
            else if (Mudanca==0)
                Console.WriteLine("Não tem uma Mudança engatada!");
            else if (Velocidade==0)
            {
                if (Mudanca > 1)
                {
                    Ligado = false;
                    Console.WriteLine("O carro foi a baixo");
                }
                else
                {
                    _velocidade = 5*Mudanca;
                }
            }
            else if (Velocidade<0)
            {
                if (Mudanca == -1)
                {
                    _velocidade *= 1.15;
                }
                else
                {
                    Ligado = false;
                    Console.WriteLine("O carro foi a baixo");
                }
            }
            else
            {
                switch (Mudanca)
                {
                    case -1:
                        Ligado = false;
                        Console.WriteLine("O carro foi a baixo");
                        break;
                    case 1:
                        _velocidade = (Velocidade < 5) ? _velocidade + 5 : _velocidade * 1.1;
                        break;
                    case 2: _velocidade *= 1.2; break;
                    case 3: _velocidade *= 1.35; break;
                    case 4: _velocidade *= 1.5; break;
                    case 5: _velocidade *= 1.65; break;
                    case 6: _velocidade *= 1.8; break;
                }
            }
            if (_velocidade != 0) MudarDirecao();
            ShowDirection();
            ShowSpeed();
        }

        public override string ToString()
        {
            string s=$"\n Marca: {_marca}";
            s+=$"\n Modelo: {_modelo}";
            s+=$"\n Matricula: {_matricula}";
            s+=$"\n Ano: {_ano}\n";
            return s;
        }
    }

    public enum Volante
    {
        Centro,
        Esquerda,
        Direita
    }

    public enum Direcao
    {
        Norte=0,
        Nordeste=1,
        Este=2,
        Sudeste=3,
        Sul=4,
        Sudoeste=-3,
        Oeste=-2,
        Noroeste=-1
    }
}
