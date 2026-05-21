namespace aula13
{
    public class Carro : Veiculo
    {
        public int NumeroDePortas;
        public Carro(string marca, string modelo, int numPortas) : base(marca, modelo)
        {
            Marca = marca;
            Modelo = modelo;
            NumeroDePortas = numPortas;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Número de Portas: {NumeroDePortas}");
        }

    }
}
