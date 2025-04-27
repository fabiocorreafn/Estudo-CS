class Jogo
{
    public string Nome { get; }
    public int AnoDeLancamento { get; set; }
    public double Preco { get; set; }

    public Jogo (string nome)
    {
        Nome = nome;
    }
}