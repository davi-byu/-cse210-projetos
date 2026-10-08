// MELHORIA CRIATIVA:
// Na atividade de reflexão, além dos requisitos básicos,
// organizei as perguntas em quatro etapas:
// RELEMBRAR, SENTIR, APRENDER e APLICAR.
//
// Essa sequência ajuda o usuário a refletir de maneira
// mais organizada, começando pela experiência,
// passando pelos sentimentos, identificando o aprendizado
// e terminando com uma aplicação para o futuro.



using System;

class Program
{
    static void Main(string[] args)
    {
        int escolha = 0;

        while (escolha != 4)
        {
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("      MENU DE ATIVIDADES");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Atividade de Respiração");
            Console.WriteLine("2. Atividade de Reflexão");
            Console.WriteLine("3. Atividade de Listagem");
            Console.WriteLine("4. Sair");
            Console.WriteLine("=================================");
            Console.WriteLine();

            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out escolha))
            {
                Console.WriteLine();
                Console.WriteLine("Opção inválida.");
                Console.WriteLine("Pressione ENTER para continuar.");
                Console.ReadLine();
                continue;
            }

            Console.WriteLine();

            if (escolha == 1)
            {
                AtividadeDeRespiracao atividade = new AtividadeDeRespiracao(
                    "Respiração",
                    "Esta atividade ajudará você a relaxar através da respiração.",
                    0
                );

                atividade.Executar();
            }
            else if (escolha == 2)
            {
                AtividadeDeReflexao atividade = new AtividadeDeReflexao(
                    "Reflexão",
                    "Esta atividade ajudará você a refletir sobre experiências positivas da sua vida.",
                    0
                );

                atividade.Executar();
            }
            else if (escolha == 3)
            {
                AtividadeDeListagem atividade = new AtividadeDeListagem(
                    "Listagem",
                    "Esta atividade ajudará você a pensar e listar coisas positivas.",
                    0
                );

                atividade.Executar();
            }
            else if (escolha == 4)
            {
                Console.WriteLine("Obrigado por usar o programa!");
                Console.WriteLine("Até logo!");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }

            if (escolha != 4)
            {
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para voltar ao menu.");
                Console.ReadLine();
            }
        }
    }
}