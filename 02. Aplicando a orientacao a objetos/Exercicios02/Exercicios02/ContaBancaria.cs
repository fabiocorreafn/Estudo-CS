using System.Globalization;

class ContaBancaria
{
    public int numeroConta;
    public string titular;
    public long cpf;
    public double saldo;
    public int senha;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Conta: {string.Format("{0:0000}", numeroConta)}");
        Console.WriteLine($"CPF: {string.Format("{0:000'.'000'.'000'-'00}", cpf)}");
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo: {saldo.ToString("C")}");
    }
}