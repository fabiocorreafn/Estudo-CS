using ScreenSound.Modelos;
using System.Xml;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
   
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            Console.WriteLine("\nDiscografia:");
            foreach (Album album in banda.Albuns)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
            }
            Console.Write("\nDigite uma tecla para votar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.Write("\nDigite uma tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

/* Continuar...
 * Quero que:
 *  se não existir notas no álbum, apareça NOME DO ALBUM -> NÃO EXITEM NOTAS PARA ESTE ÁLBUM
 *  se só houver notas 0, que exiba NOME DO ALBUM -> 0
 *  Isso porque a ausência de notas é diferente de só existirem notas 0
 *  