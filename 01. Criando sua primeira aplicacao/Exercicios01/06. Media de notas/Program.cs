
 
var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
    { "Ana", new Dictionary<string, List<int>> {{ "C#", new List<int> { 8, 7, 6 } },
        { "Java", new List<int> { 7, 6, 5 } },
        { "Python", new List<int> { 9, 8, 8 } }
    }},
    { "Maria", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 6, 5, 4 } },
        { "Java", new List<int> { 8, 7, 6 } },
        { "Python", new List<int> { 6, 10, 5 } }
    }},
    { "Luiza", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 2, 3, 10 } },
        { "Java", new List<int> { 8, 8, 8 } },
        { "Python", new List<int> { 7, 7, 7 } }
    }}
};

//Mostra a média de um aluno específico em uma matéria específica pré estabelecida

double mediaMaria = notasAlunos["Maria"]["C#"].Average();
Console.WriteLine($"A Média de Maria em C# é: {mediaMaria}");

//Mostra a média de um aluno numa determinada matéria digitado pelo usuário


Console.Write("Deseja saber a média de qual aluno?(Ana, Maria, Luiza): ");
string nomeAluno = Console.ReadLine()!;
Console.Write("Qual matéria deseja?(C#, Java, Python: ");
string nomeMateria = Console.ReadLine()!;

double mediaAluno = notasAlunos[nomeAluno][nomeMateria].Average();
Console.WriteLine($"A Média de {nomeAluno} em {nomeMateria} é: {mediaAluno}");

//Mostra todas as médias de todos os alunos

foreach (string aluno in notasAlunos.Keys)
{
    Console.WriteLine($"Aluno(a): {aluno}");
    foreach (string materia in notasAlunos[aluno].Keys)
    {
        Console.WriteLine($"    > Matéria: {materia}");
        Console.WriteLine($"    > Média: {notasAlunos[aluno][materia].Average():F2}\n");
    }
}