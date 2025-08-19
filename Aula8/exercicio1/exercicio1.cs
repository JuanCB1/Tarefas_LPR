/*Exercício 1) RESOLVA EM C#
Defina uma struct Produto que contenha os seguintes campos: Nome, Codigo,
Preco e Quantidade. Crie um programa que permita ao usuário inserir dados de 3
produtos e, em seguida, exiba o valor total em estoque (considerando o preço e
a quantidade de cada produto).
*/

struct Produto // Estrutura que representa um produto
{
    public string Nome;
    public int Codigo;
    public double Preco;
    public int Quantidade;
    public double ValorTotal() // Método que calcula o valor total em estoque do produto
    {
        return Preco * Quantidade;
    }
}
class exercico1
{
    static void Main()
    {
        // Vetor que armazena 3 produtos
        Produto[] produtos = new Produto[3];
        double valorTE = 0; // Valor total do estoque

        // Cadastro dos produtos
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

            // Soma o valor total desse produto ao estoque geral
            valorTE += produtos[i].ValorTotal();
        }

        // Exibe o valor total
        Console.WriteLine($"\nValor total em estoque: R$ {valorTE:F2}");
    }
}
