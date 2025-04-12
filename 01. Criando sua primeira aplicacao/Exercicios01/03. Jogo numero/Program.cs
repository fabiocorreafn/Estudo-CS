// Jogo: Acerte o número

Random random = new Random();
int numeroCerto = random.Next(1, 51);
Console.WriteLine(numeroCerto);

int numeroDigitado;

Console.WriteLine("Bem vindo ao Jogo Acerte o Número!");

do
{
    Console.Write("\nDigite um número entre 0 e 50: ");
    numeroDigitado = int.Parse(Console.ReadLine()!);

    if (numeroDigitado == numeroCerto)
    {
        Console.WriteLine("Parabéns, você acertou o número!");
        break;
    } else if (numeroDigitado < numeroCerto)
      {
            Console.WriteLine("\nVocê errou!");
            Console.WriteLine("O número secreto é MAIOR que este.");
      } else if (numeroDigitado > numeroCerto)
        {
          Console.WriteLine("\nVocê errou!");
          Console.WriteLine("O número secreto é MENOR que este.");
        }
} while (true);
