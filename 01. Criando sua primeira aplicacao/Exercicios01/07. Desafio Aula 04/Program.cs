// 1. Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.

// ---- NOTAS E MÉDIAS DE ALUNOS ----
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

// ---- CONTROLE DE ESTOQUE ----

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
bool NovaBusca()
{
    // bool continuar = true;
    Console.Write("\nDeseja realizar uma nova busca? (S/N): ");
    ConsoleKeyInfo novaBusca = Console.ReadKey()!;
    if (novaBusca.Key == ConsoleKey.S)
    {
        return true;
    } else
    {
        return false;
    }
    //return novaBusca.Key == ConsoleKey.S;
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
            } break;
        case 2:
            {
                ExibirEstoqueDeProduto();
            } break;
        case 3:
            {
                AtualizarEstoque();
            } break;
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

        Console.WriteLine("PRODUTOS");
        Console.WriteLine(new string('-', 10));

        foreach (var produto in produtos)
        {
            Console.WriteLine(produto.Key);
        }

        Console.WriteLine(new string('-', 10), "\n");
        
        Console.Write("\nDigite o NOME do produto para visualizar o estoque, 0 para exibir todos OU 9 para voltar: ");
        string buscarProduto = Console.ReadLine()!;

        switch (buscarProduto)
        {
            case "9":
                {
                    continuar = false;
                } break;
            case "0":
                {
                    Console.WriteLine("\n{0, -10}{1, 10}", "PRODUTO", "QUANTIDADE");
                    Console.WriteLine(new string('-', 20));
                    foreach (var produto in produtos)
                    {
                        Console.WriteLine("{0, -10}{1, 10}", produto.Key, produto.Value);
                    }
                    if (NovaBusca() == true)
                    {
                        continuar = true;
                    } else
                    {
                        continuar = false;
                    }
                } break;
            default:
            {
                if (produtos.ContainsKey(buscarProduto))
                {
                        Console.WriteLine("\n{0, -10}{1, 10}", "PRODUTO", "QUANTIDADE");
                        Console.WriteLine(new string('-', 20));
                        Console.WriteLine("{0, -10}{1, 10}", buscarProduto, produtos[buscarProduto]);
                        Console.WriteLine(new string('-', 20));
                        if (NovaBusca() == true)
                        {
                            continuar = true;
                        } else
                        {
                            continuar = false;
                        }
                } else
                {
                        Console.WriteLine($"\nO produto {buscarProduto} não foi encontrado no estoque!");
                        if (NovaBusca() == true)
                        {
                            continuar = true;
                        } else
                        {
                            continuar = false;
                        }
                }
            } break;
        }
    } while (continuar);

    ExibirMenuPrincipal();
}
void AtualizarEstoque()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("======================");
    Console.WriteLine("ATUALIZAÇÃO DE ESTOQUE");
    Console.WriteLine("======================\n");

    Console.WriteLine("{0, -10}{1, 10}", "PRODUTO", "QUANTIDADE");
    Console.WriteLine(new string('-', 20)); //Cria uma linha separadora formada por caracteres que eu escolho. Sintaxe: ('caracter', quantidade deste caracter)
    
    foreach (var produto in produtos)
    {
        Console.WriteLine("{0, -10}{1, 10}",produto.Key, produto.Value);
    }

    Console.Write("\nDigite o NOME do produto que deseja atualizar\n Ou digite 9 para voltar ao MENU PRINCIPAL: ");
    string nomeDoProdutoParaAtualizar = Console.ReadLine()!;

    bool continuar = true;
    do
    {       
        if (nomeDoProdutoParaAtualizar == "9")
        {
            continuar = false;
        }
        else if (produtos.ContainsKey(nomeDoProdutoParaAtualizar))
        {
            Console.Write($"Digite a nova quantidade para {nomeDoProdutoParaAtualizar}: ");
            int novaQuantidadeDoProduto = int.Parse(Console.ReadLine()!);
            produtos[nomeDoProdutoParaAtualizar] = novaQuantidadeDoProduto;
            Thread.Sleep(2000);
            Console.WriteLine($"O produto {nomeDoProdutoParaAtualizar} foi atualizado para {novaQuantidadeDoProduto} unidades");
            Console.WriteLine();
            Console.Write("Deseja atualizar o estoque de outro produto? (S/N): ");
            ConsoleKeyInfo resposta = Console.ReadKey()!;
            if (resposta.Key == ConsoleKey.S)
            {
                AtualizarEstoque();
            } else 
            {
                continuar = false;
            }
        } else 
        {
            Console.WriteLine("\nProduto não encontrado ou nome inválido!");
            if (NovaBusca() == true)
            {
                AtualizarEstoque();
            } else
            {
                continuar = false;
            }
        }
    } while (continuar);

    ExibirMenuPrincipal();  
}

