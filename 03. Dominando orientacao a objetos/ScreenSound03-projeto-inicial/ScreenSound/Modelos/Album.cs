﻿using System.Reflection.Metadata.Ecma335;

namespace ScreenSound.Modelos;
internal class Album : IAvaliavel
{
    public static int ContadorDeObjetos = 0;
    private List<Avaliacao> notas = new();

    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
        ContadorDeObjetos++;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => musicas;

    public double Media 
    {
        get
        {
            if (notas.Count == 0)
            {
                Console.WriteLine("Não existem notas para este Álbum");
                return 0;
            }
            else 
            {
                return notas.Average(a => a.Nota);
            }
        }
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }
}