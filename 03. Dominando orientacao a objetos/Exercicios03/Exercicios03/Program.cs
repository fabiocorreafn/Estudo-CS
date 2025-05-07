//Console.WriteLine(">> Alura Filmes <<\n");
//Console.WriteLine("Digite 1 para cadastrar um filme");
//Console.WriteLine("Digite 2 para registrar o elenco de um filme");

List<Filme> filmes = new();
List<Artista> artistas = new();

Filme filme = new("Harry Potter", 120);
filmes.Add(filme);
Artista artista = new("Jessica Alba", 45);
artista.AdiconarFilmeDoArtista(filme);

/*
 * CONTINUAR DAQUI 
 * PRECISO ACHAR UM JEITO DE INSTANCIAR OS FILMES PRIMEIRO, DEPOIS OS ATORES E DEPOIS ADICIONAR OS ATORES NOS FILMES.
 * NÃO QUERO CRIAR UMA VARIÁVEL PARA CADA FILME, QUERO USAR UMA LISTA OU DICIONÁRIO PARA ARMAZENAR OS FILMES E IR BUSCANDO
 * NESTA LISTA OU DICIONÁRIO O FILME ONDE DEVO ADICIONAR OS ARTISTAS.
 */

filme = new("Avatar - Caminho das Águas", 180);
filmes.Add(filme);
filme = new("Vingadores - Ultimato", 140);
filmes.Add(filme);
filme = new("O Senhor dos Anéis - O Retorno do Rei", 200);
filmes.Add(filme);
filme = new("Star Wars - O Império Contra-Ataca", 124);
filmes.Add(filme);


foreach (var f in filmes)
{
    f.MostrarInformacoes();
}

Console.ReadKey();