ExibirMenuPrincipal();


// 3. Crie um programa que implemente um quiz simples de perguntas e respostas.
// Utilize um dicionário para armazenar as perguntas e as respostas corretas.

// ---- JOGO DE PERGUNTAS E RESPOSTAS ----

/*
using System;

Dictionary<string, string> perguntas = new Dictionary<string, string>();

perguntas.Add("Quanto é 2 + 2?", "4");
perguntas.Add("Quanto é 5 + 3?", "8");
perguntas.Add("Quanto é 1 + 8?", "9");
perguntas.Add("Quanto é 3 + 7?", "10");
perguntas.Add("Quanto é 4 + 4?", "8");

void ExibirLogo()
{
    Console.WriteLine(@"
░█████╗░░█████╗░███████╗██████╗░████████╗███████╗  ███████╗  ░██████╗░░█████╗░███╗░░██╗██╗░░██╗███████╗
██╔══██╗██╔══██╗██╔════╝██╔══██╗╚══██╔══╝██╔════╝  ██╔════╝  ██╔════╝░██╔══██╗████╗░██║██║░░██║██╔════╝
███████║██║░░╚═╝█████╗░░██████╔╝░░░██║░░░█████╗░░  █████╗░░  ██║░░██╗░███████║██╔██╗██║███████║█████╗░░
██╔══██║██║░░██╗██╔══╝░░██╔══██╗░░░██║░░░██╔══╝░░  ██╔══╝░░  ██║░░╚██╗██╔══██║██║╚████║██╔══██║██╔══╝░░
██║░░██║╚█████╔╝███████╗██║░░██║░░░██║░░░███████╗  ███████╗  ╚██████╔╝██║░░██║██║░╚███║██║░░██║███████╗
╚═╝░░╚═╝░╚════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░╚══════╝  ╚══════╝  ░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚══════╝");
    Console.WriteLine("\nAcerte as respostas para ganhar o grande prêmio!\n");
}
void ExibirMenuPrincipal()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("Bem vindo ao Acerte e Ganhe!");
    Console.WriteLine("Escolha uma das opções abaixo.");
    Console.WriteLine(new string('-', 30));
    Console.WriteLine("  1. Cadastrar uma pergunta");
    Console.WriteLine("  2. Visualizar as perguntas");
    Console.WriteLine("  3. Excluir uma pergunta");
    Console.WriteLine("  4. JOGAR O ACERTE E GANHE!");
    Console.WriteLine("  9. Sair");
    Console.Write("\nDigite uma opção: ");
    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            {
                CadastrarPergunta();
            } break;
        case 2:
            {
                VisualizarPerguntas();
            } break;
        case 3:
            {
                ExcluirPergunta();
            } break;
        case 4:
            {
                Jogar();
            } break;
        case 9:
            {
                break;
            }
        default: break;
    }     
}
bool NovoCadastro()
{
    Console.Write("\nDeseja cadastrar uma nova pergunta? (S/N): ");
    ConsoleKeyInfo novoCadastro = Console.ReadKey();
    if (novoCadastro.Key == ConsoleKey.S)
    {
        return true;
    }
    else
    {
        return false;
    }
}
void CadastrarPergunta()
{
    bool continuar = true;
    do
    {
        Console.Clear();
        ExibirLogo();
        Console.WriteLine("=================================");
        Console.WriteLine("CADASTRO DE PERGUNTAS E RESPOSTAS");
        Console.WriteLine("=================================\n");

        Console.WriteLine("Digite a PERGUNTA: ");
        string pergunta = Console.ReadLine()!;
        Console.WriteLine("Digite a RESPOSTA correta: ");
        string resposta = Console.ReadLine()!;

        Console.Write("\nConfirma o cadastro desta pergunta e resposta? (S/N): ");
        ConsoleKeyInfo confirmacao = Console.ReadKey()!;
        if (confirmacao.Key == ConsoleKey.S)
        {
            perguntas.Add(pergunta, resposta);
            if (NovoCadastro() == true)
            {
                continuar = true;
            }
            else
            {
                continuar = false;
            }
        }
        else
        {
            continuar = true;
        }
    } while (continuar);

    ExibirMenuPrincipal();
}
void VisualizarPerguntas()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("Estas são as perguntas e respostas cadastradas:");
    Console.WriteLine(new string('-', 47), "\n");
    int i = 0;
    foreach (var pergunta in perguntas)
    {
        i++;

        Console.WriteLine($"{i}.");
        Console.WriteLine($"PERGUNTA: {pergunta.Key}");
        Console.WriteLine($"RESPOSTA: {pergunta.Value}\n");
    }

    Console.Write("Pressione qualquer tecla para voltar ao menu principal...");
    Console.ReadKey();

    ExibirMenuPrincipal();
}
void ExcluirPergunta()
{
    Console.Clear();
    ExibirLogo();

    //Eu havia criado um Dicionário para mostrar as perguntas ao usuário para que ele escolhesse qual excluir,
    //mas para mostrar as perguntas para que o usuário escolha qual excluir,seria melhor se o usuário somente digitasse
    //um número referente à pergunta que quisesse. 
    //Para isso precisaria usar índice, mas Dicionário não usa índice, então optei por converter o Dicionário em lista para ter essa facilidade
    //de manipular as perguntas através de índices, daí eu excluo a pergunta de acordo com o número da pergunta que o usuário escolheu
    //usando o índice de uma lista para manipular o equivalente dentro do Dicionário conforme segue o código abaixo.
        
    //Converte o Dicionário para uma Lista para que eu consiga acessar através do índice um item específico digitado pelo usuário para excluir
    List<KeyValuePair<string, string>> listaDePerguntas = new List<KeyValuePair<string, string>>(perguntas); 

    Console.WriteLine("Estas são as perguntas e respostas CADASTRADASSSS:");
    Console.WriteLine(new string('-', 47), "\n");

    for (int i = 0; i < perguntas.Count; i++)
    {
        Console.WriteLine($"{i+1}.");
        Console.WriteLine($"PERGUNTA: {listaDePerguntas[i].Key}");
        Console.WriteLine($"RESPOSTA: {listaDePerguntas[i].Value}\n");
    }

    Console.Write("Digite o número da pergunta que deseja EXCLUIR ou digite 99 para voltar: ");
    int excluirIndice = int.Parse(Console.ReadLine()!)-1;
    if (excluirIndice + 1  == 99)
    {
        ExibirMenuPrincipal();
        return;
    }
    var chaveParaExcluir = listaDePerguntas[excluirIndice].Key;

    Console.WriteLine();
    Console.WriteLine("Você está prestes a excluir a pergunta abaixo:");
    Console.WriteLine(new string('-', 50));
    Console.WriteLine($"PERGUNTA: {chaveParaExcluir}");
    Console.WriteLine($"RESPOSTA: {listaDePerguntas[excluirIndice].Value}");
    Console.WriteLine(new string('-', 50));
    Console.Write("\nConfirma que deseja excluir esta pergunta? (S/N): ");
    string resposta = Console.ReadLine()!.ToLower();

    if (resposta == "s")
    {
        perguntas.Remove(chaveParaExcluir);
        Thread.Sleep(2000);
        Console.WriteLine("Pergunta excluída com sucesso!\n");
        Console.Write("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    } else
    {
        Console.WriteLine("Operação de exclusão cancelada pelo usuário!\n");
        Console.Write("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
    ExibirMenuPrincipal();
}
void Jogar()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("Acerte a resposta das 3 perguntas e ganhe o prêmio!");
    Console.WriteLine("A pergunta é: ");

    // Apesar de podermos ter diversas perguntas cadastradas, eu quero que apenas 3 sejam feitas durante o jogo, porém não posso deixar
    // que sejam sempre feitas as mesmas 3 perguntas. Para isso fiz uso do método Random. O método Random serve para gerar números aleatórios,
    // que neste caso, vai gerar números que vão servir de base para a nova ordenação das perguntas, já que a seleção das perguntas será sempre as 3 primeiras.
    // Além do Random, ainda vou precisar usar o método OrderBy que vai ordenar as perguntas usando como índice para a ordenação o resultado do Random.
    // Então basicamente tenho 2 ações aqui, onde uma é pedir que as perguntas sejam ordenadas (perguntas.OrderBy()) e dentro de OrderBy o parâmetro
    // de índice para esta ordenação será o resultado de random, ficando perguntas.OrderBy(x => random.Next()).Take(3).
    // Dentro de Random temos:
    // Next(): Gera um número inteiro aleatório não negativo (0 ou maior).
    // Next(int maxValue): Gera um número inteiro aleatório entre 0 (inclusivo) e maxValue (exclusivo).
    // Next(int minValue, int maxValue): Gera um número inteiro aleatório entre minValue (inclusivo) e maxValue (exclusivo).
    // NextDouble(): Gera um número de ponto flutuante aleatório entre 0.0 (inclusivo) e 1.0 (exclusivo).
    // E o termo Take() é referente ao método OrderBy, onde neste caso vai pegar as 3 primeiras posições Take(3).

    Random random = new Random();
    var perguntasAleatorias = perguntas.OrderBy(x => random.Next()).Take(3);

    int respostasCertas = 0;
    int i = 0;
    foreach (var pergunta in perguntasAleatorias)
    {
        i++;
        Console.WriteLine(pergunta.Key);
        string resposta = Console.ReadLine()!;
        if (resposta == pergunta.Value)
        {
            respostasCertas++;
        }
        if (i == 3)
        {
            break;
        }
    }
    if (respostasCertas == 3)
    {
        Console.WriteLine("Parabéns! Você acertou as 3 respostas!\nO prêmio é seu!");
        Console.Write("Pressione qualquer tecla para sair...");
        Console.ReadLine();
    } else if (respostasCertas == 0)
    {
        Console.WriteLine($"Infelizmente você não ganhou! Você não acertou nenhuma resposta.");
        Console.Write("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    } else
    {
        Console.WriteLine($"Infelizmente você não ganhou! Você acertou apenas {respostasCertas} respostas.");
        Console.Write("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    ExibirMenuPrincipal();
    return;
}

ExibirMenuPrincipal();
*/


