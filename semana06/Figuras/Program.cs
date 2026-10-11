using System;

class Program
{
    static void Main(string[] args)
    {
        List<Figura> figuras = new List<Figura>();

        figuras.Add(new Quadrado("Azul", 5));
        figuras.Add(new Retangulo("Vermelho", 4, 6));
        figuras.Add(new Circulo("Verde", 3));

        foreach (Figura figura in figuras)
        {
            Console.WriteLine($"Cor: {figura.Obtercor()}");
            Console.WriteLine($"Área: {figura.ObterArea():F2}");
            Console.WriteLine();
        }
    }

}
