class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Notas { get; set; }

    public Aluno(string nome)
    {
        Nome = nome;
    }
}