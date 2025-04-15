class Produto
{
    public int codigoProduto { get; set; }
    public string nomeProduto { get; set; }
    public int qtdeEstoque { get; set; }
    private double PrecoProduto { get; set; }
    public double Preco
    {
        get
        {
            return PrecoProduto;
        }
        set
        {
            //if (codigoDoVendedor == 9900)
            //{
            //}
            //else
            //{
            //    Console.WriteLine("Acesso negado para adicionar produtos ao estoque!");
            //    Console.WriteLine("Solicite auxílio da gerência.");
            //}
            //PrecoProduto = value;
        }
    }
}