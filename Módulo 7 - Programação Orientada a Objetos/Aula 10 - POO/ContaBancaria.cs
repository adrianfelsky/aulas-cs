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

        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de {valor} realizado com sucesso.");
                return true;
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
                return false;
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de saque inválido ou saldo insuficiente.");
            }
        }
    }
}
