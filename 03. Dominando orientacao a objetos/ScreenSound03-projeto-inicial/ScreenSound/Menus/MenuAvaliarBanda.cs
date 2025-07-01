using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            //Aqui em "Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!)" estou passando a nota digitada como string para o método "Parse"
            //dentro do método público estático "Avaliacao" e lá dentro transformando em inteiro. Na saída do método estou retornando
            //um novo objeto do tipo Avaliacao com o parâmetro Nota já como sendo inteiro, e este valor inteiro está sendo armazenado
            //dentro do objeto nota. É basicamente uma conversão de string para inteiro de forma personalizada, ou seja, posso usar o Parse 
            //através de uma classe que eu criei.
            int notaRegistrada = banda.AdicionarNota(nota);
            Console.WriteLine($"\nA nota {notaRegistrada} foi registrada com sucesso para a banda {nomeDaBanda}");
            //Aqui eu quero que apareça na tela a nota "corrigida", ou seja, se foi digitado um valor maior que 10
            //que apareça 10, e se for menor que 0, que apareça 0. Quando faço "int notaRegistrada = banda.AdicionarNota(nota);"
            //estou chamando o método AdicionarNota passando o valor digitado (nota) mesmo que fora dos limites. Lá no método AdiconarNora
            //vou verificar se está entre 0 e 10 e se não estiver vou registrar a nota 0 ou 10 se estiver fora dos limites. Ao sair do método
            //vou retornar 0 ou 10 a depender do caso e, ao voltar para o Programa armazenar este valor retornado dentro de notaRegistrada,
            //que será usada para escrever na tela o valor da nota que, de fato, foi registrada.

            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
