// 1. Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
/*
Dictionary<string, Dictionary<string, List<double>>> alunos = new Dictionary<string, Dictionary<string, List<double>>>();

alunos.Add("Fábio", new Dictionary<string, List<double>>
{
    {"C#", new List<double> { 9, 10, 10 } },
    {"Python", new List<double> {10, 10, 9.5} }
});

alunos.Add("Gézica", new Dictionary<string, List<double>>
{
    {"C#", new List<double> { 8, 6, 7 } },
    {"Python", new List<double> {9, 9, 9.8} }
});

foreach (var aluno in alunos.Keys)
{
    Console.WriteLine($"Aluno(a): {aluno}");
    Console.WriteLine($"Médias:");
    foreach (var materia in alunos[aluno].Keys)
    {
        double media = alunos[aluno][materia].Average();
        Console.WriteLine($"    > {materia}: {media:F2}");
    }
    Console.WriteLine();
}
*/

// 2. Criar um programa que gerencie o estoque de uma loja.
// Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre,
// a partir do nome de um produto, sua quantidade em estoque.

//using System.ComponentModel;

Dictionary<string, int> produtos = new Dictionary<string, int>();

produtos.Add("Violão", 5);
produtos.Add("Guitarra", 3);
produtos.Add("Bateria", 7);

void ExibirLogo()
{
    Console.Clear();
    Console.WriteLine(@"
█▀▄▀█ █░█ █▀ █ █▀▀   █▀ ▀█▀ █▀█ █▀█ █▀▀
█░▀░█ █▄█ ▄█ █ █▄▄   ▄█ ░█░ █▄█ █▀▄ ██▄");
    Console.WriteLine("\nBem vindo à loja online Music Store!");
}
void ExibirMenuPrincipal()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("-------------------------------\n");
    Console.WriteLine("  1. Cadastrar produto");
    Console.WriteLine("  2. Ver estoque de produto");
    Console.WriteLine("  3. Atualizar estoque");
    Console.WriteLine("  9. Sair do Sistema");
    Console.Write("\nDigite a opção desejada: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1:
            {
                CadastroDeProduto();
            }
            break;
        case 2:
            {
                ExibirEstoqueDeProduto();
            }
            break;
        case 3:
            {
                AtualizarEstoque();
            }
            break;
        case 9:
            {
                break;
            }
        default: break;
    }

}

void CadastroDeProduto()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("===================");
    Console.WriteLine("CADASTRO DE PRODUTO");
    Console.WriteLine("===================\n");

    Console.Write("Nome do produto: ");
    string nomeDoProduto = Console.ReadLine()!;

    Console.Write("Quantidade em estoque: ");
    int quantidadeDoProduto = int.Parse(Console.ReadLine()!);
    produtos.Add(nomeDoProduto, quantidadeDoProduto);

    Thread.Sleep(3000);
    Console.WriteLine($"O produto '{nomeDoProduto}' com '{quantidadeDoProduto}' unidades em estoque registrado com sucesso!");

    Console.Write("Deseja cadastrar outro produto?(S/N): ");
    ConsoleKeyInfo novoCadastro;
    novoCadastro = Console.ReadKey()!;

    if (novoCadastro.Key == ConsoleKey.S)
    {
        CadastroDeProduto();
    }
    else
    {
        ExibirMenuPrincipal();
    }
}

void ExibirEstoqueDeProduto()
{
    bool continuar;
    do
    {
        Console.Clear();
        ExibirLogo();
        Console.WriteLine("===================");
        Console.WriteLine("PRODUTOS EM ESTOQUE");
        Console.WriteLine("===================\n");

        continuar = true;

        Console.Write("Digite o nome do produto?: ");
        string buscarProduto = Console.ReadLine()!;

        if (produtos.ContainsKey(buscarProduto))
        {
            Console.WriteLine($"\nO produto {buscarProduto} possui {produtos[buscarProduto]} unidades em estoque.");
            Console.WriteLine("\nDeseja fazer outra busca? (S/N): ");
            ConsoleKeyInfo novaBusca = Console.ReadKey()!;
            if (novaBusca.Key == ConsoleKey.N)
            {
                continuar = false;
            }

        }
        else
        {
            Console.WriteLine($"O produto {buscarProduto} não foi encontrado no estoque!");
            Console.WriteLine("Deseja realizar uma nova busca? (S/N): ");
            ConsoleKeyInfo novabusca = Console.ReadKey()!;
            if (novabusca.Key == ConsoleKey.N)
            {
                continuar = false;
            }
        }

    } while (continuar);

    ExibirMenuPrincipal();

    //Console.WriteLine("{0, -15}{1,10}", "PRODUTO", "QUANTIDADE");
    //Console.WriteLine(new string('-', 25)); // Criação de uma linha separadora, sintaxe: (caracter usado, quantidade deste caracter)

    //foreach (var produto in produtos)
    //{
    //    Console.WriteLine("{0, -15}{1, 8}", produto.Key, produto.Value);

    //}
    //Console.Write("\n\nPressione qualquer tecla para voltar ao MENU PRINCIPAL...");
    //Console.ReadKey();
    //ExibirMenuPrincipal();
}

void AtualizarEstoque()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("======================");
    Console.WriteLine("ATUALIZAÇÃO DE ESTOQUE");
    Console.WriteLine("======================\n");

    foreach (var produto in produtos)
    {
        Console.WriteLine(produto.Key);
    }
    Console.Write("Digite o NOME do produto que deseja atualizar: ");
    string nomeDoProdutoParaAtualizar = Console.ReadLine()!;
    Console.Write("Deseja (A)Adicionar ou (D)Diminuir a quantidade de {atualizaProduto} em estoque? (A/D): ");
    string adicionarOuDiminuir = Console.ReadLine()!;
    if (adicionarOuDiminuir == "A" || adicionarOuDiminuir == "a")
    {
        Console.Write("Digite a nova quantidade: ");
        int novaQuantidadeDoProduto = int.Parse(Console.ReadLine()!);

        // Continuar a partir daqui
        // Ver no chat GPT a pergunta que fiz sobre como atualizar o valor de um elemento do dicionário
    }
}

ExibirMenuPrincipal();

//Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
//Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.
