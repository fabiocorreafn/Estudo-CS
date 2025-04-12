// Aplicação que identifica números pares numa lista de números SEM expressão Lambda
/*
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> numerosPares = numeros.FindAll(BuscarNumerosPares);

bool BuscarNumerosPares(int numero)
{
    return numero % 2 == 0;
}

foreach (int numero in numerosPares)
{
    Console.WriteLine(numero);
}
*/

// Aplicação que identifica números pares numa lista de números COM expressão Lambda

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
numerosPares.ForEach(numero => Console.WriteLine(numero));

// No C#, uma função lambda pode ser aplicada em atributos, propriedades ou na forma como escrevemos funções.
// Abaixo, existe uma função que soma 2 valores inteiros e retorna o resultado da soma, como mostra o trecho de código a seguir.
// Agora é sua vez! Refaça esse método Somar() usando uma função lambda retornando o resultado da operação.

Console.Write("Digite o valor para a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Digite o valor para b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(Somar(a, b));

//Função Somar sem expressão lambda:

//Console.Write(Somar(a, b));
//int Somar(int a, int b)
//{
//    int resultado = a + b;
//    return resultado;
//}

//Função Somar com expressão lambda:

int Somar(int a, int b) => a + b;