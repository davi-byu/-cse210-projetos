using System;

using System.Collections.Generic;

using System.IO;

public class GerenciadorDeMetas

{

    private List<Meta> _metas;

    private int _pontos;

    public GerenciadorDeMetas()

    {

        _metas = new List<Meta>();

        _pontos = 0;

    }

    public void ExibirInfoJogador()

    {

        Console.WriteLine($"Pontuação atual: {_pontos}");

    }

    public void ListarNomesDasMetas()

    {

        if (_metas.Count == 0)

        {

            Console.WriteLine("Nenhuma meta cadastrada.");

            return;

        }

        for (int i = 0; i < _metas.Count; i++)

        {

            Console.WriteLine(

                $"{i + 1}. {_metas[i].ObterDetalhesEmTexto()}");

        }

    }

    public void ListarDetalhesDasMetas()

    {

        Console.WriteLine("\n=== LISTA DE METAS ===");

        if (_metas.Count == 0)

        {

            Console.WriteLine("Nenhuma meta cadastrada.");

            return;

        }

        foreach (Meta meta in _metas)

        {

            Console.WriteLine(meta.ObterDetalhesEmTexto());

        }

    }

    // Funcionalidade extra: resume o progresso geral de todas as metas.
    public void ExibirResumoProgresso()
    {
        int totalMetas = _metas.Count;
        int metasConcluidas = 0;

        foreach (Meta meta in _metas)
        {
            if (meta.EstaConcluida())
            {
                metasConcluidas++;
            }
        }

        int metasPendentes = totalMetas - metasConcluidas;
        double percentual = totalMetas == 0
            ? 0
            : (double)metasConcluidas / totalMetas * 100;

        Console.WriteLine("\n=== RESUMO DO PROGRESSO ===");
        Console.WriteLine($"Total de metas: {totalMetas}");
        Console.WriteLine($"Metas concluídas: {metasConcluidas}");
        Console.WriteLine($"Metas pendentes: {metasPendentes}");
        Console.WriteLine($"Progresso geral: {percentual:F1}%");
    }

    public void CriarMeta()

    {

        Console.WriteLine("\nQual tipo de meta deseja criar?");

        Console.WriteLine("1. Meta simples");

        Console.WriteLine("2. Meta eterna");

        Console.WriteLine("3. Meta de lista de tarefas");

        Console.Write("Escolha uma opção: ");

        string opcao = Console.ReadLine() ?? "";

        if (opcao != "1" && opcao != "2" && opcao != "3")

        {

            Console.WriteLine("Opção inválida.");

            return;

        }

        Console.Write("Nome da meta: ");

        string nome = Console.ReadLine() ?? "";

        Console.Write("Descrição: ");

        string descricao = Console.ReadLine() ?? "";

        Console.Write("Pontos por registro: ");

        if (!int.TryParse(Console.ReadLine(), out int pontos) ||

            pontos < 0)

        {

            Console.WriteLine("Digite uma quantidade válida de pontos.");

            return;

        }

        Meta novaMeta;

        switch (opcao)

        {

            case "1":

                novaMeta = new MetaSimples(nome, descricao, pontos);

                break;

            case "2":

                novaMeta = new MetaEterna(nome, descricao, pontos);

                break;

            case "3":

                Console.Write("Quantas vezes precisa ser realizada? ");

                if (!int.TryParse(Console.ReadLine(), out int total) ||

                    total <= 0)

                {

                    Console.WriteLine("Digite um total maior que zero.");

                    return;

                }

                Console.Write("Quantos pontos de bônus? ");

                if (!int.TryParse(Console.ReadLine(), out int bonus) ||

                    bonus < 0)

                {

                    Console.WriteLine("Digite um bônus válido.");

                    return;

                }

                novaMeta = new MetaDeListaDeTarefas(

                    nome, descricao, pontos, total, bonus);

                break;

            default:

                return;

        }

        _metas.Add(novaMeta);

        Console.WriteLine("Meta criada com sucesso!");

    }

    public void RegistrarEvento()

    {

        if (_metas.Count == 0)

        {

            Console.WriteLine("Você ainda não cadastrou nenhuma meta.");

            return;

        }

        ListarNomesDasMetas();

        Console.Write("Qual meta você realizou? ");

        if (!int.TryParse(Console.ReadLine(), out int escolha) ||

            escolha < 1 || escolha > _metas.Count)

        {

            Console.WriteLine("Número de meta inválido.");

            return;

        }

        Meta metaEscolhida = _metas[escolha - 1];

        int pontosRecebidos = metaEscolhida.RegistrarEvento();

        _pontos += pontosRecebidos;

        Console.WriteLine($"Você recebeu {pontosRecebidos} pontos!");

        Console.WriteLine($"Pontuação total: {_pontos}");

    }

    public void SalvarMetas()

