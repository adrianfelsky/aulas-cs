namespace A3_Adrian
{
    class Caminhao : Veiculo
    {
        private int _capacidadeCarga;

        public int CapacidadeCarga
        {
            get { return _capacidadeCarga; }
            set { _capacidadeCarga = value * 1000; }
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Capacidade de Carga: {_capacidadeCarga} kg");
        }
    }
}
