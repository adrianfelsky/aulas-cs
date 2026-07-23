using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            var produtos = new List<Produto>
            {
                new Produto { Nome = "Monitor 24 polegadas", Preco = 950.00m, Categoria = "Eletrônicos" },
                new Produto { Nome = "Cadeira Ergonômica", Preco = 800.00m, Categoria = "Móveis" },
                new Produto { Nome = "Teclado Mecânico", Preco = 350.00m, Categoria = "Periféricos" },
                new Produto { Nome = "Mouse Sem Fio", Preco = 120.00m, Categoria = "Periféricos" },
                new Produto { Nome = "Caderno Universitário", Preco = 35.50m, Categoria = "Papelaria" }
            };

            return View(produtos);
        }

        public IActionResult Estoque(int quantidade)
        {
            ViewBag.Quantidade = quantidade;
            return View();
        }
    }
}
