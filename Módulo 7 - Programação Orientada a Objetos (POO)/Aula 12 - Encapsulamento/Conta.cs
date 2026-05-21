namespace aula12
{
    class Conta
    {
        private double _saldo;

        public double Saldo
        {
            get { return _saldo; }
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
                _saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= _saldo)
                _saldo -= valor;
        }

    }
}
