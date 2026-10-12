
public class MetaDeListaDeTarefas : Meta
{
    private int _concluidas;
    private int _total;
    private int _bonus;


    public MetaDeListaDeTarefas(
        string nome,
        string descricao,
        int pontos,
        int total,
        int bonus,
        int concluidas = 0)
        : base(nome, descricao, pontos)
    {
        _concluidas = concluidas;
        _total = total;
        _bonus = bonus;
    }


    public override int RegistrarEvento()
    {
        if (_concluidas >= _total)
        {
            return 0;
        }

        _concluidas++;

        if (_concluidas == _total)
        {
            return _pontos + _bonus;
        }

        return _pontos;
    }

    public override bool EstaConcluida()
    {
        return _concluidas >= _total;
    }

    public override string ObterDetalhesEmTexto()
    {
        string caixa = EstaConcluida() ? "[X]" : "[ ]";
        return $"{caixa} {_nome} ({_descricao}) — Concluídas: {_concluidas}/{_total}";
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return $"MetaDeListaDeTarefas|{_nome}|{_descricao}|{_pontos}|{_total}|{_bonus}|{_concluidas}";
    }
}
