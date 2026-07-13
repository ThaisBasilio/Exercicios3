using System;

class Aluno
{
    public int matricula;
    public string nome;
    public double notaProva1;
    public double notaProva2;
    public double notaTrabalho;

    public Aluno(int matricula, string nome, double notaProva1, double notaProva2, double notaTrabalho)
    {
        this.matricula = matricula;
        this.nome = nome;
        this.notaProva1 = notaProva1;
        this.notaProva2 = notaProva2;
        this.notaTrabalho = notaTrabalho;
    }

    public double CalcularMedia()
    {
        double media = (notaProva1 * 2.5 + notaProva2 * 2.5 + notaTrabalho * 2.0) / 7.0;
        return media;
    }

    public double CalcularNotaFinal()
    {
        double media = CalcularMedia();
        if (media >= 6)
        {
            return 0;
        }
        double notaFinal = 10 - media;
        if (notaFinal > 10)
        {
            notaFinal  = 10;
        }
        return notaFinal;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Matrícula: ");
        int matricula = int.Parse(Console.ReadLine());
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Nota da Prova 1: ");
        double p1 = double.Parse(Console.ReadLine());
        Console.Write("Nota da Prova 2: ");
        double p2 = double.Parse(Console.ReadLine());
        Console.Write("Nota do Trabalho: ");
        double trabalho = double.Parse(Console.ReadLine());

        Aluno aluno = new Aluno(matricula, nome, p1, p2, trabalho);
        Console.WriteLine("\nDados do Aluno");

        Console.WriteLine("Matrícula: " + aluno.matricula);
        Console.WriteLine("Nome: " + aluno.nome);
        Console.WriteLine("Média: " + aluno.CalcularMedia().ToString("F2"));

        double notaFinal = aluno.CalcularNotaFinal();
        if (notaFinal == 0)
        {
            Console.WriteLine("Aluno aprovado sem prova final.");
        }
        else 
        {
            Console.WriteLine("Necessita de " + notaFinal.ToString("F2") + " na prova final.");
        }
    }
}