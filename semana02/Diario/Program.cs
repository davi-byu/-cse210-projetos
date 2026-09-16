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

            opcao = int.Parse(Console.ReadLine());

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