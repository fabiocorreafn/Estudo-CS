using static System.Net.Mime.MediaTypeNames;

// >> CONTA BANCÁRIA
// 1. Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta, saldo e limite,
//    bem como um método que devolva as informações da conta de forma detalhada.

// 2. Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.
class Conta
{
    public Titular titular;
    public int numeroDaAgencia { get; set; }
    public string nomeDaAgencia { get; set; }
    public int numeroDaConta { get; set; }
    public double saldo { get; set; }
    public double limite { get; set; }

    public string ExibirInformacoesDaConta()
    {
         return $"Informações da conta: \nTitular: {titular.nomeDoTitular} \nCPF: {string.Format("{0:000'.'000'.'000'-'00}", titular.cpfDoTitular)}\nConta: {numeroDaConta} \nAgência: {numeroDaAgencia} - Agência {nomeDaAgencia} \nSaldo: {saldo.ToString("C")} \nLimite: {limite.ToString("C")}";
    }
}
class Titular
{
    public string nomeDoTitular;
    public long cpfDoTitular;
}

// >>>>> PRECISO AVALIAR AS PROPRIEDADES COMO PÚBLICAS OU PRIVADAS NA ATIVIDADE ACIMA! <<<<<
