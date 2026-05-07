namespace aula11
{
    class ContaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public static string Menu()
        {
            Console.Write("""
                Digite a operação:
                1 - Sacar
                2 - Depositar
                3 - Exibir Saldo
                x - Encerrar
                
                 >> 
                """);

            return Console.ReadLine();
        }

        public void Sair()
        {
            ExibirSaldo();
            Console.WriteLine("\nEncerrando...");
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {Saldo}");
        }

        public static void Sucesso(string operacao, double valor)
        {
            Console.WriteLine($"{operacao} realizada com sucesso.");
        }

        public void Depositar()
        {
            double valor = Operacao("depósito");

            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de {valor} realizado com sucesso.");
            }
        }

        public void Sacar()
        {
            double valor = Operacao("saque");

            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"\nSaque de {valor} realizado com sucesso.");
            }
        }

        public static double Operacao(string operacao)
        {
            Console.Write($"\nDigite o valor do {operacao}\n >> ");
            if (double.TryParse(Console.ReadLine(), out double valor));
            else
            {
                Console.WriteLine("Valor inválido. Por favor, digite um número válido.");
            }
            return valor;
        }
    }
}
