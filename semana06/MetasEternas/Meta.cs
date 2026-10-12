
public abstract class Meta
{
    protected string _nome;
    protected string _descricao;
    protected int _pontos;

    public Meta(string nome, string descricao, int pontos)
    {
        _nome = nome;
        _descricao = descricao;
        _pontos = pontos;
    }

    public abstract int RegistrarEvento();

    public abstract bool EstaConcluida();

    public virtual string ObterDetalhesEmTexto()
    {
        string caixa = EstaConcluida() ? "[X]" : "[ ]";
        return $"{caixa} {_nome} ({_descricao})";
    }

    public abstract string ObterRepresentacaoEmTexto();
}
