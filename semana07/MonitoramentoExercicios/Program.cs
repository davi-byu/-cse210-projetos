
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        DateTime data = new DateTime(2022, 11, 3);

        Corrida corrida = new Corrida(data, 30, 5.0);
        Ciclismo ciclismo = new Ciclismo(data, 30, 20.0);
        Natacao natacao = new Natacao(data, 30, 40);

        List<Atividade> atividades = new List<Atividade>
        {
            corrida,
            ciclismo,
            natacao
        };

        foreach (Atividade atividade in atividades)
        {
            Console.WriteLine(atividade.ObterResumo());
        }
    }
}
