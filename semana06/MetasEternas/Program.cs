using System;

class Program
{
    static void Main(string[] args)
    {
        // Melhoria além dos requisitos básicos:
        // o usuário pode consultar um resumo do progresso geral,
        // com metas concluídas, pendentes e percentual de conclusão.
        // Esse resumo ajuda a acompanhar a evolução sem registrar
        // eventos ou alterar a pontuação do jogador.
        GerenciadorDeMetas gerenciador = new GerenciadorDeMetas();

        gerenciador.Iniciar();
    }
}
