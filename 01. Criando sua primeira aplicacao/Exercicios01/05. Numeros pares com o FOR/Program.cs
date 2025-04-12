// Crie uma lista de inteiros utilizando o List<int> e utilize o for e o foreach para iterar sobre essa lista e exibir apenas os números pares.

// No for, comece o índice em 0 e incremente a cada iteração. 
// Defina a condição de continuação do loop como i < numeros.Count, ou seja, o loop continuará enquanto o valor de i for menor do que o número de elementos na lista.
// Acesse o valor de cada elemento utilizando a sintaxe numeros[i].

// Já no foreach, ao invés de utilizar um loop for com um contador i e acessar os elementos da lista através do índice i, é utilizado o foreach para percorrer a lista
// e acessar diretamente cada elemento com a variável número.

// Em seguida, é verificado se o número é par utilizando o operador de módulo (%) e, caso seja, o número é impresso no console.



// Exercício: Números inteiros pares

List<int> numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 18, 19, 21, 24, 88, 99};
List<int> numerosParesFor = new List<int>();
List<int> numerosParesForeach = new List<int>();

// USANDO FOR

Console.WriteLine("Usando FOR");
Console.Write("Os números pares são: ");

// Identificando se o número é par ou ímpar e, caso seja par, adiciono ele a uma nova lista só de números pares.
for (int i = 0; i < numeros.Count; i++)
{
    if (numeros[i] % 2 == 0)
    {
        numerosParesFor.Add(numeros[i]);
    }        
}

// Escrevendo na tela a lista de números pares.
// Fiz separado para conseguir escrever os números separados por vírgula e colocar um ponto após o último.
for (int i = 0; i < numerosParesFor.Count; i++)
{
    if (i != numerosParesFor.Count - 1)
    {
        Console.Write($"{numerosParesFor[i]}, ");
    } else
    {
        Console.Write($"{numerosParesFor[i]}. ");
    }
}

// USANDO FOREACH

int indice = 0; // Variável auxiliar para ajudar no acesso ao índice de numerosParesForeach

Console.WriteLine("\n\nUsando FOREACH");
Console.Write("Os números pares são: ");

// Identificando se o número é par ou ímpar e, caso seja par, adiciono ele a uma nova lista só de números pares.
foreach (int i in numeros)
{
    if (i % 2 == 0)
    {
        numerosParesForeach.Add(i);
    }
}

// Escrevendo na tela a lista de números pares.
// Fiz separado para conseguir escrever os números separados por vírgula e colocar um ponto após o último.
foreach (int i in numerosParesForeach)
{
    if (indice != numerosParesForeach.Count - 1)
    {
        Console.Write($"{numerosParesForeach[indice]}, ");
        indice++;

    }else
    {
        Console.Write($"{numerosParesForeach[indice]}.");
    }
}

// Alternativa para escrever vírgula (,) entre os elementos da lista e ponto (.) ao final da lista
// utilizando o método string.join

Console.WriteLine("\nUsando o método String.join: ");
Console.WriteLine(string.Join(", ", numerosParesFor) + ".");