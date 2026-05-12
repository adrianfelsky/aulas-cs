
namespace aula12
{
    class Pessoa
    {
        private int _idade;

        public int Idade
        {
            get { return _idade; }
            set { if (value > 0) _idade = value; }
        }
    }
}
