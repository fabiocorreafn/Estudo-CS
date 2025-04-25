using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
public class Estoque
{
    public List<Produto> produtos = new List<Produto>();
    public int codigoLoja { get; set; }
    public void AdicionarNovoProduto(Produto produto)
    {
        produtos.Add(produto);
    }

 
    /* Usando o FIND() COM lambda
    Usando com lambda, o "private bool" deve ficar fora do método "RemoverProduto"
    */
    //private bool ProdutoTemCodigo(Produto p, int codigo)
    //{
    //    return p.CodigoProduto == codigo;
    //}
    
    public void RemoverProduto(int codigoParaRemover)
    {
        /* Usando o FOR:
        //Este FOR vai varrer a lista "produtos" usando a iteração do índice "i" e vai comparar o código digitado pelo usuário com o campo CodigoProduto.
        //O índice vai ser usado apenas para ir iterando, passando pelo lista um a um. O índice não será usado como referência ao determinado item da lista
        //porque o código do produto não tem relação com o índice.
        */

        for (int i = 0; i < produtos.Count; i++)
        {
            if (produtos[i].CodigoProduto == codigoParaRemover)
            {
                Console.Write($"Tem certeza que deseja EXCLUIR o produto {produtos[i].NomeProduto}? (S/N): ");
                ConsoleKeyInfo confirmaExclusao = Console.ReadKey();
                if (confirmaExclusao.Key == ConsoleKey.S)
                {
                    {
                        Console.WriteLine("\n\nAchei o produto para excluir! Aguarde um instante...");
                        Thread.Sleep(2000);
                        produtos.Remove(produtos[i]);
                        Console.WriteLine("Produto excluído com sucesso!");
                        Console.Write("\nPressione qualquer tecla para voltar ao Menu...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("\n\nExclusão não realizada. Operação cancelada pelo usuário.");
                    Console.Write("\nPressione qualquer tecla para voltar ao Menu...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("\n\nProduto não encontrado.");
                Console.Write("\nPressione qualquer tecla para voltar ao Menu...");
                Thread.Sleep(3000);
                Console.ReadKey();
            }
        }

        /* Esta é uma outra maneira de fazer pergunta de confirmação de S/N:
         * char confirmaExclusao = char.Parse(Console.ReadLine()!);
         * if (confirmaExclusao == 's' || confirmaExclusao == 'S') {}
         * neste caso o usuário deve digitar a resposta e teclar ENTER. No caso que utilizei no programa abaixo, basta apenas digitar a letra da resposta (S/N),
         * seja maiúscula ou minúscula, sem precisar dar ENTER e o programa já lê.
        */

        /* Usando LINQ:
         * LINQ significa Language Integrated Query (Consulta Integrada à Linguagem).
         * O LINQ permite consultar dados de coleções (listas, arrays, dicionários etc.) de uma forma mais descritiva e parecida com SQL, usando palavras como
         * where, select, first, orderby... Usar a LINQ deixa o código mais legível, usa menos linhas para fazer buscas ou filtros e é ideal para quando se trabalha
         * com coleções de objetos, como neste caso onde usamos List<Produto>.

        var consulta = from p in produtos
                       where p.CodigoProduto == codigoParaRemover
                       select p;

        Produto produtoEncontrado = consulta.FirstOrDefault();

        if (produtoEncontrado != null)
        {
            //produtos.Remove(produtoEncontrado);
            Console.WriteLine("Achei o produto para excluir! (TESTE)"); 
            Console.WriteLine("Produto removido com sucesso");
        } else
        {
            Console.WriteLine("Produto não encontrado");
        }
        */

        /* Usando o FIND() COM lambda
         * Usando com lambda, o "private bool" deve ficar fora do método "RemoverProduto"
        
        Produto produto = produtos.Find(p => ProdutoTemCodigo(p, codigoParaRemover));
        if (produto != null)
        {
            //produtos.Remove(produtoEncontrado);
            Console.WriteLine("Achei o produto para excluir! (TESTE)");
            Console.WriteLine("Produto removido com sucesso");
        }
        else
        {
            Console.WriteLine("Produto não encontrado");
        }
        */


        /* Usando o FIND() SEM lambda
         * Find() é um método da classe List que serve para buscar o primeiro elemento que satisfaça uma condição.
         * Ou seja, ele percorre a lista até encontrar o primeiro item que atenda ao critério que você definir e retorna este item.
         * Se não encontrar nada, retorna null.
         * Primeiro criamos a função de condição separadamente
         * 
        
        private bool ProdutoTemCodigo(Produto p)
        {
            return p.CodigoProduto == codigoBuscado;
        }
        //Agora vem o desafio: como passar o "codigoBuscado" para essa função?
        //A função ProdutoTemCodigo só aceita o parâmetro Produto, mas a gente precisa comparar com o codigoParaRemover.
        //A solução é criar a função dentro do método, usando closure (variável externa).

        bool Condicao(Produto p)
        {
            return p.CodigoProduto == codigoParaRemover;
        }

        Produto produto = produtos.Find(Condicao);

        if (produto != null)
        {
            Console.Write($"Tem certeza que deseja EXCLUIR o produto {produto.NomeProduto}? (S/N): ");
            ConsoleKeyInfo confirmaExclusao = Console.ReadKey();
            if (confirmaExclusao.Key == ConsoleKey.S)
            {
                //produtos.Remove(produtoEncontrado);
                Console.WriteLine("\n\nAchei o produto para excluir! (TESTE)");
                Console.WriteLine("Produto removido com sucesso");
                Console.Write("\nPressione qualquer tecla para voltar ao Menu...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\n\nProduto não excluído.");
                Console.Write("\nPressione qualquer tecla para voltar ao Menu...");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("Produto não encontrado");
            Console.Write("\nPressione qualquer tecla para voltar ao Menu...");
            Console.ReadKey();
        }
        */
    }

    public void ExibirEstoque()
    {
        Console.WriteLine("Lista de produtos em estoque:\n");
        Console.WriteLine("{0, -6}{1, 12}{2, 15}{3, 12}", "CÓD.", "PRODUTO", "QUANTIDADE", "PREÇO");
        foreach (Produto produto in produtos)
        {
            Console.WriteLine("{0, -6}{1, 12}{2, 15}{3, 12}", produto.CodigoProduto, produto.NomeProduto, produto.QtdeEstoque, produto.Preco);
        }
    }
}