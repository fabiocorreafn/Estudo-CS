//Criar um construtor para a classe Titular, que inicialize todas as suas propriedades
class Titular
{
    public Titular(string nome, long cpf, string endereco)
    {
        NomeDoTitular = nome;
        CpfDoTitular = cpf;
        EnderecoDoTitular = endereco;
    }
    public string NomeDoTitular { get; }
    public long CpfDoTitular { get; }
    public string EnderecoDoTitular { get; }
}