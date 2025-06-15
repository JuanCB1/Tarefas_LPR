struct Produto
{
    public string Nome;
    public int Codigo;
    public double Preco;
    public int Quantidade;
    public double ValorTotal()
    {
        return Preco * Quantidade;
    }
}
class exercico1
{
    static void Main()
    {
        Produto[] produtos = new Produto[3];
        double valorTE = 0;

        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine($"\nProduto {i + 1}");
            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();
            Console.Write("Código: ");
            produtos[i].Codigo = int.Parse(Console.ReadLine());
            Console.Write("Preço: ");
            produtos[i].Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());

            valorTE += produtos[i].ValorTotal();
        }

        Console.WriteLine($"\nValor total em estoque: R$ {valorTE:F2}");
    }
}
