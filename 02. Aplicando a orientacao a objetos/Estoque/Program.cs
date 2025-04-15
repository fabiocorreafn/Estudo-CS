// DESAFIO AULA 03 - PROGRAMA ESTOQUE DE PRODUTOS
// 3. Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.

//Console.WriteLine("Código do vendedor: ");
//int codigoDoVendedor = int.Parse(Console.ReadLine()!);

Console.WriteLine("ADICIONAR PRODUTO\n");

Produto produto1 = new Produto();

Console.Write("Nome do produto: ");
produto1.NomeProduto = Console.ReadLine()!;

Console.Write("Código do produto: ");
produto1.CodigoProduto = int.Parse(Console.ReadLine()!);

Console.Write("Quantidade: ");
produto1.QtdeEstoque = int.Parse(Console.ReadLine()!);

Console.Write("Preço do produto: ");
produto1.Preco = double.Parse(Console.ReadLine()!);

Estoque estoqueLoja1 = new Estoque();
estoqueLoja1.nomeLoja = "Sing Star";
estoqueLoja1.codigoLoja = 001;

estoqueLoja1.AdicionarNovoProduto(produto1);
estoqueLoja1.ExibirEstoque();

//Produto produto1 = new Produto();
//produto1.CodigoProduto = 112;
//produto1.NomeProduto = "Violão";
//produto1.Preco = 700;
//produto1.QtdeEstoque = 8;

//Produto produto2 = new Produto();
//produto2.CodigoProduto = 212;
//produto2.NomeProduto = "Guitarra";
//produto2.Preco = 1600;
//produto2.QtdeEstoque = 15;

//Produto produto3 = new Produto();
//produto3.CodigoProduto = 312;
//produto3.NomeProduto = "Contrabaixo";
//produto3.Preco = 1800;
//produto3.QtdeEstoque = 5;

//estoqueLoja1.AdicionarNovoProduto(produto1);
//estoqueLoja1.AdicionarNovoProduto(produto2);
//estoqueLoja1.AdicionarNovoProduto(produto3);

//estoqueLoja1.ExibirEstoque();
