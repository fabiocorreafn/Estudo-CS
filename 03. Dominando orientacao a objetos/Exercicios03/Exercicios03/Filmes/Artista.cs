namespace AluraFilmes.Filmes;
using System.Security;

class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> filmesDoArtista = new();

    public Artista (String nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void AdiconarFilmeDoArtista(Filme titulo)
    {
        filmesDoArtista.Add(titulo);
    }

    public void MostrarInformacoesDoArtista()
    {
        Console.WriteLine($"Artista: {Nome}");
        Console.WriteLine("Filmes que participou:");
        if (filmesDoArtista.Count == 0)
        {
            Console.WriteLine($"Não foi encontrado nenhum filme com a participação de {Nome}.");
        }
        else
        {
            foreach (var f in filmesDoArtista)
            {
                Console.WriteLine($" - {f.Titulo}");
            }
        }
        Console.WriteLine();
    }
}