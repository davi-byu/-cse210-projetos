using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar. ");
        List<int> numeros = new List<int>();

        Console.Write("Insira o número: ");
        string numeroDigitado = Console.ReadLine();

        int numero = int.Parse(numeroDigitado);

        while (numero != 0)
        {
            numeros.Add(numero);

            Console.Write("Insira o número: ");
            numeroDigitado = Console.ReadLine();
            numero = int.Parse(numeroDigitado);

        }

        int soma = 0;

        foreach (int valor in numeros)
        {
            soma = soma + valor;
        }

        Console.WriteLine($"A soma é {soma}");

        double media = (double)soma / numeros.Count;

        Console.WriteLine($"A média é {media}");

        int maior = numeros[0];

        foreach (int valor in numeros)
        {
            if (valor > maior)
            {
                maior = valor;
            }
        }

        Console.WriteLine($"O maior número é {maior}");

        int menorPositivo = int.MaxValue;

        foreach (int valor in numeros)
        {
            if (valor > 0 && valor < menorPositivo)
            {
                menorPositivo = valor;
            }
        }

        Console.WriteLine($"O menor número positivo é {menorPositivo}");

        numeros.Sort();

        Console.WriteLine("A lista reordenada é:");

        foreach (int valor in numeros)
        {
            Console.WriteLine(valor);
        }
    }
}