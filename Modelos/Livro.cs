using System;

namespace BibliotecaApp.Modelos
{ 
    public class Livro
    {
        private int _id;
        private string _titulo;
        private string _autor;
        private int _ano;
        private bool _disponivel;

        /// <summary>
        /// Identificador único
        /// </summary>
        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        /// <summary>
        /// Título do Livro
        /// </summary>
        public string Titulo
        {
            get { return _titulo; }
            private set { _titulo = value; }
        }

        /// <summary>
        /// Nome do Autor
        /// </summary>
        public string Autor
        {
            get { return _autor; }
            private set { _autor = value; }
        }

        /// <summary>
        /// Ano de publicação
        /// </summary>
        public int Ano
        {
            get { return _ano; }
            private set { _ano = value; }
        }

        /// <summary>
        /// true disponível para empréstimo
        /// </summary>
        public bool Disponivel
        {
            get { return _disponivel; }
            set { _disponivel = value; }
        }

        public Livro (int id, string titulo,  string autor, int ano, bool disponivel)
        {
            ID = id;
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
            Disponivel = disponivel;
        }
    }
}
