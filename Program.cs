
using System;

class Program
{
    static void Adicao(int num1, int num2)
    {
        Console.WriteLine($"Resultado: {num1 + num2}");
    }

    static void Subtracao(int num1, int num2)
    {
        Console.WriteLine($"Resultado: {num1 - num2}");
    }

    static void Multiplicacao(int num1, int num2)
    {
        Console.WriteLine($"Resultado: {num1 * num2}");
    }

    static void Divisao(int num1, int num2)
    {
        if (num2 != 0)
        {
            Console.WriteLine($"Resultado: {num1 / (double)num2}");
        }
        else
        {
            Console.WriteLine("---- Nao pode dividir por zero. ----");
        }
    }

    static void Main()
    {
        bool terminar = false;

        while (!terminar)
        {
            int opcao = 0;
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("\nCalculadora");
            Console.WriteLine("1 - Adicao");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Multiplicacao");
            Console.WriteLine("4 - Divisao");
            Console.WriteLine("0 - Sair");

            Console.Write("Opcao: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao >= 1 && opcao <= 4)
            {
                Console.Write("Digite o primeiro numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o segundo numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Adicao(num1, num2);
                }
                else if (opcao == 2)
                {
                    Subtracao(num1, num2);
                }
                else if (opcao == 3)
                {
                    Multiplicacao(num1, num2);
                }
                else
                {
                    Divisao(num1, num2);
                }
            }
            else if (opcao == 0)
            {
                terminar = true;
            }
            else
            {
                Console.WriteLine("---- Opcao invalida. ----");
            }

            Console.WriteLine(" ");
        }

        Console.WriteLine("Fim!");
    }
}

