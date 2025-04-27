Banda SilkSonic = new Banda("Silk Sonic");

Album anEveningWithSilkSonic = new Album("An Evening With Silk Sonic");

Musica musica1 = new Musica(SilkSonic, "Silk Sonic Intro")
{
    Duracao = 63,
    Disponivel = true,
};
musica1.Genero = new Genero();
musica1.Genero.Nome = "Pop";

Musica musica2 = new Musica(SilkSonic, "Leave The Door Open")
{
    Duracao = 242,
    Disponivel = false,
};
musica2.Genero = new Genero();
musica2.Genero.Nome = "Balada";

Musica musica3 = new(SilkSonic, "Fly As Me")
{
    Duracao = 219,
    Disponivel = true,
};
musica3.Genero = new Genero();
musica3.Genero.Nome = "Funk";

anEveningWithSilkSonic.AdicionarMusica(musica1);
anEveningWithSilkSonic.AdicionarMusica(musica2);
anEveningWithSilkSonic.AdicionarMusica(musica3);
SilkSonic.AdicionarAlbum(anEveningWithSilkSonic);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();
anEveningWithSilkSonic.ExibirMusicasDoAlbum();
SilkSonic.ExibirDiscografia();

Playlist playlist1 = new("Top hits 2025")
{
    Visibilidade = true,
    Colaboracao = true,
};

playlist1.AdicionarMusica(musica1);
playlist1.AdicionarMusica(musica2);
playlist1.AdicionarMusica(musica3);
playlist1.ExibirPlaylist();

//Musica musica1 = new Musica();
//musica1.Nome = "Desenho de giz";
//musica1.Artista = "João Bosco";
//musica1.Duracao = 188;
//musica1.Disponivel = true;
//Console.WriteLine(musica1.DescricaoResumida);

//Musica musica2 = new Musica();
//musica2.Nome = "É tudo";
//musica2.Artista = "Soweto";
//musica2.Duracao = 186;
//Console.WriteLine(musica2.DescricaoResumida);

//musica1.ExibirFichaTecnica();
//Console.WriteLine();
//musica2.ExibirFichaTecnica();
//Console.WriteLine();
//musica1.ExibirMusicaEArtista();
//Console.WriteLine();
//musica2.ExibirMusicaEArtista();