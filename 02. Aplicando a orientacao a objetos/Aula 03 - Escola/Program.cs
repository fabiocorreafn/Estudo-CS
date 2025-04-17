// >> ESCOLA
// 4. Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina.
//    A classe Aluno deve ter informações como nome, idade e notas.
//    A classe Professor deve ter informações sobre nome e disciplinas lecionadas.
//    A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.

string nomeProfessor;
string nomeDisciplina;
List<string> nomesDosProfessores = new List<string>();
List<string> nomesDasDisciplinas = new List<string>();
Professor professor = new Professor();

void Inicio()
{
    Console.Clear();
    Console.WriteLine(">>> BEM VINDO À ESCOLA <<<");
    Console.WriteLine("\n1. CADASTRO DE PROFESSORES");
    Console.WriteLine("2. CADASTRO DE DISCIPLINAS");
    Console.WriteLine("3. CADASTRO DE ALUNOS");
    Console.WriteLine("4. ATRIBUIR DISCIPLINAS AOS PROFESSORES");
    Console.Write("\n Digite sua opção: ");
    int opcao = int.Parse(Console.ReadLine()!);
    
    switch (opcao)
    {
        case 1:
            {
                CadastroProfessores();
            }break;
        case 2:
            {
                CadastroDisciplinas();
            }break;
        case 3:
            {
                CadastroAlunos();
            }break;
        case 4:
            {
                AtribuirDisciplinas();
            }break;
        case 9:
            {
                Encerramento();
            }break;
        default:
            {
                break;
            }
    }
}

void CadastroProfessores()
{
    Console.WriteLine("\n- CADASTRO DE PROFESSORES -");
    Console.WriteLine("Vamos cadastrar os 4 professores da escola.");

    // Pensei em duas opções para cadastrar os professores:
    /* 1. A cada nome de professor digitado, chamo o método para adicionar o professor na lista de professores em Professor.cs
     * 2. Recebo os nomes de todos os professores primeiro e depois chamo o método de adicionar professor em Professor.cs
     * Na opção 1 terei que fazer uma chamada de método a cada inserção de professor, ou seja, vou chamar o método várias vezes, neste caso
     * seria uma adição simples na classe Professor a cada chamada.
     * Na opção 2 terei apenas uma chamada de método, porém com as informações de vãrios professores para adicionar, neste caso
     * precisarei criar uma estrutura de repetição dentro da classe "Professor" que vai adicionando um a um.
    */

    for (int i = 0; i < 4; i++)
    {
        Console.Write($"\nDigite o nome do(a) professor(a) {i+1} de 4: ");
        nomeProfessor = Console.ReadLine()!;
        nomesDosProfessores.Add(nomeProfessor);
    }
}

void CadastroDisciplinas()
{
    Console.WriteLine("\n\n- CADASTRO DE DISCIPLINAS -");
    Console.WriteLine("Vamos cadastrar 4 disciplinas.");

    for (int i = 0; i < 4; i++)
    {
        Console.Write($"\nDigite o nome da disciplina {i + 1} de 4: ");
        nomeDisciplina = Console.ReadLine()!;
        nomesDasDisciplinas.Add(nomeDisciplina);
    }
}

void AtribuirDisciplinas()
{
    //professor.AtribuirDisciplinas(nomesDosProfessores, nomesDasDisciplinas);
    Console.Clear();
    Console.WriteLine("- ATRIBUIÇÃO DE DISCIPLINAS AOS PROFESSORES -");
    Console.WriteLine("\nDISCIPLINAS: \n");
    Console.WriteLine(new string('-', 45), "\n");
    foreach (var i in nomesDosProfessores)
    {
        int k = 1;
        foreach (var j in nomesDasDisciplinas)
        {
            Console.WriteLine($"{k}. {j};");
            k++;
        }
        Console.WriteLine($"Professor(a): {i} ");
        Console.WriteLine($"Disciplinas: ");
        Console.WriteLine();
        Console.Write("Digite o código da disciplina para atribuir ao professor\n Quando terminar digite 9: ");
        int codigo = int.Parse(Console.ReadLine()!);
        if (codigo == 9)
        {
            Inicio();
        }
        else
        {
            professor.Nome = i;
            
            // CONTINUAR DAQUI
            // PRECISO ACHAR UM JEITO DE IR ATRIBUINDO CADA UMA DAS DISCIPLINAS AOS PROFESSORES
        }
    }

}