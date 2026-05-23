namespace A3_Adrian
{
    public class Carro : Veiculo
    {
        private int _quantidadePortas;

        public int QuantidadePortas
        {
            get { return _quantidadePortas; }
            set { _quantidadePortas = value; }
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Quantidade de Portas: {_quantidadePortas}");
        }
    }
}
