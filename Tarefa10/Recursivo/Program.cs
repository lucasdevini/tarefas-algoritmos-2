using System;
using System.Diagnostics;

public class HelloWorld
{
    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho do array (10 ou 100): ");
        int arraySize = int.Parse(Console.ReadLine());

        Console.Write("Procurar no array: ");
        int x = int.Parse(Console.ReadLine());

        int n = arraySize;
        int[] vetor = new int[n];

        for (int i = 0; i < n; i++)
        {
            vetor[i] = i + 1;
        }

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        DecideR(vetor, n, x, 0);

        stopwatch.Stop();
        TimeSpan elapsedTime = stopwatch.Elapsed;

        Console.WriteLine($"Tempo de execução: {elapsedTime.TotalMilliseconds} ms");
    }

    static void DecideR(int[] A, int n, int x, int pos)
    {
        if (pos == n)
        {
            Console.WriteLine("O número digitado não está contido no array");
            return;
        }

        if (A[pos] == x)
        {
            Console.WriteLine($"Sim, encontrado na posição {pos}");
            return;
        }

        Console.WriteLine($"Verificando posição {pos}: Não encontrado ainda");
        DecideR(A, n, x, pos + 1);
    }
}