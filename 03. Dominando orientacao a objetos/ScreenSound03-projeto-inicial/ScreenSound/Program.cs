using ScreenSound.Modelos;
using ScreenSound.Menus;

Banda ira = new Banda("Ira!");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(6));
Banda beatles = new("The beatles");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);


Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());

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
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }

        /* O comand SWITCH abaixo foi substituído pela criação do menu através de um DICIONÁRIO (Dictionary<int, Menu> opcoes = new();) onde terei
         * para a Chave, um número inteiro correspondente ao item do menu, e para o Valor, um objeto do tipo Menu que será executado de acordo com o item 
         * escolhido pelo usuário.
         * 
         */
        
        //switch (opcaoEscolhidaNumerica)
        //{
        //    case 1:
        //        MenuRegistrarBanda menu1 = new();
        //        menu1.Executar(bandasRegistradas);
        //        ExibirOpcoesDoMenu();
        //        break;
        //    case 2:
        //        MenuRegistrarAlbum menu2 = new();
        //        menu2.Executar(bandasRegistradas);
        //        ExibirOpcoesDoMenu();
        //        break;
        //    case 3:
        //        MenuMostrarBandas menu3 = new();
        //        menu3.Executar(bandasRegistradas);
        //        ExibirOpcoesDoMenu();
        //        break;
        //    case 4:
        //        MenuAvaliarBanda menu4 = new();
        //        menu4.Executar(bandasRegistradas);
        //        ExibirOpcoesDoMenu();
        //        break;
        //    case 5:
        //        MenuExibirDetalhes menu5 = new();
        //        menu5.Executar(bandasRegistradas);
        //        ExibirOpcoesDoMenu();
        //        break;
        //    case -1:
        //        MenuSair menuSair = new();
        //        menuSair.Executar(bandasRegistradas);
        //        break;
        //    default:
        //        Console.WriteLine("Opção inválida");
        //        break;
        //}
}

ExibirOpcoesDoMenu();