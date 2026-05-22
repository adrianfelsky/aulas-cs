public class Moto : Veiculo
{
    private int cilindrada;
    public int Cilindrada { get => cilindrada; set => cilindrada = value; }

    public override void ExibirInformacoes()
    {
        Console.WriteLine("=== Moto ===");
        base.ExibirInformacoes();
        Console.WriteLine($"Cilindrada: {Cilindrada}cc");
    }
}
