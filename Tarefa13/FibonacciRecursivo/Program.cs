class Program
{
    static long Fib(int n)
    {
        if (n < 2)
            return n;
        else
            return Fib(n - 1) + Fib(n - 2);
    }

    static void Main()
    {
        Console.Write("Digite o valor de n: ");

        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            DateTime startTime = DateTime.Now;
            long resultado = Fib(userInput);
            DateTime endTime = DateTime.Now;

            TimeSpan executionTime = endTime - startTime;

            Console.WriteLine($"O {userInput}-ésimo termo na sequência Fibonacci é: {resultado}");
            Console.WriteLine($"Tempo de execução: {executionTime.TotalMilliseconds:F3} ms");
        }
        else
        {
            Console.WriteLine("Por favor, insira um valor inteiro válido.");
        }
    }
}
