namespace A3_Adrian
{
    class Moto : Veiculo
    {
        private int _cilindrada;

        public int Cilindrada
        {
            get { return _cilindrada; }
            set { _cilindrada = value; }
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Cilindradas: {_cilindrada}");
        }
    }
}
