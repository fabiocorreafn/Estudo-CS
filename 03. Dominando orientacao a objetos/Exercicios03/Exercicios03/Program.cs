using AluraFilmes.Filmes;

Console.Clear();

List<Filme> filmes = new();
List<Artista> artistas = new();

Filme filme1 = new("Harry Potter", 120);
Filme filme2 = new("Avatar - Caminho da Água", 180);
Filme filme3 = new("Vingadores - Ultimato", 140);
Filme filme4 = new("O Senhor dos Anéis - O Retorno do Rei", 200);
Filme filme5 = new("Um tira da pesada 4", 124);

filmes.Add(filme1);
filmes.Add(filme2);
filmes.Add(filme3);
filmes.Add(filme4);
filmes.Add(filme5);

Artista artista1 = new("Daniel Radcliffe", 35);
Artista artista2 = new("Sam Worthington", 48);
Artista artista3 = new("Robert Downey Jr", 60);
Artista artista4 = new("Elijah Wood", 44);
Artista artista5 = new("Eddie Murphy", 64);
Artista artista6 = new("Zoe Saldana", 46);

artistas.Add(artista1);
artistas.Add(artista2);
artistas.Add(artista3);
artistas.Add(artista4);
artistas.Add(artista5);
artistas.Add(artista6);

filme1.RegistrarElenco(artista1);
filme2.RegistrarElenco(artista2);
filme2.RegistrarElenco(artista6);
filme3.RegistrarElenco(artista3);
filme4.RegistrarElenco(artista4);
filme5.RegistrarElenco(artista5);


Console.WriteLine("__INFORMAÇÕES DOS FILMES__\n");
foreach (var f in filmes)
{
    f.MostrarInformacoesDoFilme();
}

Console.WriteLine("Pressione qualquer tecla para ver as INFORMAÇÕES DOS ARTISTAS...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Carregando informações...");
Thread.Sleep(2000);
Console.Clear();

Console.WriteLine("__INFORMAÇÕES DOS ARTISTAS__\n");
foreach (var a in artistas)
{
    a.MostrarInformacoesDoArtista();
}


Console.ReadKey();
    
/*
* PRECISO ACHAR UM JEITO DE INSTANCIAR TODOS OS FILMES PRIMEIRO, DEPOIS TODOS OS ATORES E DEPOIS ADICIONAR OS ATORES NOS FILMES,
* SEMELHANTE AO QUE FIZ NO CADASTRO DE PROFESSORES E DISCIPLINAS NO EXERCÍCIO DO CURSO 02 (AULA 03 - ESCOLA, ONDE CADASTREI TODOS OS PROFESSORES, AS DISCIPLINAS E DEPOIS
* FUI VINCULANDO CADA DISCIPLINA AOS PROFESSORES.
* 
* NÃO QUERO CRIAR UMA VARIÁVEL PARA CADA FILME, QUERO USAR UMA LISTA OU DICIONÁRIO PARA ARMAZENAR OS FILMES E IR BUSCANDO, NESTA LISTA OU DICIONÁRIO,
* O FILME ONDE DEVO ADICIONAR OS ARTISTAS.
*/
