class Estoque
{
    List<Produto> produtos = new List<Produto>();
    public int codigoLoja { get; set; }
    public string nomeLoja { get; set; }
    public string produto { get; set; }

    public void AdicionarNovoProduto(Produto produto)
    {
        produtos.Add(produto);
    }

    public void ExibirEstoque()
    {
        Console.WriteLine("Lista de produtos em estoque:\n");
        Console.WriteLine("{0, -17}{1, 10}{2, 14}", "PRODUTO", "QUANTIDADE", "LOJA\n");
        //Console.WriteLine(new string('-', 41)); //Cria uma linha separadora formada por caracteres que eu escolho. Sintaxe: ('caracter', quantidade deste caracter)

        //foreach (var produto in produtos)
        //{
        //    Console.WriteLine("{0, -10}{1, 10}", produto.Key, produto.Value);
        //}
        
        foreach (var produto in produtos)
        {
            Console.WriteLine($"{produto.nomeProduto}\n{produto.qtdeEstoque}\n{produto.preco}\n ");
        }
    }
}