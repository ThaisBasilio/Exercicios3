using System;

    class Atv05
    {
        static void Main()
        {
            int[] vetor = new int[10];
            int quantidadePares = 0;

            Console.WriteLine("Digite os 10 valores do vetor em números inteiros:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Posição {i}: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] % 2 == 0)
                {
                    quantidadePares++;
                }
            }

            Console.WriteLine($"O vetor possui {quantidadePares} valores pares.");
        }
    }
