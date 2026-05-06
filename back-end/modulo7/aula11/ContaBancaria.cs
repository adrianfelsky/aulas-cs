namespace aula11
{
    class ContaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {Saldo}");
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"\nDepósito de {valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"\nSaque de {valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de saque inválido ou saldo insuficiente.");
            }
        }
    }
}
