using System;
using System.Collections.Generic;

class Grafo
{
    private Dictionary<int, List<int>> listaAdjacencias = new Dictionary<int, List<int>>();

    public void AdicionarVertice(int vertice)
    {
        if (!listaAdjacencias.ContainsKey(vertice))
        {
            listaAdjacencias[vertice] = new List<int>();
        }
    }

    public void AdicionarAresta(int origem, int destino)
    {
        if (listaAdjacencias.ContainsKey(origem) && listaAdjacencias.ContainsKey(destino))
        {
            listaAdjacencias[origem].Add(destino);
        }
    }

    public void ExibirListaAdjacencia()
    {
        foreach (var vertice in listaAdjacencias)
        {
            Console.Write($"{vertice.Key}: ");
            Console.WriteLine(string.Join(", ", vertice.Value));
        }
    }
}

class Program
{
    static void Main()
    {
        Grafo grafo = new Grafo();

        // Adicionando vértices
        Console.WriteLine("Adicione vértices ao grafo. Insira -1 para encerrar.");
        int vertice;
        do
        {
            Console.Write("Vértice: ");
            vertice = int.Parse(Console.ReadLine());
            if (vertice != -1)
            {
                grafo.AdicionarVertice(vertice);
            }
        } while (vertice != -1);

        // Adicionando arestas
        Console.WriteLine("\nAdicione arestas ao grafo. Insira -1 para encerrar.");
        int origem, destino;
        do
        {
            Console.Write("Origem: ");
            origem = int.Parse(Console.ReadLine());
            if (origem == -1) break;

            Console.Write("Destino: ");
            destino = int.Parse(Console.ReadLine());
            if (destino != -1)
            {
                grafo.AdicionarAresta(origem, destino);
            }
        } while (true);

        // Exibindo a lista de adjacência
        Console.WriteLine("\nLista de Adjacência:");
        grafo.ExibirListaAdjacencia();
    }
}
