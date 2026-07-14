using System;

class Data
{
    private int dia;
    private int mes;
    private int ano;

    public Data(int dia, int mes, int ano)
    {
        if (DataValida(dia, mes, ano))
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
        else
        {
            this.dia = 1;
            this.mes = 1;
            this.ano = 1;
        }
    }

    private bool DataValida(int dia, int mes, int ano)
    {
        if (mes < 1 || mes > 12)
            return false;

        int[] diasMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if ((ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0))
        {
            diasMes[1] = 29;
        }

        if (dia < 1 || dia > diasMes[mes - 1])
            return false;

        return true;
    }

    public int GetDia()
    {
        return dia;
    }

    public int GetMes()
    {
        return mes;
    }

    public int GetAno()
    {
        return ano;
    }

    public string GetMesExtenso()
    {
        string[] meses =
        {
            "Janeiro","Fevereiro","Março","Abril",
            "Maio","Junho","Julho","Agosto",
            "Setembro","Outubro","Novembro","Dezembro"
        };

        return meses[mes - 1];
    }

    public bool IsBissexto()
    {
        if ((ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0))
            return true;

        return false;
    }

    public int Compara(Data outraData)
    {
        if (ano > outraData.ano)
            return 1;

        if (ano < outraData.ano)
            return -1;

        if (mes > outraData.mes)
            return 1;

        if (mes < outraData.mes)
            return -1;

        if (dia > outraData.dia)
            return 1;

        if (dia < outraData.dia)
            return -1;

        return 0;
    }

    public Data Clone()
    {
        return new Data(dia, mes, ano);
    }
}

class Program
{
    static void Main()
    {
        Data data1 = new Data(25, 12, 2025);
        Data data2 = new Data(1, 1, 2026);

        Console.WriteLine("Data 1:");
        Console.WriteLine(data1.GetDia() + "/" + data1.GetMes() + "/" + data1.GetAno());

        Console.WriteLine("Mês: " + data1.GetMesExtenso());

        Console.WriteLine("Ano bissexto? " + data1.IsBissexto());

        Console.WriteLine("Comparação: " + data1.Compara(data2));

        Data copia = data1.Clone();

        Console.WriteLine("Clone:");
        Console.WriteLine(copia.GetDia() + "/" + copia.GetMes() + "/" + copia.GetAno());
    }
}