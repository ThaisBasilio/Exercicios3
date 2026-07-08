using System;

  class Atv06
    { 
        static void Main()
        {
            int[] vetor = new int[10];
            Console.WriteLine("Digite 10 valores inteiros do vetor: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Posição: {i}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            int maior = vetor[0];
            int menor = vetor[0];
            for (int i = 1; i < 10; i++)
            {
                if (vetor[i] > maior) {maior = vetor[i];}
                if (vetor[i] < menor) {menor = vetor[i];}
            }
            Console.WriteLine($"Maior valor: {maior}");
            Console.WriteLine($"Menor valor: {menor}");
        }
    }