class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida 
    {
        get
        {
            return $"A música {Nome} pertence à banda {Artista}";
        }
    }
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Música não disponível no plano atual.\nAdquira o plano Plus+");
        }
    }

    public void ExibirMusicaEArtista()
    {
        Console.WriteLine($"Nome/Artista: {Nome}/{Artista}");
    }
}