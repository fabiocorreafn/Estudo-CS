// DESAFIO AULA 03 - PROGRAMA CONTA BANCÁRIA

Titular titular1 = new("Fábio Corrêa", 12345678900, "Av. Copacabana, 41");
//titular1.nomeDoTitular = "Fábio Corrêa";
//titular1.cpfDoTitular = 12345678900;

//Instanciar uma conta e exibir suas informações na tela, utilizando construtores.
Conta conta1 = new(5566, "Um", 9876, 2500, 10000)
{
    titular = titular1,
};

Console.WriteLine(conta1.ExibirInformacoesDaConta());

//conta1.titular = titular1;
//conta1.numeroDaConta = 9876;
//conta1.numeroDaAgencia = 5566;
//conta1.nomeDaAgencia = "Um";
//conta1.saldo = 2500;
//conta1.limite = 10000;

