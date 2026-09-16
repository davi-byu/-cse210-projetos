

class Diario
{
    List<Registro> _registros = new List<Registro>();

    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);
    }

    public void ExibirTodos()
    {
        foreach (Registro registro in _registros)
        {
            registro.Exibir();
        }
    }

    public void SalvarNoArquivo(string arquivo)
    {
        using (StreamWriter arquivoSaida = new StreamWriter(arquivo))
        {
            foreach (Registro registro in _registros)
            {
                arquivoSaida.WriteLine($"{registro._data}|{registro._textoPergunta}|{registro._textoResposta}");
            }
        }
    }

    public void CarregarDoArquivo(string arquivo)
    {
        string[] linhas = System.IO.File.ReadAllLines(arquivo);

        _registros.Clear();

        foreach (string linha in linhas)
        {
            string[] partes = linha.Split('|');

            Registro registro = new Registro();

            registro._data = partes[0];

            registro._textoPergunta = partes[1];

            registro._textoResposta = partes[2];

            _registros.Add(registro);
        }
    }
}
