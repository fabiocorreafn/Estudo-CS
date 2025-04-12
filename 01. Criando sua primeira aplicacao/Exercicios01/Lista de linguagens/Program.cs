// Lista de linguagens de programação

List<string> linguagens = new List<string>() {"C#", "Java", "JavaScript"};
Console.WriteLine(linguagens[0]);
Console.WriteLine();

Console.Write("Digite um valor inteiro entre 0 e 2: ");
int opcao = int.Parse(Console.ReadLine());


if (opcao < 0 || opcao > 2)
{
    Console.WriteLine("Opção inválida!");
    Console.Write("Escolha uma valor inteiro entre 0 e 2: ");
    opcao = int.Parse(Console.ReadLine());
}
else
{
    Console.WriteLine("Você escolheu a linguagem " + linguagens[opcao]);
}