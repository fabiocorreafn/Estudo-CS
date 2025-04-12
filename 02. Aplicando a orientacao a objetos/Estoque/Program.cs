// DESAFIO AULA 03 - PROGRAMA ESTOQUE DE PRODUTOS
// 3. Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.

Estoque estoqueLoja1 = new Estoque();
estoqueLoja1.nomeLoja = "Sing Star";
estoqueLoja1.codigoLoja = 001;

Produto produto1 = new Produto();
produto1.codigoProduto = 112;
produto1.nomeProduto = "Violão";
produto1.preco = 700;
produto1.qtdeEstoque = 8;

Produto produto2 = new Produto();
produto2.codigoProduto = 212;
produto2.nomeProduto = "Guitarra";
produto2.preco = 1600;
produto2.qtdeEstoque = 15;

estoqueLoja1.AdicionarNovoProduto(produto1);
estoqueLoja1.AdicionarNovoProduto(produto2);

estoqueLoja1.ExibirEstoque();
