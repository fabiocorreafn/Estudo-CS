namespace Estudo_da_classe_Object.Classes;

internal class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public Carro(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }
    
    // Sobrescrevendo ToString() para uma representação útil
    public override string ToString()
    {
        return $"[Carro] Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}";
    }

    public void Executar()
    {
        Console.WriteLine("--- Exemplo de Depuração/Log com ToString ---");
        Carro meuCarro = new Carro("Toyota", "Corolla", 2022);
        Carro carroDoAmigo = new Carro("Honda", "Civic", 2020);

        // Usando ToString() para exibir o estado do objeto
        Console.WriteLine($"Detalhes do meu carro: {meuCarro}"); //Implicita o ToString()
        Console.WriteLine($"Detalhes do carro do amigo: {carroDoAmigo}"); // Chamada explícita

        // Imagine que isso seria um log em um sistema
        Console.WriteLine($"\nLOG: Carro criado: {meuCarro}");
    }
}
