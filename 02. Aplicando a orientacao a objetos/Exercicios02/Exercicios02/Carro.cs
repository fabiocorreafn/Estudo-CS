class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Combustivel { get; set; }
    public bool Ligado { get; set; }
    private int ano;
    public int Ano 
    { 
        get => ano;
        
        set
        {
            if (value >= 1960 && value <= 2023)
            {
                ano = value;
            }
            else
            {
                Console.WriteLine($"O ano do carro {Marca} {Modelo} deve estar entre 1960 e 2023.");
            }
        }
    }

    public void Acelerar()
    {
        if (Ligado == true)
        {
            Console.WriteLine($"O {Marca} {Modelo} está ACELERANDO!");
        } else
        {
            Console.WriteLine($"Não é possível acelerar o {Marca} {Modelo}. Ele está desligado.");
        }
        
    }

    public void Frear()
    {
        Console.WriteLine($"O {Marca} {Modelo} está FREANDO.");
    }

    public void Buzinar()
    {
        Console.WriteLine($"O {Marca} {Modelo} está BUZINANDO: Bi Bi!");
    }

    public void ExibirInformacoesDosCarros()
    {
        if (ano == 0)
        {
            Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo} \nAno: ANO INVÁLIDO! É necesário cadastrar um ano válido!");
        }
        else
        {
            Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo} \nAno:{Ano}");
        }
        
        Console.WriteLine();
    }
}