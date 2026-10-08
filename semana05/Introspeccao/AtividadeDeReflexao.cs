using System;
using System.Collections.Generic;
using System.Threading;

class AtividadeDeReflexao : Atividade
{
    private List<string> _prompts = new List<string>
    {
        "Pense em uma ocasião em que você superou um desafio.",
        "Pense em uma ocasião em que você ajudou alguém.",
        "Pense em uma ocasião em que alguém ajudou você.",
        "Pense em uma ocasião em que você aprendeu algo importante.",
        "Pense em uma ocasião em que você alcançou um objetivo.",
        "Pense em uma ocasião em que você demonstrou coragem."
    };

    private List<List<string>> _perguntas = new List<List<string>>
    {
        // Superar um desafio
        new List<string>
        {
            "O que aconteceu nessa situação?",
            "Como você se sentiu enquanto enfrentava esse desafio?",
            "O que você aprendeu sobre si mesmo?",
            "Como esse aprendizado pode ajudar você em um próximo desafio?"
        },

        // Ajudar alguém
        new List<string>
        {
            "O que aconteceu e como você ajudou essa pessoa?",
            "O que motivou você a ajudá-la?",
            "Como você se sentiu depois de ajudar?",
            "O que essa experiência ensinou a você sobre ajudar outras pessoas?"
        },

        // Receber ajuda
        new List<string>
        {
            "O que aconteceu e quem ajudou você?",
            "Como você se sentiu ao receber essa ajuda?",
            "O que você aprendeu com essa experiência?",
            "Como você pode usar essa experiência para ajudar outra pessoa?"
        },

        // Aprender algo importante
        new List<string>
        {
            "O que aconteceu quando você aprendeu essa coisa nova?",
            "Como você se sentiu durante esse aprendizado?",
            "Por que esse aprendizado foi importante para você?",
            "Como você pode usar esse conhecimento no futuro?"
        },

        // Alcançar um objetivo
        new List<string>
        {
            "Qual objetivo você conseguiu alcançar?",
            "O que você precisou fazer para chegar até ele?",
            "Como você se sentiu quando conseguiu?",
            "O que essa conquista ensina sobre seus próximos objetivos?"
        },

        // Demonstrar coragem
        new List<string>
        {
            "Em qual situação você precisou demonstrar coragem?",
            "Como você se sentiu antes de tomar essa atitude?",
            "O que aconteceu depois que você tomou essa decisão?",
            "O que essa experiência ensinou sobre sua própria coragem?"
        }
    };

    public AtividadeDeReflexao(string nome, string descricao, int duracao)
        : base(nome, descricao, duracao)
    {
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        Random random = new Random();

        // Escolhe uma situação aleatória.
        int indice = random.Next(_prompts.Count);

        string prompt = _prompts[indice];

        // Pega as perguntas relacionadas à situação escolhida.
        List<string> perguntas = _perguntas[indice];

        Console.WriteLine();
        Console.WriteLine("REFLEXÃO");
        Console.WriteLine();
        Console.WriteLine("Leia a situação abaixo e pense em uma experiência da sua vida.");
        Console.WriteLine();

        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();
        Console.WriteLine("Quando estiver pronto, pressione ENTER.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Começando sua reflexão...");
        Thread.Sleep(3000);

        int duracao = ObterDuracao();

        // Temos quatro etapas de reflexão.
        int tempoPorPergunta = duracao / 4;

        // Garante pelo menos 1 segundo para cada pergunta.
        if (tempoPorPergunta < 1)
        {
            tempoPorPergunta = 1;
        }

        string[] etapas =
        {
            "RELEMBRAR",
            "SENTIR",
            "APRENDER",
            "APLICAR"
        };

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"--- {etapas[i]} ---");
            Console.WriteLine();
            Console.WriteLine(perguntas[i]);
            Console.WriteLine();

            ExibirContagemRegressiva(tempoPorPergunta);
        }

        ExibirMensagemFinal();
    }
}