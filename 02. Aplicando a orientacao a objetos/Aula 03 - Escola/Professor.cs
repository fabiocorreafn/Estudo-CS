using System;

class Professor
{
    public string Nome { get; set; }

    public List<Disciplina> disciplinas { get; set; }

   //public void AtribuirDisciplinas(List<string> nomesDosProfessores, List<string> nomesDasDisciplinas)
   //{
   //     Console.Clear();
   //     Console.WriteLine("- ATRIBUIÇÃO DE DISCIPLINAS AOS PROFESSORES -");
   //     Console.WriteLine("\nDISCIPLINAS: \n");
   //     Console.WriteLine(new string('-', 45), "\n");
   //     foreach (var i in nomesDosProfessores)
   //     {
   //         int k = 1;
   //         foreach (var j in nomesDasDisciplinas)
   //         {
   //             Console.WriteLine($"{k}. {j};");
   //             k++;
   //         }
   //         Console.WriteLine($"Professor(a): {i} ");
   //         Console.WriteLine($"Disciplinas: ");
   //         Console.WriteLine();
   //         Console.Write("Digite o código da disciplina para atribuir ao professor\n Quando terminar digite 9: ");
   //         int codigo = int.Parse(Console.ReadLine()!);
   //         if (codigo == 9)
   //         {
                
   //         }
   //         else
   //         {

   //         }
   //     }
   //}
}