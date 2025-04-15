class Produto
{
    public int CodigoProduto { get; set; }
    public string NomeProduto { get; set; }
    public int QtdeEstoque { get; set; }
    private double PrecoProduto { get; set => Preco = 999; }
    public double Preco { get; set; }
    //{
    //    get
    //    {
    //        return PrecoProduto;
    //    }
    //    set
    //    {
    //        PrecoProduto = value;
    //        //if (codigoDoVendedor == 9900)
    //        //{
    //        //}
    //        //else
    //        //{
    //        //    Console.WriteLine("Acesso negado para adicionar produtos ao estoque!");
    //        //    Console.WriteLine("Solicite auxílio da gerência.");
    //        //}
    //        //PrecoProduto = value;
    //    }
    //}
}