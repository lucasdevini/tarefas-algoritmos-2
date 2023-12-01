using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Menu();
        int opcao = int.Parse(Console.ReadLine());

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Switch(opcao);

        stopwatch.Stop();
        Console.WriteLine($"Tempo de execução: {stopwatch.Elapsed.TotalMilliseconds} ms");
    }

    static void Menu()
    {
        Console.WriteLine("Selecione uma das opções abaixo: ");
        Console.WriteLine("n = 100 e F(0) = 1 - [1]");
        Console.WriteLine("n = 100 e F(0) = 10 - [2]");
        Console.WriteLine("n = 1000 e F(0) = 1 - [3]");
        Console.WriteLine("n = 1000 e F(0) = 10 - [4]");
        Console.Write("Opção: ");
    }

    static void Switch(int opcao)
    {
        Console.WriteLine();

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Resultado: " + CalcularF(1, 100));
                break;
            case 2:
                Console.WriteLine("Resultado: " + CalcularF(10, 100));
                break;
            case 3:
                Console.WriteLine("Resultado: " + CalcularF(1, 1000));
                break;
            case 4:
                Console.WriteLine("Resultado: " + CalcularF(10, 1000));
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

    // Função com recorrência para calcular F(n)
    static int CalcularF(int f0, int n)
    {
        return f0 + (n * (n - 1) / 2) + n;
    }
}
