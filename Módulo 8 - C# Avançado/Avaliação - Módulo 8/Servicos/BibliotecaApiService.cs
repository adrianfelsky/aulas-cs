using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace BibliotecaApp.Servicos
{
    public class BibliotecaApiService
    {
        private readonly HttpClient _httpClient;
        public BibliotecaApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task BuscarDetalhesApiAsync(string titulo)
        {
            if (string.IsNullOrWhiteSpace(titulo))
            {
                Console.WriteLine("\nTítulo inválido.");
                return;
            }

            string tituloFormatado = Uri.EscapeDataString(titulo);

            string url = $"https://openlibrary.org/search.json?title={tituloFormatado}";

            var response = await _httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            dynamic resultado = JsonConvert.DeserializeObject(json)!;

            if (resultado.docs == null || resultado.docs.Count == 0)
            {
                Console.WriteLine("\nNenhum resultado encontrado na API.");
                return;
            }

            var primeiro = resultado.docs[0];

            string autor = primeiro.author_name != null
                ? (string)primeiro.author_name[0]
                : "Autor desconhecido";

            Console.WriteLine($"Título: {primeiro.title}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Ano: {primeiro.first_publish_year}");
        }

    }
}
