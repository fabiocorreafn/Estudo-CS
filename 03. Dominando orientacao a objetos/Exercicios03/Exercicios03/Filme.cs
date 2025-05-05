class Filme
{
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public List<string> Elenco = new();

    public Filme (string titulo, int duracao)
    {
        Titulo = titulo;
        Duracao = duracao;
    }

    void RegistrarElenco(string nome)
    {
        Elenco.Add(nome);
    }
}