namespace aula12
{
    class User
    {
        private string _nome;
        private int _idade;
        private string _email = "";

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Idade
        {
            get { return _idade; }
            set { if (value > 0) _idade = value; }
        }

        public string Email 
        { 
            get { return _email; } 
            set 
            { 
                if (value!="") _email = value;
                else Console.WriteLine("Email não pode ser vazio.");
            } 
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {_nome}\n Idade: {_idade}\n Email: {_email}");
        }
    }
}