    {

        Console.Write("Digite o nome do arquivo para salvar: ");

        string nomeArquivo = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(nomeArquivo))

        {

            Console.WriteLine("Nome de arquivo inválido.");

            return;

        }

        try

        {

            using (StreamWriter escritor = new StreamWriter(nomeArquivo))

            {

                escritor.WriteLine(_pontos);

                foreach (Meta meta in _metas)

                {

                    escritor.WriteLine(meta.ObterRepresentacaoEmTexto());

                }

            }

            Console.WriteLine("Metas salvas com sucesso!");

        }

        catch (IOException)

        {

            Console.WriteLine("Não foi possível salvar o arquivo.");

        }

        catch (UnauthorizedAccessException)

        {

            Console.WriteLine("Você não tem permissão para salvar nesse local.");

        }

    }

    public void CarregarMetas()

    {

        Console.Write("Digite o nome do arquivo para carregar: ");

        string nomeArquivo = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(nomeArquivo))

        {

            Console.WriteLine("Nome de arquivo inválido.");

            return;

        }

        if (!File.Exists(nomeArquivo))

        {

            Console.WriteLine("Arquivo não encontrado.");

            return;

        }

        try

        {

            string[] linhas = File.ReadAllLines(nomeArquivo);

            if (linhas.Length == 0 ||

                !int.TryParse(linhas[0], out int pontosSalvos) ||

                pontosSalvos < 0)

            {

                Console.WriteLine("Arquivo inválido.");

                return;

            }

            List<Meta> metasCarregadas = new List<Meta>();

            for (int i = 1; i < linhas.Length; i++)

            {

                if (string.IsNullOrWhiteSpace(linhas[i]))

                {

                    continue;

                }

                string[] partes = linhas[i].Split('|');

                switch (partes[0])

                {

                    case "MetaSimples":

                        if (partes.Length != 5)

                        {

                            Console.WriteLine("Dados de meta simples inválidos.");

                            return;

                        }

                        metasCarregadas.Add(new MetaSimples(

                            partes[1],

                            partes[2],

                            int.Parse(partes[3]),

                            bool.Parse(partes[4])));

                        break;

                    case "MetaEterna":

                        if (partes.Length != 4)

                        {

                            Console.WriteLine("Dados de meta eterna inválidos.");

                            return;

                        }

                        metasCarregadas.Add(new MetaEterna(

                            partes[1],

                            partes[2],

                            int.Parse(partes[3])));

                        break;

                    case "MetaDeListaDeTarefas":

                        if (partes.Length != 7)

                        {

                            Console.WriteLine(

                                "Dados da meta de lista inválidos.");

                            return;

                        }

                        metasCarregadas.Add(new MetaDeListaDeTarefas(

                            partes[1],

                            partes[2],

                            int.Parse(partes[3]),

                            int.Parse(partes[4]),

                            int.Parse(partes[5]),

                            int.Parse(partes[6])));

                        break;

                    default:

                        Console.WriteLine("Tipo de meta desconhecido.");

                        return;

                }

            }

            _metas = metasCarregadas;

            _pontos = pontosSalvos;

            Console.WriteLine("Metas carregadas com sucesso!");

        }

        catch (FormatException)

        {

            Console.WriteLine("O arquivo contém dados em formato inválido.");

        }

        catch (IOException)

        {

            Console.WriteLine("Não foi possível ler o arquivo.");

        }

        catch (UnauthorizedAccessException)

        {

            Console.WriteLine("Você não tem permissão para ler esse arquivo.");

        }

    }

    public void Iniciar()

    {

        string opcao = "";

        while (opcao != "8")

        {

            Console.WriteLine("\n=== METAS ETERNAS ===");

            Console.WriteLine("1. Exibir pontuação");

            Console.WriteLine("2. Listar metas");

            Console.WriteLine("3. Criar nova meta");

            Console.WriteLine("4. Registrar evento");

            Console.WriteLine("5. Salvar metas");

            Console.WriteLine("6. Carregar metas");

            Console.WriteLine("7. Resumo geral do progresso");
            Console.WriteLine("8. Sair");

            Console.Write("Escolha uma opção: ");

            opcao = Console.ReadLine() ?? "";

            switch (opcao)

            {

                case "1":

                    ExibirInfoJogador();

                    break;

                case "2":

                    ListarDetalhesDasMetas();

                    break;

                case "3":

                    CriarMeta();

                    break;

                case "4":

                    RegistrarEvento();

                    break;

                case "5":

                    SalvarMetas();

                    break;

                case "6":

                    CarregarMetas();

                    break;

                case "7":

                    ExibirResumoProgresso();

                    break;

                case "8":

                    Console.WriteLine("Até logo!");

                    break;

                default:

                    Console.WriteLine("Opção inválida. Tente novamente.");

                    break;

            }

        }

    }

}
