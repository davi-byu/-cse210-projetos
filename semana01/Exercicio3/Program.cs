using System;

class Program
{
    static void Main(string[] args)
    {
        Random geradorAleatorio = new Random();


        int numeroMagico = geradorAleatorio.Next(1, 101);

        int tentativas = 0;

        Console.WriteLine("Qual é o seu palpite? ");
        string palpiteDigitado = Console.ReadLine();

        int palpite = int.Parse(palpiteDigitado);

        tentativas++;

        while (palpite != numeroMagico)
        {
            if (palpite < numeroMagico)
            {
                Console.WriteLine("Mais alto");
            }

            else if (palpite > numeroMagico)
            {
                Console.WriteLine("Mais baixo");
            }

            Console.WriteLine("Qual é o seu palpite? ");

            palpiteDigitado = Console.ReadLine();
            palpite = int.Parse(palpiteDigitado);
            tentativas++;
        }

        Console.WriteLine("Você adivinhou! ");

        Console.WriteLine($"Você fez {tentativas} palpites. ");

    }
}
