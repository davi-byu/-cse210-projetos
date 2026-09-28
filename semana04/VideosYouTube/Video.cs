using System.ComponentModel;

public class Video
{
    string _titulo;
    string _autor;
    int _duracao;

    List<Comentario> _comentarios;


    public void AdicionarComentario(Comentario comentario)
    {
        _comentarios.Add(comentario);
    }

    public int ObterQuantidadeComentarios()
    {
        return _comentarios.Count;
    }

    public List<Comentario> ObterComentarios()
    {
        return _comentarios;

    }

    public Video(string titulo, string autor, int duracao)
    {
        _titulo = titulo;
        _autor = autor;
        _duracao = duracao;
        _comentarios = new List<Comentario>();
    }

    public string ObterTitulo()
    {
        return _titulo;
    }

    public string ObterAutor()
    {
        return _autor;
    }

    public int ObterDuracao()
    {
        return _duracao;
    }
}



