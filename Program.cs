namespace Atividade07
{
    class Program
    {
        static string opcao;
        static int[] valores;
        static int maiorValor;
        static int menorValor;
        static int valorMedio;
        static int[] ValoresSortidos;
        static string valoresNegativos;

        static void Main(string[] args)
        {
            valores = new int[10];
            ValoresSortidos = new int[10];

            //começar a primeira vez inputando
            opcao = "0";


            while (true)
            {
                Console.Clear();

                InputDosValores();

                MostrarMenu();

                InputDosValores();

                EncontrarOMaiorValor();

                EncontrarOMenorValor();

                EncontrarOValorMedio();

                EncontrarOsTresMaioresValores();

                EncontrarOsValoresNegativos();

                MostrarValores();

                RemoverUmItem();

                if (opcao == "S" || opcao == "s")
                {
                    break;
                }

                //não reiniciar inputando
                opcao = "-1";

                Console.ReadLine();
            }
        }
        static void InputDosValores()
        {
            if (opcao == "0")
            {
                Console.WriteLine("Digite 10 valores inteiros");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}° Valor");
                    valores[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("(0) - Redefinir os valores");
            Console.WriteLine("(1) - Mostrar o maior valor");
            Console.WriteLine("(2) - Mostrar o menor valor");
            Console.WriteLine("(3) - Mostrar o valor médio");
            Console.WriteLine("(4) - Mostrar os três maiores valores");
            Console.WriteLine("(5) - Mostrar os valores negativos");
            Console.WriteLine("(6) - Mostrar valores");
            Console.WriteLine("(7) - Apagar um valor");

            Console.WriteLine("\n(S) - Sair");

            opcao = Console.ReadLine();
        }

        static void EncontrarOMaiorValor()
        {
            if (opcao == "1")
            {
                maiorValor = valores[0];
                for (int i = 0; i < 10; i++)
                {
                    if (maiorValor < valores[i])
                    {
                        maiorValor = valores[i];
                    }
                }
                Console.WriteLine("O maior valor é " + maiorValor);
            }
        }

        static void EncontrarOMenorValor()
        {
            if (opcao == "2")
            {
                menorValor = valores[0];
                for (int i = 0; i < 10; i++)
                {
                    if (menorValor > valores[i])
                    {
                        menorValor = valores[i];
                    }
                }
                Console.WriteLine("O menor valor é " + menorValor);
            }
        }

        static void EncontrarOValorMedio()
        {
            if (opcao == "3")
            {
                for (int i = 0; i < 10; i++)
                {

                    valorMedio = valorMedio + valores[i];
                }
                valorMedio = valorMedio / 10;

                Console.WriteLine("O valor Medio é " + valorMedio);
            }
        }

        static void EncontrarOsTresMaioresValores()
        {
            if (opcao == "4")
            {
                Array.Sort(valores);
                Console.Write($"Os 3 maiores valores são: {valores[9]}, {valores[8]}, {valores[7]}");

            }
        }

        static void EncontrarOsValoresNegativos()
        {
            if (opcao == "5")
            {
                valoresNegativos = Convert.ToString(valores[0]);
                for (int i = 1; i < 10; i++)
                {
                    if (valores[i] < 0)
                    {
                        valoresNegativos = valoresNegativos + ", " + valores[i];
                    }

                }
                Console.WriteLine("Os valores negativos são: " + valoresNegativos);
            }
        }

        static void MostrarValores()
        {
            if (opcao == "6")
            {
                Console.Write(valores[0]);
                for (int i = 1; i < 10; i++)
                {
                    if (valores[i] != 0)
                    {
                        Console.Write(", " + valores[i]);
                    }
                }

            }
        }

        static void RemoverUmItem()
        {
            if (opcao == "7")
            {
                Console.WriteLine("Qual a posição do item que será removido? (de 0 até 9)");
                int remover = Convert.ToInt32(Console.ReadLine());
                valores[remover] = 0;
            }
        }

    }
}
