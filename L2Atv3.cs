using System;

class L2Atv3
{
    static void Main()
    {
       int[,] matriz = new int[4, 5];
       Console.WriteLine("Digite os valores da matriz");

       for (int i = 0; i < matriz.GetLength(0); i++)
       {
         for (int j = 0; j < matriz.GetLength(1); j++)
         {
            Console.Write($"Elemento [{i}, {j}]: ");
            matriz[i, j] = int.Parse(Console.ReadLine());
         }
       }

       Console.WriteLine("\nOcorrência dos Elementos: ");
       for(int i = 0; i < matriz.GetLength(0); i++)
       {
         for (int j =0; j < matriz.GetLength(1); j++)
         {
            int frequencia = 0;
            bool jaMostrado = false;

            for (int x = 0; x < matriz.GetLength(0); x++)
            {
             for(int y = 0; y < matriz.GetLength(1); y++)
             {
                if (x == i && y == j) {break;}
                if (matriz[x, y] == matriz[i, j]) {jaMostrado = true;}
             }
             if (jaMostrado) {break;}
            }
            if (!jaMostrado)
            {
                for(int x = 0; x < matriz.GetLength(0); x++)
                {
                    for (int y = 0; y < matriz.GetLength(1); y++)
                    {
                        if (matriz[x, y] == matriz[i, j])
                        {frequencia++;}
                    }
                }
                Console.WriteLine($"O número {matriz[i, j]} aparece {frequencia} vezes.");
            }
         }
       }
    }
}