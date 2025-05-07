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
        //titulo.RegistrarElenco(Nome);
    }
}