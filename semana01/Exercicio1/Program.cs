using System;

class Program
{
    static void Main(string[] args)
    {
        //pedir ao usuario pelo o seu primeiro nome
        Console.Write("Qual é o seu primeiro nome? ");
        string primeiroNome = Console.ReadLine();

        Console.Write("Qual é o seu sobrenome? ");
        string sobrenomeNome = Console.ReadLine();

        Console.WriteLine($"Seu nome É {sobrenomeNome}, {primeiroNome} {sobrenomeNome}. ");


    }
}