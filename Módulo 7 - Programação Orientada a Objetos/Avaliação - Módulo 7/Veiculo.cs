namespace A3_Adrian
{
    public abstract class Veiculo
    {
        private string _marca;
        private string _modelo;
        private int _ano;
        private double _precoDiaria;

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }

        public double PrecoDiaria
        {
            get { return _precoDiaria; }
            set { _precoDiaria = value; }
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Preço da Diária: {PrecoDiaria}");
        }
        public double CalcularLocacao(int dias)
        {
            return PrecoDiaria * dias;
        }
    }
}
