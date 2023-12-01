using System;
using System.Diagnostics;

public class Fibonacci
{
    public static long FibIterativo(int n)
    {
        long atual = 0, ultimo = 0, penultimo = 1;

        for (int i = 1; i <= n; i++)
        {
            atual = ultimo + penultimo;
            penultimo = ultimo;
            ultimo = atual;
        }

        return atual;
    }

    public static void Main()
    {
        Console.Write("Digite o valor de n: ");

        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long resultado = FibIterativo(userInput);

            stopwatch.Stop();

            Console.WriteLine($"O {userInput}-ésimo termo na sequência Fibonacci é: {resultado}");
            Console.WriteLine($"Tempo de execução: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }
        else
        {
            Console.WriteLine("Por favor, insira um valor inteiro válido.");
        }
    }
}
