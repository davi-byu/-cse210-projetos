using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é a sua nota? ");
        string ValorDigitado = Console.ReadLine();

        string letra = "";

        string sinal = "";

        int nota = int.Parse(ValorDigitado);

        int ultimoDigito = nota % 10;



        if (nota >= 90)
        {
            letra = "A";
        }

        else if (nota >= 80)
        {
            letra = "B";
        }

        else if (nota >= 70)
        {
            letra = "C";
        }

        else if (nota >= 60)
        {
            letra = "D";
        }

        else
        {
            letra = "F";
        }

        if (ultimoDigito >= 7)
        {
            sinal = "+";
        }

        else if (ultimoDigito < 3)
        {
            sinal = "-";
        }

        if (letra == "A" && sinal == "+")
        {
            sinal = "";
        }


        if (letra == "F")
        {
            sinal = "";
        }


        Console.WriteLine($"{letra}{sinal}");

        if (nota >= 70)
        {
            Console.WriteLine("Parabéns, você foi aprovado!");
        }

        else
        {
            Console.WriteLine("Ainda não foi dessa vez, continue firme e logo conseguirá!");
        }


    }
}