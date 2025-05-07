class Filme
{
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public List<Artista> Elenco = new();

    public Filme (string titulo, int duracao)
    {
        Titulo = titulo;
        Duracao = duracao;
    }

    public void RegistrarElenco(Artista nome)
    {
        Elenco.Add(nome);
    }

    public void MostrarInformacoes()
    {
        Console.WriteLine($"Filme: {Titulo} / Duração: {Duracao} minutos");
        Console.WriteLine("Elenco:\n");
        foreach (var e in Elenco)
        {
            Console.WriteLine($" - {e.Nome}");
        }
    }
}