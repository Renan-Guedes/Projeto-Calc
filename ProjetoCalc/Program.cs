using System;

namespace ProjetoCalc
{
    internal class Program
    {

        enum Menu { Soma = 1, Subtracao, Multiplicacao, Divisao, Potencia, Raiz, Sair };

        static void Main(string[] args)
        {

            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Bem vindo(a) ao projeto CALC, desenvolvido por Renan Guedes. Escolha uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n5-Potência\n6-Raiz\n7-Sair");
                Menu Opcao = (Menu)int.Parse(Console.ReadLine());

                switch (Opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtracao:
                        Subtracao();
                        break;

                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;

                    case Menu.Divisao:
                        Divisao();
                        break;

                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                
                Console.Clear();

            }
         
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números: ");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois números:");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois números:");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisão de dois números:");
            Console.Write("Digite o primeiro número: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            float b = float.Parse(Console.ReadLine());
            float resultado = a / b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Potência de um número:");
            Console.Write("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum,expoente);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de um número:");
            Console.Write("Digite um número: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
    }
}
