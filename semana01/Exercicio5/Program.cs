using System;

class Program
{
    static void Main(string[] args)
    {
        ExibirBoasVindas();

        string nomeUsuario = PerguntarNomeUsuario();

        int numeroFavorito = PerguntarNumeroFavorito();

        int numeroQuadrado = ElevarAoQuadrado(numeroFavorito);

        ExibirResultado(nomeUsuario, numeroQuadrado);
    }

    static void ExibirBoasVindas()
    {
        Console.WriteLine("Bem-vindo ao programa!");
    }

    static string PerguntarNomeUsuario()
    {
        Console.Write("Por favor, insira o seu nome: ");
        string nome = Console.ReadLine();

        return nome;
    }

    static int PerguntarNumeroFavorito()
    {
        Console.Write("Qual é o seu número favorito? ");
        string numeroDigitado = Console.ReadLine();

        int numero = int.Parse(numeroDigitado);

        return numero;
    }

    static int ElevarAoQuadrado(int numero)
    {
        int quadrado = numero * numero;
        return quadrado;
    }

    static void ExibirResultado(string nomeUsuario, int numeroQuadrado)
    {
        Console.WriteLine($"{nomeUsuario}, o quadrado do seu número é {numeroQuadrado}");
    }
}