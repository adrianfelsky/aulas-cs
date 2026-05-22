public class Carro : Veiculo
{
    private int quantidadePortas;
    public int QuantidadePortas { get => quantidadePortas; set => quantidadePortas = value; }

    public override void ExibirInformacoes()
    {
        Console.WriteLine("=== Carro ===");
        base.ExibirInformacoes(); // Chama o método da classe pai
        Console.WriteLine($"Quantidade de Portas: {QuantidadePortas}");
    }
}
