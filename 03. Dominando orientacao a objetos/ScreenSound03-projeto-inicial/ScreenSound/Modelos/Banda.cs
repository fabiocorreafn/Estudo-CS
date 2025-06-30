namespace ScreenSound.Modelos;
internal class Banda
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public double Media
    {
        get
        {
            if (notas.Count == 0)
            {
                Console.WriteLine("\nNão existem notas para esta banda.");
                return 0;
            }
            else
            {
                return notas.Average(a => a.Nota);
            }
        }
    }
    public List<Album> Albuns => albuns;

    public void AdicionarAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public int AdicionarNota(Avaliacao nota)
    {
        if (nota.Nota >= 0 & nota.Nota <= 10)
        {
            notas.Add(nota);
            //Console.WriteLine($"Nota {nota.Nota}");
            //Console.ReadKey();
            return nota.Nota;
        } 
        else
        {
            if (nota.Nota < 0)
            {
                notas.Add(new Avaliacao(0));
                Console.WriteLine($"A nota digitada está fora do intervalo permitido (0-10)...");
                //Console.ReadKey();
                return 0;//notas[notas.Count - 1].Nota;
            }
            else
            {
                notas.Add(new Avaliacao(10));
                Console.WriteLine($"A nota digitada está fora do intervalo permitido (0-10)...");
                //Console.ReadKey();
                return 10; //notas[notas.Count - 1].Nota;
            }
        }
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}