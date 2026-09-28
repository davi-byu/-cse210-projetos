public class Comentario
{
    string _nome;
    string _comentario;

    public Comentario(string nome, string comentario)
    {
        _nome = nome;
        _comentario = comentario;
    }

    public string ObterNome()
    {
        return _nome;
    }

    public string ObterTexto()
    {
        return _comentario;
    }
}



