using static System.Net.Mime.MediaTypeNames;
// DESAFIOS AULA 06

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

// PRECISO AVALIAR AS PROPRIEDADES COMO PÚBLICAS OU PRIVADAS NA ATIVIDADE ACIMA!






// 4. Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina.
//    A classe Aluno deve ter informações como nome, idade e notas.
//    A classe Professor deve ter informações sobre nome e disciplinas lecionadas.
//    A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.

// 5. Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio.
//    A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos.
//    Os pedidos podem estar associados a uma mesa.