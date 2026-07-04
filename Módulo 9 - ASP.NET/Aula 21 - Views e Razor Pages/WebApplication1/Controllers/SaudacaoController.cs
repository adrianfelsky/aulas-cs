using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SaudacaoController : Controller
    {
        public IActionResult Ola(string nome)
        {
            return Content($"Olá {nome}! Bem-vindo ao ASP.NET Core.");

        }
    }
}
