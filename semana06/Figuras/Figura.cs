using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.Arm;

public class Figura
{
    private string _cor;

    public Figura(string cor)
    {
        _cor = cor;
    }

    public string Obtercor()
    {
        return _cor;
    }

    public void DefinirCor(string cor)
    {
        _cor = cor;
    }

    public virtual double ObterArea()
    {
        return 0;
    }
}