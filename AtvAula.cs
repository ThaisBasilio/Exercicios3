using System;
  class AtvAula
    { 
        static void Main()
        {
            int[] vetor = new int[30];
            Console.WriteLine("Digite um número inteiro: ");

            for(int i=0; i<30; i++)
            {
                Console.WriteLine($"Posição {i}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nFrequencia dos Numeros: ");
            for (int i=0; i<30; i++)
            {
                int frequencia = 0;
                for(int j=0; j<30; j++)
                { 
                    if (vetor[i] == vetor[j])
                    {frequencia++;}
                }
            Console.WriteLine($"O número  {vetor[i]} aparece {frequencia} vezes.");
            }
        }
    }