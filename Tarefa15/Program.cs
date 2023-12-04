using System;

class Program
{
    const int Maxn = 10;

    static void Main()
    {
        int i, j, k, h, n, temp;
        int[] b = new int[Maxn + 1];
        int[,] m = new int[Maxn, Maxn];

        Console.Write("Numero de matrizes n: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Dimensoes das matrizes: ");
        for (i = 0; i <= n; i++)
        {
            b[i] = int.Parse(Console.ReadLine());
        }

        for (i = 0; i < n; i++)
        {
            m[i, i] = 0;
        }

        for (h = 1; h <= n - 1; h++)
        {
            for (i = 1; i <= n - h; i++)
            {
                j = i + h;
                m[i - 1, j - 1] = int.MaxValue;

                for (k = i; k <= j - 1; k++)
                {
                    temp = m[i - 1, k - 1] + m[k, j - 1] + b[i - 1] * b[k] * b[j];

                    if (temp < m[i - 1, j - 1])
                    {
                        m[i - 1, j - 1] = temp;
                    }
                }

                Console.WriteLine($"m[{i - 1}][{j - 1}] = {m[i - 1, j - 1]}");
            }

            Console.WriteLine();
        }
    }
}
