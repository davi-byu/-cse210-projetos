public class Program
{
    public static void Main(string[] args)
    {
        Endereco endereco1 = new Endereco(
            "123 Main Street",
            "Provo",
            "Utah",
            "EUA"
        );

        Cliente cliente1 = new Cliente(
            "Joao Silva",
            endereco1
        );

        Produto produto1 = new Produto(
            "Camisa",
            "P001",
            25.00,
            2
        );

        Produto produto2 = new Produto(
            "Tenis",
            "P002",
            60.00,
            1
        );

        Pedido pedido1 = new Pedido(cliente1);

        pedido1.AdicionarProduto(produto1);
        pedido1.AdicionarProduto(produto2);

        Endereco endereco2 = new Endereco(
            "Rua das Flores, 100",
            "Joao Pessoa",
            "Paraiba",
            "Brasil"
        );

        Cliente cliente2 = new Cliente(
            "Maria Souza",
            endereco2
        );

        Produto produto3 = new Produto(
            "Bola",
            "P003",
            30.00,
            2
        );

        Produto produto4 = new Produto(
            "Meiao",
            "P004",
            15.00,
            3
        );

        Produto produto5 = new Produto(
            "Chuteira",
            "P005",
            120.00,
            1
        );

        Pedido pedido2 = new Pedido(cliente2);

        pedido2.AdicionarProduto(produto3);
        pedido2.AdicionarProduto(produto4);
        pedido2.AdicionarProduto(produto5);

        Console.WriteLine("===== PEDIDO 1 =====");

        Console.WriteLine("\nEtiqueta de embalagem:");
        Console.WriteLine(pedido1.ObterEtiquetaEmbalagem());

        Console.WriteLine("Etiqueta de envio:");
        Console.WriteLine(pedido1.ObterEtiquetaEnvio());

        Console.WriteLine("\nTotal do pedido: $" +
                          pedido1.CalcularTotal());

        Console.WriteLine("\n========================");

        Console.WriteLine("\n===== PEDIDO 2 =====");

        Console.WriteLine("\nEtiqueta de embalagem:");
        Console.WriteLine(pedido2.ObterEtiquetaEmbalagem());

        Console.WriteLine("Etiqueta de envio:");
        Console.WriteLine(pedido2.ObterEtiquetaEnvio());

        Console.WriteLine("\nTotal do pedido: $" +
                          pedido2.CalcularTotal());
    }
}