// 4. Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.
/*
Dictionary<string, string> login = new Dictionary<string, string>();

login.Add("aa", "bb");

void ExibirLogo()
{
    Console.Clear();
    Console.WriteLine("****************");
    Console.WriteLine("Sistema de Login");
    Console.WriteLine("****************\n");

}
void ExibirMenuPrincipal()
{
    ExibirLogo();
    Console.WriteLine("1. Criar usuário e senha");
    Console.WriteLine("2. Acessar sistema");
    Console.WriteLine("9. Sair\n");
    Console.Write("Digite uma opção: ");
    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            {
                CriarUsuarioESenha();
            } break;
        case 2:
            {
                AcessarSistema();
            } break;
        case 9:
            {
                break;
            }
        default: break;
    }
}
void CriarUsuarioESenha()
{
    Console.Clear();
    ExibirLogo();
    Console.Write("Digite o usuário a ser criado: ");
    string usuario = Console.ReadLine()!;

    do
    {

        if (login.ContainsKey(usuario))
        {
            Console.WriteLine("Usuário já existente!");
            Console.WriteLine("Escolha um outro usuário ou 99 para sair: ");
            usuario = Console.ReadLine()!;
            if (usuario == "99")
            {
                ExibirMenuPrincipal();
                return;
            }
        } else
        {
            break;
        }
    } while (true);

    Console.Write("Digite a senha a ser criada: ");
    string senha = Console.ReadLine()!;

    login.Add(usuario, senha);
    Thread.Sleep(2000);
    Console.WriteLine("Usuário e Senha criados com sucesso!");
    
    Console.Write("Deseja criar um novo usuário?(S/N): ");
    string resposta = Console.ReadLine()!;
    resposta = resposta.ToLower();
    if (resposta == "s")
    {
        CriarUsuarioESenha();
        return;
    } else
    {
        ExibirMenuPrincipal();
        return;
    }

}
void AcessarSistema()
{

        Console.Write("Usuário: ");
        string acessoUsuario = Console.ReadLine()!;
        Console.Write("Senha: ");
        string acessoSenha = Console.ReadLine()!;
        
        if (login.ContainsKey(acessoUsuario))
        {
            if (login[acessoUsuario] == acessoSenha)
            {
                Console.WriteLine("Acesso Autorizado! Bem Vindo!");
            } else
            {
                Console.WriteLine("Acesso Negado!");
            }
        } else
        {
            Console.WriteLine("Acesso Negado 2!");
        }
    Console.WriteLine("Pressione enter para continuar...");
    Console.ReadKey();
    ExibirMenuPrincipal();
    return;

}

ExibirMenuPrincipal();
*/

