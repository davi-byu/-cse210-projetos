
// EXCEDE OS REQUISITOS:
// Adicionei validação de entrada no menu para impedir que o programa
// encerre com erro quando o usuário digitar letras ou números fora de 1 a 5.


using System;

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();
        GeradorDePerguntas gerador = new GeradorDePerguntas();

        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine("1 Escrever");
            Console.WriteLine("2 Exibir");
            Console.WriteLine("3 Salvar");
            Console.WriteLine("4 Carregar");
            Console.WriteLine("5 Sair");

            Console.Write("Escolha uma opção: ");

            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcao))
            {
                Console.WriteLine("Opção inválida. Digite um número de 1 a 5.");
                continue;
            }

            if (opcao < 1 || opcao > 5)
            {
                Console.WriteLine("Opção inválida. Digite um número de 1 a 5.");
                continue;
            }

            if (opcao == 1)
            {
                string pergunta = gerador.ObterPerguntaAleatoria();

                Console.WriteLine(pergunta);

                Console.Write("Sua resposta: ");
                string resposta = Console.ReadLine();
                Registro novoRegistro = new Registro();
                novoRegistro._data = DateTime.Now.ToShortDateString();
                novoRegistro._textoPergunta = pergunta;
                novoRegistro._textoResposta = resposta;
                diario.AdicionarRegistro(novoRegistro);
            }

            else if (opcao == 2)
            {
                diario.ExibirTodos();
            }

            else if (opcao == 3)
            {
                Console.Write("Digite o nome do arquivo: ");
                string nomeArquivo = Console.ReadLine();

                diario.SalvarNoArquivo(nomeArquivo);
            }

            else if (opcao == 4)
            {
                Console.Write("Digite o nome do arquivo: ");
                string nomeArquivo = Console.ReadLine();

                diario.CarregarDoArquivo(nomeArquivo);
            }
        }
    }
}