// Exercícios 01 - Nota média

//using System.ComponentModel.Design;

int notaMedia;

Console.Write("Digite a nota do aluno: ");
notaMedia = int.Parse(Console.ReadLine()!);


if (notaMedia >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação!");
} else
    {
    Console.WriteLine("Aluno em recuperação!");
    }