namespace aula12
{
    class Aluno
    {
        private string _nome;
        private double _nota;

        public string Nome { 
            get { return _nome; }
            set { _nome = value; }
        }

        public double Nota
        {
            get { return _nota; }
            set { if (value >= 0 && value <= 10) _nota = value; }
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {_nome}, Nota: {_nota}");
        }
    }
}
