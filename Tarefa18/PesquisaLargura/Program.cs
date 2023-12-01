using System;
using System.Collections.Generic;

class Program
{
    static int[] num;
    static int[] pa;

    static void Main()
    {
        // Grafo dado pelos arcos
        Graph G1 = new Graph(12);
        G1.AddEdge(0, 1);
        G1.AddEdge(1, 2);
        G1.AddEdge(1, 3);
        G1.AddEdge(3, 4);
        G1.AddEdge(3, 5);
        G1.AddEdge(1, 6);
        G1.AddEdge(0, 7);
        G1.AddEdge(7, 8);
        G1.AddEdge(7, 9);
        G1.AddEdge(8, 6);

        // Grafo dado pela lista de adjacência
        Graph G2 = new Graph(12);
        G2.AddEdge(0, 1);
        G2.AddEdge(0, 4);
        G2.AddEdge(1, 2);
        G2.AddEdge(1, 5);
        G2.AddEdge(2, 3);
        G2.AddEdge(3, 7);
        G2.AddEdge(4, 8);
        G2.AddEdge(5, 4);
        G2.AddEdge(6, 5);
        G2.AddEdge(6, 10);
        G2.AddEdge(6, 2);
        G2.AddEdge(7, 11);
        G2.AddEdge(7, 6);
        G2.AddEdge(8, 9);
        G2.AddEdge(9, 5);
        G2.AddEdge(9, 8);
        G2.AddEdge(10, 9);
        G2.AddEdge(11, 10);

        // Inicialização das variáveis globais
        num = new int[12];
        pa = new int[12];

        Console.WriteLine("Escolha o grafo a percorrer (1 para o primeiro grafo, 2 para o segundo):");
        int escolha = int.Parse(Console.ReadLine());

        if (escolha == 1)
        {
            Console.WriteLine("\nRastreamento para o primeiro grafo:");
            GRAPHbfs(G1, 0);
        }
        else if (escolha == 2)
        {
            Console.WriteLine("\nRastreamento para o segundo grafo:");
            GRAPHbfs(G2, 0);
        }
        else
        {
            Console.WriteLine("Escolha inválida. Encerrando o programa.");
        }
    }

    static void GRAPHbfs(Graph G, int s)
    {
        int cnt = 0;

        for (int v = 0; v < G.V; ++v)
        {
            num[v] = pa[v] = -1;
        }

        Queue<int> queue = new Queue<int>();
        num[s] = cnt++;
        pa[s] = s;
        queue.Enqueue(s);

        while (queue.Count > 0)
        {
            int v = queue.Dequeue();

            Console.WriteLine($"Visitando vértice {v}");

            foreach (int w in G.adj[v])
            {
                if (num[w] == -1)
                {
                    num[w] = cnt++;
                    pa[w] = v;
                    queue.Enqueue(w);
                    Console.WriteLine($"Descoberto vértice {w}, pai = {v}");
                }
            }
        }
    }
}

class Graph
{
    public int V { get; }
    public List<int>[] adj;

    public Graph(int V)
    {
        this.V = V;
        adj = new List<int>[V];
        for (int i = 0; i < V; ++i)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }
}
