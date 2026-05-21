namespace aula13
{
    class PJ : FuncionarioTipo
    {
        private const double SalarioPorHora = 50;
        public float HorasTrabalhadasSemana { get; set; }
        private const int _semanasNoMes = 4;
        public PJ(string nome, int idade, float horasTrabalhadas) : base(nome, idade)
        {
            Nome = nome;
            Idade = idade;
            HorasTrabalhadasSemana = horasTrabalhadas;
        }

        public override double CalcularSalario()
        {
            return SalarioPorHora*HorasTrabalhadasSemana*_semanasNoMes;
        }
    }
}
