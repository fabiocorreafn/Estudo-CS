Album anEveningWithSilkSonic = new Album();
anEveningWithSilkSonic.Nome = "An Evening With Silk Sonic";

Musica musica1 = new Musica();
musica1.Nome = "Silk Sonic Intro";
musica1.Duracao = 63;

Musica musica2 = new Musica();
musica2.Nome = "Leave The Door Open";
musica2.Duracao = 242;

anEveningWithSilkSonic.AdicionarMusica(musica1);
anEveningWithSilkSonic.AdicionarMusica(musica2);

anEveningWithSilkSonic.ExibirMusicasDoAlbum();

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