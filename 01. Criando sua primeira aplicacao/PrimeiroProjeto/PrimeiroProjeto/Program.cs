// Screen Sound
using System;
string mensagemDeBoasVindas = "Boas Vindas ao Screend Sound!";
// List<string> listaDasBandas = new List<string>{"Bruno Mars", "Michael Jackson", "João Bosco"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Silk Sonic", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("Beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}
void ExibirOpcoesDoMenu()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirMediaDaBanda();
            break;
        case -1: Console.WriteLine("Até mais!"); 
            break;
        default: Console.WriteLine("Opção inválida!");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOPcao("Registro de Bandas");
    Console.Write("Digite o nome da Banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>()); 
    // listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A Banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOPcao("Estas são as Bandas registradas");
    //foreach (string banda in listaDasBandas)
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda};");
    }

    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]};");
    //}
    Console.Write("\nPressione qualquer tecla para voltar ao menu principal.");
    Console.ReadKey();
    ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
    //Digite a banda que deseja avaliar
    //Se a banda existir no dicionário, atribuir uma nota
    //Se a banda não existir, mostra uma mensagem e volta ao menu principal

    Console.Clear();
    ExibirTituloDaOPcao("Avaliar Banda");
    Console.Write("Digite o nome da Banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota você dá para a banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a Banda {nomeDaBanda}!");
        Thread.Sleep(5000);
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA Banda {nomeDaBanda} não foi encontrada!");
        Console.Write("Digite uma tecla para voltar ao menu principal...");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMediaDaBanda()
{
    //Digitar o nome da banda que deseja ver a média
    //Se a banda existir, calcular a média e mostrar na tela
    //Se a banda não existir, dar a opção de escolher outra banda ou voltar ao menu inicial

    Console.Clear();
    ExibirTituloDaOPcao("Média da Banda");
    Console.Write("\nQual Banda você deseja ver a média?: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        double mediaDaBanda = bandasRegistradas[nomeDaBanda].Average();
        Console.WriteLine($"A média da Banda {nomeDaBanda} é {mediaDaBanda}");
        Console.WriteLine();
        Console.Write("Pressione qualquer tecla para voltar ao Menu Principal");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA Banda {nomeDaBanda} não foi encontrada!");
        Console.Write("Deseja tentar novamente?(S/N): ");
        ConsoleKeyInfo tentarNovamente;
        tentarNovamente = Console.ReadKey();

        if (tentarNovamente.Key == ConsoleKey.S)
        {
            ExibirMediaDaBanda();
        }
        else
        {
            ExibirOpcoesDoMenu();
        }
    }
}

void ExibirTituloDaOPcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}


ExibirOpcoesDoMenu();