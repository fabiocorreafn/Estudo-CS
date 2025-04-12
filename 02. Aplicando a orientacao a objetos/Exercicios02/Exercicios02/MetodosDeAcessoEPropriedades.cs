// 1. Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.
/*
class ContaBancariaProperties
{
    public int Conta { get; set; }
    public string Nome { get; set; }
    public long Cpf { get; set; }
    public double Saldo { get; set; }
}
*/

// 2. Reescrever os atributos da classe Carro, de modo que eles sejam properties e adicionar uma nova propertie DescricaoDetalhada,
//    que mostra o fabricante, modelo e ano do carro.
/*
class CarroProperties
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Combustivel { get; set; }
    public string DescricaoDetalhada { get => $"Fabricante: {Marca} \nModelo: {Modelo} \nAno: {Ano}"; }

}
*/

// 3. Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.
/*
class CarroProperties
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    
    private int ano;
    public int Ano
    {
        get => ano;

        set
        {
            if (value >= 1960 && value <= 2023)
            {
                ano = value;
            }
            else
            {
                Console.WriteLine($"O ano do carro {Marca} {Modelo} deve estar entre 1960 e 2023.");
            }
        }
    }

    public string Combustivel { get; set; }
    public string DescricaoDetalhada { get => $"Fabricante: {Marca} \nModelo: {Modelo} \nAno: {Ano}"; }

    public void ExibirInformacoesDosCarros()
    {
        if (ano == 0)
        {
            Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo} \nAno: ANO INVÁLIDO! É necesário cadastrar um ano válido!");
        }
        else
        {
            Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo} \nAno:{Ano}");
        }

        Console.WriteLine();
    }
}
*/


// 4. Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque.
//    Além disso, garantir que o preço e o estoque do produto sejam valores positivos
//    e criar uma propriedade que mostra detalhadamente as informações do produto,
//    para que seja usado pela equipe de vendas.
/*
class Produto
{
    public string nome;
    public string marca;
    public double PrecoEntrada
    {
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("O preço do produto precisa ser Maior que 0.");
            }
            else
            {
                preco = value;
                //Console.WriteLine($"O preço do {marca} {nome} é {PrecoEntrada}");
            }
        }

        get => preco;
    }
    public int EstoqueEntrada
    {
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("O estoque precisa ser Maior que 0.");
            }
            else
            {
                estoque = value;
            }
        }

        get => estoque;
    }
    private double preco;
    private int estoque;

    public string InformacoesDetalhadas
    {
        get => $"Informações do Produto: \nProduto: {marca} {nome} \nEstoque: {estoque} unidades \nPreço: {preco.ToString("C")}";
        //{
            //return $"O produto {marca} {nome} consta com {estoque} unidades em estoque";
        //}
    }
}   
*/