public class Pedido
{
    private Cliente _cliente;
    private List<Produto> _produtos;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public double CalcularTotal()
    {
        double total = 0;

        foreach (Produto produto in _produtos)
        {
            total = total + produto.CalcularCustoTotal();
        }

        if (_cliente.MoraNosEUA())
        {
            total = total + 5;
        }
        else
        {
            total = total + 35;
        }

        return total;
    }

    public string ObterEtiquetaEmbalagem()
    {
        string etiqueta = "";

        foreach (Produto produto in _produtos)
        {
            etiqueta = etiqueta + produto.ObterNome() + " - "
                + produto.ObterIdProduto() + "\n";
        }

        return etiqueta;
    }

    public string ObterEtiquetaEnvio()
    {
        string etiqueta = "";

        etiqueta = etiqueta + _cliente.ObterNome() + "\n";
        etiqueta = etiqueta + _cliente.ObterEndereco();

        return etiqueta;
    }
}