// 01. Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado 
// de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.

using System;

Console.Write("Digite o primeiro número decimal: ");
double primeiroNumero = double.Parse(Console.ReadLine()!);
Console.Write("Digite o segundo número decimal: ");
double segundoNumero = double.Parse(Console.ReadLine()!);

double soma, subtracao, multiplicacao, divisao;

soma = primeiroNumero + segundoNumero;
subtracao = primeiroNumero - segundoNumero;
multiplicacao = primeiroNumero * segundoNumero;
divisao = primeiroNumero / segundoNumero;

Console.WriteLine($"A soma de {primeiroNumero} + {segundoNumero} é = {soma:F2}");
Console.WriteLine($"A subtração de {primeiroNumero} - {segundoNumero} é = {subtracao:F2}");
Console.WriteLine($"A multiplicação de {primeiroNumero} x {segundoNumero} é = {multiplicacao:F2}");
Console.WriteLine($"A divisão de {primeiroNumero} / {segundoNumero} é = {divisao:F2}");


// 02. Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.


List<string> listaDeBandas = new List<string>();

listaDeBandas.Add("Bruno Mars");
listaDeBandas.Add("Michael Jackson");
listaDeBandas.Add("Só Pra Contrariar");
listaDeBandas.Add("Djavan");
listaDeBandas.Add("Belo");

foreach (string banda in listaDeBandas)
{
    Console.WriteLine($"Banda: {banda}");
}

//03.Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.

Console.WriteLine();
Console.WriteLine("Listando usando FOR:");
for (int i = 0; i < listaDeBandas.Count; i++)
{
    Console.WriteLine($"Banda: {listaDeBandas[i]}");
}

Console.WriteLine();
Console.WriteLine("Listando usando FOREACH:");
foreach (string banda in listaDeBandas)
{
    Console.WriteLine($"Banda: {banda}");
}

// 04. Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.

List<int> numerosInteiros = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite um número inteiro: ");
    int numeroDigitado = int.Parse(Console.ReadLine()!);
    numerosInteiros.Add(numeroDigitado);

}

Console.Write("\nNúmeros digitados:");
foreach (int numero in numerosInteiros)
{
    Console.Write($"{numero}; ");
}


int somaNumerosInteiros = 0;

for (int i = 0; i < numerosInteiros.Count; i++)
{
    somaNumerosInteiros += numerosInteiros[i];
}
Console.WriteLine($"\nA soma de todos os números inteiros da lista é: {somaNumerosInteiros}");