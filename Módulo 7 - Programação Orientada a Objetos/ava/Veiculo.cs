public class Veiculo
{
    // Encapsulamento: Atributos privados
    private string marca;
    private string modelo;
    private int ano;
    private decimal precoDiaria; // Recomendado usar decimal para valores monetários

    // Propriedades para acesso
    public string Marca { get => marca; set => marca = value; }
    public string Modelo { get => modelo; set => modelo = value; }
    public int Ano { get => ano; set => ano = value; }
    public decimal PrecoDiaria { get => precoDiaria; set => precoDiaria = value; }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Preço Diária: R$ {PrecoDiaria:F2}");
    }

    public decimal CalcularLocacao(int dias)
    {
        return PrecoDiaria * dias;
    }
}
