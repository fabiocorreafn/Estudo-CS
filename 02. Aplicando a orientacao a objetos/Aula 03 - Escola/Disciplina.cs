class Disciplina
{
    public string Nome { get; set; }
    public List<Aluno> Alunos { get; set; } = new List<Aluno>();

    public Disciplina(string nome)
    {
        // Este é o construtor que aceita 1 argumento (o nome)
        // Determina um ou mais parâmetros que serão passados pelo programa principal, no caso "nome",
        // e dentro do Construtor, esse "nome" passado está sendo atribuído ao campo "Nome" da classe Disciplina.
        Nome = nome;
    }

    public void AdicionarAluno(Aluno aluno)
    {
        Alunos.Add(aluno);
    }

    public void ExibirDisciplinasEAlunos(Disciplina disc)
    {

        Console.WriteLine($"\nDisciplina: {Nome}");
        if (Alunos.Count == 0)
        {
            Console.WriteLine($"A disciplina {Nome} está sem alunos matriculados");
        }
        else
        {
            foreach (var aluno in Alunos)
            {
                Console.WriteLine($"- {aluno.Nome}");
            }

        }
        Console.WriteLine();
    }
}


