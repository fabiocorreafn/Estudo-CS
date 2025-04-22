using System;
using System.ComponentModel.Design;
using System.Threading.Channels;

class Professor
{
    public string Nome { get; set; }
    public List<Disciplina> disciplinas = new List<Disciplina>();

    public Professor(string nome)
    {
        // Este é o construtor que aceita 1 argumento (o nome)
        // Determina um ou mais parâmetros que serão passados pelo programa principal, no caso "nome",
        // e dentro do Construtor, esse "nome" passado está sendo atribuído ao campo "Nome" da classe Professor.
        Nome = nome;
    }

    public void AtribuirDisciplinas(Disciplina disciplina)
    {
        disciplinas.Add(disciplina);
    }
}