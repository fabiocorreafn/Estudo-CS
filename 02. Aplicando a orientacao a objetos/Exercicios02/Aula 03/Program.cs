// DESAFIO AULA 03 - PROGRAMA CONTA BANCÁRIA

Titular titular1 = new Titular();
titular1.nomeDoTitular = "Fábio Corrêa";
titular1.cpfDoTitular = 12345678900;

Conta conta1 = new Conta();
conta1.titular = titular1;
conta1.numeroDaConta = 9876;
conta1.numeroDaAgencia = 5566;
conta1.nomeDaAgencia = "Um";
conta1.saldo = 2500;
conta1.limite = 10000;

Console.WriteLine(conta1.ExibirInformacoesDaConta());


