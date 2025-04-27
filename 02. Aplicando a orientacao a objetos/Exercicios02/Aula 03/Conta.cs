using static System.Net.Mime.MediaTypeNames;

// >> CONTA BANCÁRIA
// 1. Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta, saldo e limite,
//    bem como um método que devolva as informações da conta de forma detalhada.

// 2. Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.
class Conta
{
    public Titular titular;
    public int NumeroDaAgencia { get; }
    public string NomeDaAgencia { get; }
    public int NumeroDaConta { get; }
    public double Saldo { get; }
    public double Limite { get; }

    //Criar um construtor para a classe Conta que inicialize todas as suas propriedades
    public Conta(int numeroAg, string nomeAg, int numConta, double saldo, double limite)
    {
        NumeroDaAgencia = numeroAg;
        NomeDaAgencia = nomeAg;
        NumeroDaConta = numConta;
        Saldo = saldo;
        Limite = limite;
    }
    public string ExibirInformacoesDaConta()
    {
         return $"Informações da conta: \nTitular: {titular.NomeDoTitular} \nCPF: {string.Format("{0:000'.'000'.'000'-'00}", titular.CpfDoTitular)}\nConta: {NumeroDaConta} \nAgência: {NumeroDaAgencia} - Agência {NomeDaAgencia} \nSaldo: {Saldo.ToString("C")} \nLimite: {Limite.ToString("C")}";
    }
}
//class Titular
//{
//    public string nomeDoTitular;
//    public long cpfDoTitular;
//}

// >>>>> PRECISO AVALIAR AS PROPRIEDADES COMO PÚBLICAS OU PRIVADAS NA ATIVIDADE ACIMA! <<<<<
