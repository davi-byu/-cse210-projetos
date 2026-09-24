// Criatividade: além do requisito básico, o programa seleciona
// aleatoriamente apenas palavras que ainda não foram escondidas,
// evitando selecionar novamente palavras já ocultas.

Referencia referencia = new Referencia("Provérbios", 3, 5, 6);

Escritura escritura = new Escritura(
    referencia,
    "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento."
);

while (true)
{
    Console.Clear();

    Console.WriteLine(escritura.ObterExibirTexto());
    Console.WriteLine();

    if (escritura.TodasPalavrasOcultas())
    {
        break;
    }

    Console.Write("Pressione Enter para continuar ou digite 'sair': ");
    string entrada = Console.ReadLine();

    if (entrada.ToLower() == "sair")
    {
        break;
    }

    escritura.EsconderPalavrasAleatorias();
}

Console.Clear();
Console.WriteLine(escritura.ObterExibirTexto());