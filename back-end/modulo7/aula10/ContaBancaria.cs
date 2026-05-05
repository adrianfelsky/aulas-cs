namespace aula10
{
    class ContaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {Saldo}");
        }
    }
}
