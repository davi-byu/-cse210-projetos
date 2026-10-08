using System;
using System.Collections.Generic;

class AtividadeDeListagem : Atividade
{
    private List<string> _perguntas = new List<string>
    {
        "Quem são pessoas que você admira?",
        "Quais são seus pontos fortes?",
        "Quais são seus objetivos para o futuro?",
        "Quais são coisas pelas quais você é grato?",
        "Quais são atividades que fazem você feliz?",
        "Quais são coisas que você gostaria de aprender?",
        "Quais são maneiras de ajudar outras pessoas?"
    };

    public AtividadeDeListagem(string nome, string descricao, int duracao)
        : base(nome, descricao, duracao)
    {
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        Random random = new Random();

        string pergunta = _perguntas[random.Next(_perguntas.Count)];

        Console.WriteLine();
        Console.WriteLine("Pense na seguinte pergunta:");
        Console.WriteLine();
        Console.WriteLine($"--- {pergunta} ---");
        Console.WriteLine();

        Console.WriteLine("Quando estiver pronto, pressione ENTER.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Começando...");
        Thread.Sleep(3000);

        List<string> respostas = new List<string>();

        int duracao = ObterDuracao();

        DateTime horaFinal = DateTime.Now.AddSeconds(duracao);

        while (DateTime.Now < horaFinal)
        {
            Console.Write("> ");

            string resposta = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(resposta))
            {
                respostas.Add(resposta);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Você listou {respostas.Count} itens.");

        ExibirMensagemFinal();
    }
}