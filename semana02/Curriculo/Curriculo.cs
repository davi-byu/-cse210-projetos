

public class Curriculo
{
    public List<Emprego> _empregos = new List<Emprego>();

    public string _nome;

    public void Exibir()
    {
        Console.WriteLine($"Nome: {_nome}");

        Console.WriteLine("Empregos:");

        foreach (Emprego item in _empregos)
        {
            item.Exibir();
        }
    }



}