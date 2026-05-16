namespace aula13
{
    public abstract class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
        }
    }
}
