// 1. Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
// 2. Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
// 3. Desenvolver um método da classe Conta que exibe suas informações.
/*

ContaBancaria conta1 = new ContaBancaria();

conta1.numeroConta = 1;
conta1.titular = "Fábio Corrêa";
conta1.saldo = 100;
conta1.senha = 123;
conta1.cpf = 10058130780;

//Console.WriteLine($"Conta: {conta1.numeroConta}");
//Console.WriteLine($"Conta: {string.Format("{0:0000}", conta1.numeroConta)}");
//Console.WriteLine($"CPF: {string.Format("{0:000'.'000'.'000'-'00}", conta1.cpf)}");
//Console.WriteLine($"Titular: {conta1.titular}");
//Console.WriteLine($"Saldo: R$ {conta1.saldo}");

conta1.ExibirInformacoes();

// Esse string.Format acima é para que os zeros à esquerda sejam impressos na tela
// Na sintaxe, o primeiro zero antes dos ":" indica com qual caracter/número serão preenchidas as posições
// Os zeros após o ":" indicam quantas posições no total o número vai ter
// No caso, quero que apareça na tela o número de conta 0001, logo são 4 algarismos no total, mostrando os zeros à esquerda, por isso fica 0:0000
// Essa formatação deve estar entre "{}".
// Em seguida coloca-se vírgula (,) e depois a variável que sofrerá a formatação. No caso, conta1.numeroConta.
// Caso queira ainda adicionar algum tipo de máscara, como por exemplo os pontos e traço entre os números de um cpf, posso adicionar
// essa formatação string.Format("{0:000.000.000-00}", conta1.cpf).
*/


// 4. Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar
/*     

Carro carro1 = new Carro();
Carro carro2 = new Carro();

carro1.Marca = "BYD";
carro1.Modelo = "Yuan";
carro1.Ano = 2025;

carro2.Marca = "Citroen";
carro2.Modelo = "Air Cross";
carro2.Ano = 2015;

ConsoleKeyInfo ligar;
Console.Write($"Deseja ligar o {carro1.Marca} {carro1.Modelo}?(s/n): ");
ligar = Console.ReadKey();

if (ligar.Key == ConsoleKey.S)
{
    carro1.Ligado = true;
}
else
{
    carro1.Ligado = false;
}

Console.Write($"\nDeseja ligar o {carro2.Marca} {carro2.Modelo}?(s/n): ");
ligar = Console.ReadKey();

if (ligar.Key == ConsoleKey.S)
{
    carro2.Ligado = true;
}else
{
    carro2.Ligado = false;
}

Console.WriteLine();
Console.WriteLine();

carro1.Acelerar();
carro2.Acelerar();

Console.WriteLine();

carro1.Frear();
carro2.Frear();

Console.WriteLine();

carro1.Buzinar();
carro2.Buzinar();

Console.WriteLine();

carro1.ExibirInformacoesDosCarros();
carro2.ExibirInformacoesDosCarros();
*/

// 5. Código de programa para fazer o desafio de criar classe Produto
/*
Produto produto1 = new Produto();
Produto produto2 = new Produto();

produto1.marca = "Apple";
produto1.nome = "iPhone";
produto1.PrecoEntrada = 2000;
produto1.EstoqueEntrada = 30;

Console.WriteLine(produto1.InformacoesDetalhadas);
*/


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


