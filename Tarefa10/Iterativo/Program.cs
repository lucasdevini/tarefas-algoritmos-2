class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de itens do array (10 ou 100): ");
        int tamanhoArray;

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out tamanhoArray) && (tamanhoArray == 10 || tamanhoArray == 100))
            {
                break;
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor válido (10 ou 100).");
            }
        }

        // Inicialização do array A com valores fictícios para fins de exemplo
        int[] A = new int[tamanhoArray];
        for (int i = 0; i < tamanhoArray; i++)
        {
            A[i] = i + 1; // Preencha com os valores reais do seu problema
        }

        Console.WriteLine("Digite o valor de x a ser procurado: ");
        int x = int.Parse(Console.ReadLine());

        // Adicionando cronômetro para medir o tempo de execução
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();

        // Chamando a função Decide-I
        bool resultado = DecideI(A, tamanhoArray, x);

        stopwatch.Stop();
        TimeSpan tempoExecucao = stopwatch.Elapsed;

        // Exibindo resultados
        Console.WriteLine($"Resultado da busca: {(resultado ? "SIM" : "NÃO")}");
        Console.WriteLine($"Tempo de execução: {tempoExecucao.TotalMilliseconds} milissegundos");
    }

    static bool DecideI(int[] A, int n, int x)
    {
        int i = 1;

        while (i <= n && A[i - 1] != x)
        {
            // Exibindo resultados parciais
            Console.WriteLine($"Passo {i}: Elemento {A[i - 1]}");

            i++;
        }

        if (i > n)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
