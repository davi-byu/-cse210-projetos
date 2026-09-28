


public class Cliente
{
    private string _nome;
    private Endereco _endereco;

    public Cliente(string nome, Endereco endereco)
    {
        _nome = nome;
        _endereco = endereco;
    }

    public bool MoraNosEUA()
    {
        return _endereco.EhNosEUA();
    }

    public string ObterNome()
    {
        return _nome;
    }

    public string ObterEndereco()
    {
        return _endereco.ObterEndereco();
    }
}