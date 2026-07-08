using System;

  class Atv24
    { 
        static void Main()
        {
            int[] numero = new int[10];
            double[] altura = new double[10];
            
            Console.WriteLine("Cadastro dos alunos: ");
            for ( int i=0; i <10; i++)
            {
                Console.Write($"Digite o número do aluno {i + 1}: ");
                numero[i] = int.Parse(Console.ReadLine());

                Console.Write($"Digite a altura do aluno: ");
                altura[i] = double.Parse(Console.ReadLine());
            }
            double maiorAltura = altura[0];
            double menorAltura = altura[0];

            int alunoMaior = numero[0];
            int alunoMenor = numero[0];

            for(int i = 1; i < 10; i++)
            {
                if (altura[i] > maiorAltura){ maiorAltura = altura[i]; alunoMaior = numero[i];}
                if (altura[i] < menorAltura){ menorAltura = altura[i]; alunoMenor = numero[i];}
            }
            Console.WriteLine("\nAluno mais alto: ");
            Console.WriteLine($"Número: {alunoMaior}");
            Console.WriteLine($"Altura: {maiorAltura:F2} m");
            Console.WriteLine("\nAluno mais baixo: ");
            Console.WriteLine($"Número: {alunoMenor}");
            Console.WriteLine($"Altura: {menorAltura:F2} m");
        }
    }