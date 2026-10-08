using System;

class AtividadeDeRespiracao : Atividade
{
    public AtividadeDeRespiracao(string nome, string descricao, int duracao)
        : base(nome, descricao, duracao)
    {
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        int duracao = ObterDuracao();

        DateTime horaFinal = DateTime.Now.AddSeconds(duracao);

        while (DateTime.Now < horaFinal)
        {
            Console.WriteLine();
            Console.WriteLine("Inspire...");
            ExibirContagemRegressiva(3);

            Console.WriteLine();
            Console.WriteLine("Expire...");
            ExibirContagemRegressiva(3);
        }

        ExibirMensagemFinal();
    }
}