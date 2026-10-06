using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Tarefas.");

        Tarefa tarefa = new Tarefa("Maria Antunes", "História da Europa");

        Console.WriteLine(tarefa.ObterResumo());

        TarefaDeMatematica matematica = new TarefaDeMatematica(
            "Roberto Rodriguez",
            "Frações",
            "7.3",
            "8-19"
        );

        Console.WriteLine(matematica.ObterResumo());
        Console.WriteLine(matematica.ObterListaDeTarefas());

        TarefaDeRedacao redacao = new TarefaDeRedacao(
            "Maria Antunes",
            "História da Europa",
            "As Causas da Segunda Guerra Mundial"
        );

        Console.WriteLine(redacao.ObterResumo());
        Console.WriteLine(redacao.ObterInformacoesDaRedacao());
    }
}