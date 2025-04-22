// >> ESCOLA
// 4. Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina.
//    A classe Aluno deve ter informações como nome, idade e notas.
//    A classe Professor deve ter informações sobre nome e disciplinas lecionadas.
//    A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.

string nomeProfessor;
string nomeDisciplina;
List<string> nomesDosProfessores = new List<string>();
List<string> nomesDasDisciplinas = new List<string>();
List<Professor> professores = new List<Professor>();
List<Aluno> alunos = new List<Aluno>();
List<Disciplina> disciplinas = new List<Disciplina>();

void Cabecalho()
{
    Console.Clear();
    Console.WriteLine(new string('-', 40));
    Console.WriteLine(">>> BEM VINDO À ESCOLA SABE-SE LÁ <<<");
    Console.WriteLine(new string('-', 40));
}
void Inicio()
{
    Cabecalho();
    Console.WriteLine("1. CADASTRAR PROFESSORES");
    Console.WriteLine("2. CADASTRAR DISCIPLINAS");
    Console.WriteLine("3. CADASTRAR ALUNOS");
    Console.WriteLine("4. ATRIBUIR DISCIPLINAS AOS PROFESSORES");
    Console.WriteLine("5. MATRICULAR ALUNOS NAS DISCIPLINAS");
    Console.WriteLine("6. EXIBIR LISTA DE PROFESSORES E DISCIPLINAS");
    Console.WriteLine("7. EXIBIR DISCIPLINAS E ALUNOS MATRICULADOS");
    Console.WriteLine("9. SAIR");
    Console.WriteLine(new string('-', 40));
    Console.Write("Digite sua opção: ");
    int opcao = int.Parse(Console.ReadLine()!);
    
    switch (opcao)
    {
        case 1:
            {
                CadastrarProfessores();
            }break;
        case 2:
            {
                CadastrarDisciplinas();
            }break;
        case 3:
            {
                CadastrarAlunos();
            }break;
        case 4:
            {
                AtribuirDisciplinas();
            }break;
        case 5:
            {
                MatricularAlunos();
            }break;
        case 6:
            {
                ExibirProfessoresEDisciplinas();
            }break;
        case 7:
            {
                ExibirDisciplinasEAlunos();
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

void CadastrarProfessores()
{
    Cabecalho();
    Console.WriteLine(">> CADASTRO DE PROFESSORES\n");

    /* Pensei em duas opções para cadastrar os professores:
     * Opção 1:
     * A cada nome de professor digitado, chamo o método para adicionar o professor na lista de professores em Professor.cs
     * 
     * Opçao 2:
     * Recebo os nomes de todos os professores primeiro e depois chamo o método de adicionar professor em Professor.cs
     *
     * Na opção 1 terei que fazer uma chamada de método a cada inserção de professor, ou seja, vou chamar o método várias vezes, neste caso
     * seria uma adição simples na classe Professor a cada chamada.
     * 
     * Na opção 2 terei apenas uma chamada de método, porém com as informações de vãrios professores para adicionar, neste caso
     * precisarei criar uma estrutura de repetição dentro da classe "Professor" que vai adicionando um a um.
     * 
     * Escolhi fazer a Opção 2.
     * Como deu um trabalhão pra entender como fazer, fiz só essa mesmo.
     * A opção 1 talvez faça depois.
    */

    while (true)
    {
        Console.Write("Digite o nome do professor (ou 9 para SAIR): ");
        nomeProfessor = Console.ReadLine()!;

        if (nomeProfessor == "9")
        {
            Inicio();
            break;
        }
        else
        {
            nomesDosProfessores.Add(nomeProfessor);
            Console.WriteLine($"Professor {nomeProfessor} cadastrado com sucesso!");
        }
    }

    foreach (var nomeProf in nomesDosProfessores)
    {
        Professor professor = new(nomeProf);
        professores.Add(professor);
    }
}
void CadastrarDisciplinas()
{
    Cabecalho();
    Console.WriteLine("CADASTRO DE DISCIPLINAS\n");
    
    while (true)
    {
        Console.Write("Digite o nome da Disciplina (ou 9 para SAIR): ");
        nomeDisciplina = Console.ReadLine()!;

        if (nomeDisciplina == "9")
        {
            break;
        }else
        {
            nomesDasDisciplinas.Add(nomeDisciplina);
            Console.WriteLine($"Disciplina {nomeDisciplina} cadastrada com sucesso.");

        }
    }

    foreach (var disc in nomesDasDisciplinas)
    {
        Disciplina disciplina = new(disc);
        disciplinas.Add(disciplina);
        
    }

    Inicio();
}
void CadastrarAlunos()
{
    while (true)
    {
        Cabecalho();
        Console.WriteLine("CADASTRO DE ALUNOS\n");
        Console.Write("Nome do aluno (ou Digite 9 para sair): ");
        string nomeAluno = Console.ReadLine()!;
        if (nomeAluno == "9")
        {
            Inicio();
            break;
        }
        else
        {
            Aluno aluno = new(nomeAluno);
            //Console.Write("Idade: ");
            //aluno.Idade = int.Parse(Console.ReadLine()!);
            alunos.Add(aluno);
            Console.WriteLine($"Aluno {nomeAluno} cadastrado com sucesso.");
        }
    }

    Inicio();
    
}
void AtribuirDisciplinas()
{    
    foreach (var nomeProf in nomesDosProfessores)
    {
        Cabecalho();
        Console.WriteLine("ATRIBUIÇÃO DE DISCIPLINAS\n");
        Professor professor = new(nomeProf);
        Console.WriteLine($"Professor selecionado: {nomeProf.ToUpper()}\n");
        Console.WriteLine($"Quais são as disciplinas do(a) professor(a) {nomeProf.ToUpper()}?");
        for (int i = 0; i < nomesDasDisciplinas.Count; i++)
        {
            Console.WriteLine($"> {i+1}. {nomesDasDisciplinas[i]}");
        }
        Console.WriteLine("\nDigite os códigos de cada disciplina separado por vírgula. Ex.: 1, 2, 3");
        Console.Write("Códigos: ");
        string codigos = Console.ReadLine()!;
        string[] indexCodigos = codigos.Split(',');
        
        foreach (var i in indexCodigos)
        {
            int.TryParse(i.Trim(), out int indice);
            string nomeDisciplina = nomesDasDisciplinas[indice - 1];
            
            professor.AtribuirDisciplinas(new Disciplina(nomeDisciplina));
        }
        professores.Add(professor);
        Console.WriteLine();
    }
    Inicio();
}
void MatricularAlunos() 
{
    Cabecalho();
    Console.WriteLine("MATRICULAR ALUNOS");
    Console.WriteLine();

    int i = 0;
    
    Console.WriteLine("DISCIPLINAS:");
    foreach (var disc in disciplinas)
    {
        i++;
        Console.WriteLine($"> {i}. {disc.Nome}");
    }
    
    Console.Write("\nSelecione a disciplina para matricular os alunos: ");
    int disciplinaEscolhida = int.Parse(Console.ReadLine()!);
    Disciplina disciplina = disciplinas[disciplinaEscolhida - 1];

    Cabecalho();
    Console.WriteLine("MATRICULAR ALUNOS\n");
    Console.WriteLine($"Disciplina selecionada: {disciplinas[disciplinaEscolhida-1].Nome}\n");
    Console.WriteLine("ALUNOS;");

    i = 0;
    foreach (var alu in alunos)
    {
        i++;
        Console.WriteLine($"> {i}. {alu.Nome}");
    }

    Console.Write("\nDigite o código dos alunos para matricular separado por vírgula. (Ex. 1, 2, 3): ");
    string codigosAlunos = Console.ReadLine()!;
    string[] indiceAlunos = codigosAlunos.Split(',');

    foreach (var indice in indiceAlunos)
    {
        int.TryParse(indice.Trim(), out int ind);
        Aluno aluno = alunos[ind - 1];
        disciplina.AdicionarAluno(aluno);
        
    }

    Console.WriteLine("Alunos matriculados com sucesso!");
    Console.Write("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
    Inicio();
}
void ExibirDisciplinasEAlunos()
{
    foreach (var disc in disciplinas)
    {
        disc.ExibirDisciplinasEAlunos(disc);
    }
    Console.Write("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
    Inicio();

    /* Criei esse código abaixo, aqui mesmo no Program.cs, para listar os alunos matriculados em cada disciplina.
     * Depois vi que talvez seria melhor levar este método para dentro de Disciplina.cs, e assim o fiz, então agora
     * estou apenas chamando o método para ExibirDisciplinasEAlunos dentro da classo Disciplina. Assim fica muito mais simples
     * de escrever o código porque não preciso de ficar entrando nas referências como disc.Nome, etc... porque lá dentro
     * da classe é só escrever direto Nome. Não apaguei o código daqui para mantê-o como referência de estudo.
    
    //foreach (var disc in disciplinas)
    //{
    //    Console.WriteLine($"Disciplina: {disc.Nome}");

    //    if (disc.Alunos.Count == 0)
    //    {
    //        Console.WriteLine($"A disciplina {disc.Nome} está sem alunos matriculados");
    //    }
    //    else
    //    {
    //        foreach (var aluno in disc.Alunos)
    //        {
    //            Console.WriteLine($"- {aluno.Nome}");
    //        }

    //    }
    //    Console.WriteLine();
    //}
    //Console.Write("Pressione qualquer tecla para continuar...");
    //Console.ReadKey();
    
    */
}
void ExibirProfessoresEDisciplinas()
{
    Cabecalho();
    Console.WriteLine("- LISTA DE PROFESSORES E DISCIPLINAS -");
    Console.WriteLine();
    foreach (var prof in professores)
    {
        Console.WriteLine($"PROFESSOR: {prof.Nome}");
        Console.WriteLine("DISCIPLINA(S):");
        for (int i = 0; i < prof.disciplinas.Count; i++)
        {
            Console.WriteLine($"- {prof.disciplinas[i].Nome}");
        }
        Console.WriteLine();
    }

    Console.Write("Pressione qualquer tecla para voltar ao Menu Inicial...");
    Console.ReadKey();
    Inicio();
}
void Encerramento()
{
    Console.Write("\nAté breve!\n");
}

Inicio();