namespace AluraFilmes.Filmes;
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
        nome.AdiconarFilmeDoArtista(this);
        
    }

    public void MostrarInformacoesDoFilme()
    {
        Console.WriteLine($"Filme: {Titulo} / Duração: {Duracao} minutos");
        Console.WriteLine("Elenco:");
        if (Elenco.Count == 0)
        {
            Console.WriteLine(" - Não foram encontrados artistas no Elenco. -\n");
        }
        else
        {
            foreach (var e in Elenco)
            {
                Console.WriteLine($" - {e.Nome}");
            }
            Console.WriteLine();
        }
    }

}