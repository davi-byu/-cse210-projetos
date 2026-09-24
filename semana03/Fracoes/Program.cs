using System;

class Program
{
    static void Main(string[] args)
    {
        Fracao fracao1 = new Fracao();

        Console.WriteLine(fracao1.ObterFracaoEmTexto());
        Console.WriteLine(fracao1.ObterFracaoEmDecimal());

        Fracao fracao2 = new Fracao(5);

        Console.WriteLine(fracao2.ObterFracaoEmTexto());
        Console.WriteLine(fracao2.ObterFracaoEmDecimal());

        Fracao fracao3 = new Fracao(3, 4);

        Console.WriteLine(fracao3.ObterFracaoEmTexto());
        Console.WriteLine(fracao3.ObterFracaoEmDecimal());

        Fracao fracao4 = new Fracao(1, 3);

        Console.WriteLine(fracao4.ObterFracaoEmTexto());
        Console.WriteLine(fracao4.ObterFracaoEmDecimal());

        Fracao fracao5 = new Fracao();

        fracao5.DefinirNumerador(7);
        fracao5.DefinirDenominador(8);

        Console.WriteLine(fracao5.ObterNumerador());
        Console.WriteLine(fracao5.ObterDenominador());
    }
}