// 5. Com base na lista de super carros fornecida, onde a chave é o nome do carro e os valores são quantas vezes esse carro foi vendido
// por ano, calcule a média de uma chave específica.

/*
Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>>
{
    {"Bugatti Veyron", new List<int> {10, 15, 12, 8, 5 } },
    {"Koeningsegg Agera RS", new List<int> {2, 3, 5, 6, 7 } },
    {"Lamborghini Aventador", new List<int> {20, 18, 22, 24, 16 } },
    {"Pagani Huayra", new List<int> {4, 5, 6, 5, 4 } },
    {"Ferrari LaFerrari", new List<int> {7, 6, 5, 8, 10 } }
};

Console.WriteLine("Relatório de Vendas!\n");

Console.WriteLine("Lista de carros vendidos:\n");
foreach (var carros in vendasCarros.Keys)
{
    Console.WriteLine(carros);
}

Console.Write("\nDeseja consultar a média de vendas de qual carro?: ");
string consulta = Console.ReadLine()!;

Thread.Sleep(1500);
double mediaVendas = vendasCarros[consulta].Average();

Console.WriteLine($"A média de vendas do carro {consulta} no último período foi {mediaVendas}");
Console.WriteLine();
Console.WriteLine("Tecle ENTER para sair");
Console.ReadKey();

*/