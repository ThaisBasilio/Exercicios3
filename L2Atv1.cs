using System;

class L2Atv1
{
    static void Main()
    {
        int[,] matriz = new int[10, 20];

        Console.WriteLine("Digite os valores da matriz:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // A) O maior elemento de cada linha da matriz;
        Console.WriteLine("\nMaior elemento de cada linha:");

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int maior = matriz[i, 0];

            for (int j = 1; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                }
            }

            Console.WriteLine($"Linha {i}: {maior}");
        }

        // B) A média dos elementos de cada coluna;
        Console.WriteLine("\nMédia de cada coluna:");

        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            int soma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                soma += matriz[i, j];
            }

            double media = (double)soma / matriz.GetLength(0);

            Console.WriteLine($"Coluna {j}: {media:F2}");
        }

        // C) O produto de todos os elementos diferentes de zero;
        long produto = 1;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] != 0)
                {
                    produto *= matriz[i, j];
                }
            }
        }

        Console.WriteLine($"\nProduto dos elementos diferentes de zero: {produto}");

        // D) Posição ocupada (linha-coluna) por um elemento cujo valor será lido pelo programa.
        Console.Write("\nDigite um valor para procurar: ");
        int valor = int.Parse(Console.ReadLine());

        bool encontrou = false;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == valor)
                {
                    Console.WriteLine($"Valor encontrado na linha {i} e coluna {j}");
                    encontrou = true;
                }
            }
        }

        if (encontrou == false)
        {
            Console.WriteLine("Valor não encontrado.");
        }
    }
}