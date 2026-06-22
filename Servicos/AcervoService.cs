using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaApp.Modelos;
using Newtonsoft.Json;

namespace BibliotecaApp.Servicos
{

    public class AcervoService
    {
        private static readonly string Arquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "acervo.json");

        public List<Livro> Acervo { get; private set; }

        public AcervoService()
        {
            Acervo = CarregarAcervo();
        }

        private List<Livro> CarregarAcervo()
        {
            if (!File.Exists(Arquivo))
                return new List<Livro>();

            string json = File.ReadAllText(Arquivo);

            return JsonConvert.DeserializeObject<List<Livro>>(json)
                   ?? new List<Livro>();
        }

        public void SalvarAcervo()
        {
            string json = JsonConvert.SerializeObject(
                Acervo,
                Formatting.Indented);

            File.WriteAllText(Arquivo, json);
        }

        public void AdicionarLivro(Livro livro)
        {
            Acervo.Add(livro);
            SalvarAcervo();
        }
    }
}
