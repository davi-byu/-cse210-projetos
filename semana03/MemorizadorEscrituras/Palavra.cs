using System.Linq;

public class Palavra
{
    private string _texto;
    private bool _estaOculta;

    public Palavra(string texto)
    {
        _texto = texto;
        _estaOculta = false;
    }

    public void Esconder()
    {
        _estaOculta = true;
    }

    public string ObterExibirTexto()
    {
        if (_estaOculta)
        {
            return new string('_', _texto.Count(char.IsLetter));
        }

        return _texto;
    }

    public bool EstaOculta()
    {
        return _estaOculta;
    }
}