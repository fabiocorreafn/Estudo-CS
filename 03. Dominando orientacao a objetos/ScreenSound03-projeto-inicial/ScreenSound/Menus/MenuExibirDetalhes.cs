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
            /* Dentro do bloco IF abaixo vou verificar se a BANDA já foi avaliada alguma vez, ou seja, se existe pelo menos uma nota para a banda.
             * Se não existir notas na banda, vai exibir: NÃO EXISTEM NOTAS PARA A BANDA "XYZ"
             * Se só houver notas 0, vai exibir: A MÉDIA DA BANDA "XYX" É 0.
             * Isso é porque considero que a ausência de notas é diferente de só existirem notas 0
             */
            Banda banda = bandasRegistradas[nomeDaBanda];
            if (banda.Media == -1)
            {
                Console.WriteLine($"\nNão existem notas para a Banda {nomeDaBanda}.");
            }
            else
            {
                Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            }

            Console.WriteLine("\nDiscografia:");
            foreach (Album album in banda.Albuns)
            {
                 /* Dentro do bloco IF abaixo vou verificar se o ÁLBUM já foi avaliado alguma vez, ou seja, se existe pelo menos uma nota para ele.
                  * Se não existir notas no álbum, vai exibir: NOME DO ALBUM -> NÃO EXITEM NOTAS PARA ESTE ÁLBUM
                  * Se só houver notas 0, vai exibir NOME DO ALBUM -> 0
                  * Isso é porque considero que a ausência de notas é diferente de só existirem notas 0
                  */
                if (album.Media == -1)
                {
                    Console.WriteLine($"{album.Nome} -> Não existem notas para este Álbum");
                }
                else
                {
                    Console.WriteLine($"{album.Nome} -> {album.Media}");
                }
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

