using System;
using System.Threading;

class Atividade
{
    private string _nome;
    private string _descricao;
    private int _duracao;

    public Atividade(string nome, string descricao, int duracao)
    {
        _nome = nome;
        _descricao = descricao;
        _duracao = duracao;
    }

    public void ExibirMensagemInicial()
    {
        Console.WriteLine($"Bem-vindo à atividade {_nome}.");
        Console.WriteLine();
        Console.WriteLine(_descricao);
        Console.WriteLine();
        Console.WriteLine("Quanto tempo, em segundos, você deseja para essa atividade?");

        _duracao = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Prepare-se...");
        Thread.Sleep(3000);
    }

    public void ExibirMensagemFinal()
    {
        Console.WriteLine();
        Console.WriteLine("Muito bem!");
        Thread.Sleep(2000);

        Console.WriteLine($"Você concluiu a atividade {_nome}.");
        Console.WriteLine($"Duração: {_duracao} segundos.");

        Thread.Sleep(3000);
    }

    public void ExibirContagemRegressiva(int segundos)
    {
        for (int i = segundos; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }

    public int ObterDuracao()
    {
        return _duracao;
    }
}