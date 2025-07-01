Console.WriteLine("Bem vindo ao SoftCalc!");

Console.WriteLine("\nDigite 1 para Quadrado");
Console.WriteLine("Digite 2 para Círculo");
Console.WriteLine("Digite 3 para Triângulo");

Console.Write("\nSelecione a Forma Geométrica que deseja trabalhar: ");
int opcaoEscolhida = int.Parse(Console.ReadLine()!);

Console.Write($"Você selecionou a opção {opcaoEscolhida}");
Console.ReadKey();