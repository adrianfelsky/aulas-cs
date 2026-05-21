namespace aula13.exercicio5
{
    public abstract class Conta
    {
        public double Saldo { get; set; }
        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public abstract void TIpoDescricao();

    }
}
