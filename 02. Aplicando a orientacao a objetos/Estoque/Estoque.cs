class Estoque
{
    public List<Produto> produtos = new List<Produto>();
    public int codigoLoja { get; set; }
    public string nomeLoja { get; set; }

    public void AdicionarNovoProduto(Produto produto)
    {
        produtos.Add(produto);

    }

    public void ExibirEstoque()
    {
        Console.WriteLine("Lista de produtos em estoque:\n");
        Console.WriteLine("{0, -6}{1, 12}{2, 15}{3, 9}", "CÓD.", "PRODUTO", "QUANTIDADE", "LOJA");
        foreach (var produto in produtos)
        {
            Console.WriteLine("{0, -6}{1, 12}{2, 15}{3,9}", produto.codigoProduto, produto.nomeProduto, produto.qtdeEstoque, produto.Preco);
        }
    }
}