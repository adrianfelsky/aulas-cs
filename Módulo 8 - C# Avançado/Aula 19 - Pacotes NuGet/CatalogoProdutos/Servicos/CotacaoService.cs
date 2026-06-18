using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoProdutos.Servicos
{
    public class CotacaoService
    {
        private readonly HttpClient _httpClient;

        public CotacaoService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<decimal> ObterCotacaoDolarAsync()
        {
            string response = await _httpClient.GetStringAsync("https://economia.awesomeapi.com.br/json/last/USD-BRL");
            
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response);

            string bidString = data.USDBRL.bid;

            return Convert.ToDecimal(bidString, new System.Globalization.CultureInfo("en-US"));
        }
    }
}