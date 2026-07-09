using System;

class L2Atv2
{
    static void Main()
    {
       int[,] matriz = new int[3, 3];
       Console.WriteLine("'Digite os valores da matriz: ");

       for(int i = 0; i < matriz.GetLength(0); i++)
       {
        for(int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write($"Elemento [{i}, {j}]: ");
            matriz[i, j] = int.Parse(Console.ReadLine());
        }
       }

       Console.WriteLine("\nMatriz: ");
       for(int i = 0; i < matriz.GetLength(0); i++)
       {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i, j] + "\t");
        }
        Console.WriteLine();
       }
       int minimax = int.MaxValue;
       for (int i = 0; i < matriz.GetLength(0); i++)
       {
        int maiorLinha = matriz[i, 0];
        for (int j = 1; j < matriz.GetLength(1); j++)
        {
            if (matriz[i, j] > maiorLinha)
            { maiorLinha = matriz[i, j];}
        }
        if (maiorLinha < minimax)
        { minimax = maiorLinha;}
       }
       Console.WriteLine($"\nElemento minimax: {minimax}");
    }
}