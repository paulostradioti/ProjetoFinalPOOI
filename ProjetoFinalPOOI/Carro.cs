﻿namespace ProjetoFinalPOOI
{
    public class Carro
    {
        public string Placa { get; }
        public string Categoria { get; }
        public int ValorCategoria;
        public const int a = 60;
        public const int b = 70;
        public const int c = 80;
        public int Ano { get; }
        public long Km { get; }
        public string Modelo { get; }
        public bool alugado { get; }


        public Carro(string placa, string categoria, int ano, long km, string modelo, bool alugado)

        {
            Placa = placa;
            Categoria = AtribuiValorCategoria(categoria);
            //ValorCategoria = valorCategoria;
            Ano = ano;
            Km = km;
            Modelo = modelo;
            alugado = alugado;

        }

        public string AtribuiValorCategoria(string categoria)
        {
            if (categoria == "A")
            {
                ValorCategoria = a;
            }
            else if (categoria == "B")
            {
                ValorCategoria = b;
            }
            else if (categoria == "C")
            {
                ValorCategoria = c;
            }
            else
            {
                ValorCategoria = 0;//Para destacar erro
            }
            return categoria;
        }

        public static Carro Ler(List <string> testeplacas)
        {
            string placa = LerPlaca(testeplacas);
            string categoria = LerCategoria();
            int ano = LerAno();
            long km = LerKm();
            string modelo = LerModelo();
            bool alugado = false;

            return new Carro(placa, categoria, ano, km, modelo, alugado);
        }

        public static string LerPlaca(List <string> testeplacas)
        {
            string valor = "";
            bool valida = true;
            int numericValue = 0;
            int n = 0;
            do
            {
                valida = true;
                Console.Write("Insira a placa do novo veículo (XXX0000): ");
                valor = Console.ReadLine();

                

                if (valor.Length != 7)
                {
                    Console.WriteLine("Placa inválida.");
                    valida = false;
 
                }

                else
                {
                    foreach (var veiculo in testeplacas)
                    {
                        if (veiculo.ToUpper() == valor.ToUpper())
                        {
                            Console.WriteLine($"Placa ({valor.ToUpper()}) já existente no sistema.");
                            valida = false;
                            break;
                        }
                    }

                    char[] palavra = valor.ToCharArray();

                    for (int i = 0; i < 3; i++)
                    {
                        if (char.IsDigit(palavra[i]))
                        {
                            Console.WriteLine($"Letra {palavra[i]} na posição {i + 1} inválida.");
                            valida = false;
                        }
                    }
                    for (int i = 3; i < 7; i++)
                    {
                        if (!char.IsDigit(palavra[i]))
                        {
                            Console.WriteLine($"Número {palavra[i]} na posição {i + 1} inválido.");
                            valida = false;
                        }
                    }
                }

            } while (!valida);
            return valor;
        }
        public static string LerCategoria()
        {
            string valor = "";
            bool valida = true;

            do
            {
                valida = true;

                Console.Write("Insira a categoria do carro (A,B,C): ");
                valor = Console.ReadLine();

                if (valor.ToUpper() != "A" && valor.ToUpper() != "B" && valor.ToUpper() != "C")
                {
                    valida = false;
                    Console.WriteLine("Insira uma categoria válida.");
                }

            } while (!valida);

            return valor;
        }

        public static int LerAno()
        {
            int valor = 0;
            bool valida = true;

            do
            {
                valida = true;

                Console.Write("Insira o ano do veículo (mais novo do que 2019): ");
                valida = int.TryParse(Console.ReadLine(), out valor);

            } while (!valida && valor < 2020);


            return valor;
        }

        public static long LerKm()
        {
            long valor = 0;
            bool valida = true;

            do
            {
                valida = true;

                Console.Write("Insira a quilometragem do veículo: ");
                valida = long.TryParse(Console.ReadLine(), out valor);

            } while (!valida && valor<0);


            return valor;
        }

        public static string LerModelo()
        {
            string valor = "";
            string[] palavra;

            do
            {
                Console.Write("Insira o modelo do veículo: ");
                valor = Console.ReadLine();

            } while (valor == "");


            return valor;
        }
        public void DadosV()
        {
            Console.WriteLine("Dados do Carro:");
            Console.WriteLine("Placa: " + Placa);
            Console.WriteLine("Categoria: " + Categoria);
            Console.WriteLine("Valor da Categoria" + ValorCategoria);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Kilometragem: " + Km);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Alugado: " + (alugado ? "Sim" : "Não"));

        }



    }

}
