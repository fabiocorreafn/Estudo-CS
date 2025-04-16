// DESAFIO AULA 03 - PROGRAMA ESTOQUE DE PRODUTOS
// 3. Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.

Estoque estoqueLoja1 = new Estoque();

void Cabecalho()
{
    Console.Clear();
    Console.WriteLine(">> MUSIC STORE <<\n");
}
void Menu()
{
    Cabecalho();
    Console.WriteLine("1. Adicionar novo produto");
    Console.WriteLine("2. Exibir estoque");
    Console.WriteLine("3. Remover produto");
    Console.WriteLine("9. Sair");
    Console.Write("\nDigite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            {
                AdicionarProduto();
            }
            break;
        case 2:
            {
                ExibirEstoque();
            }
            break;
        case 3:
            {
                RemoverProduto();
            } break;
        default: break;
    }
}

void AdicionarProduto()
{
    Cabecalho();
    Console.WriteLine("___ADICIONAR PRODUTO___\n");

    Produto produto = new Produto();

    Console.Write("Nome do produto: ");
    produto.NomeProduto = Console.ReadLine()!;

    Console.Write("Código do produto: ");
    produto.CodigoProduto = int.Parse(Console.ReadLine()!);

    Console.Write("Quantidade: ");
    produto.QtdeEstoque = int.Parse(Console.ReadLine()!);

    Console.Write("Preço do produto: ");
    produto.Preco = double.Parse(Console.ReadLine()!);

    estoqueLoja1.AdicionarNovoProduto(produto);

    Menu();

    return;
}

void RemoverProduto()
{
    Cabecalho();
    Console.WriteLine("__Lista de Produtos__\n");

    estoqueLoja1.ExibirEstoque();

    Console.Write("\n\nDigite o código do produto que deseja EXCLUIR: ");
    int codigoParaRemover = int.Parse(Console.ReadLine()!);

    //Aqui eu preciso encontrar um jeito de pegar o código digitado pelo usuário e buscar
    //no estoque o produto que tem esse código para colocar ele no texto de confirmação de exclusão.
    //Da maneira que está {estoqueLoja1.produtos[remover].NomeProduto} eu estou usando o índice ao invés do código.
    //Todo o código responsável por buscar o produto de acordo com o código digitad, confirmar a exclusão e excluir]
    //foi para dentro do Estoque.cs, que na realidade é onde deveria estar mesmo, desde o início, e eu estava fazendo ele
    //aqui dentro do Program.cs equivocadamente.

    estoqueLoja1.RemoverProduto(codigoParaRemover);

    Menu();
   
}

void ExibirEstoque()
{
    Cabecalho();
    estoqueLoja1.ExibirEstoque();

    Console.Write("\n\nPressione qualquer tecla para voltar ao Menu...");
    Console.ReadKey();
    
    Menu();

    return;
}

Menu();

//Estoque estoqueLoja1 = new Estoque();
//estoqueLoja1.nomeLoja = "Sing Star";
//estoqueLoja1.codigoLoja = 001;

//estoqueLoja1.AdicionarNovoProduto(produto1);
//estoqueLoja1.ExibirEstoque();

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
