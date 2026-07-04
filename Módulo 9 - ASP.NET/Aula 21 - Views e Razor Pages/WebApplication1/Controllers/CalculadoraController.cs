using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("calculadora")]
    public class CalculadoraController : Controller
    {
        [HttpGet("somar")]
        public IActionResult Somar(int a, int b)
        {
            return Content(Convert.ToString(a+b));
        }

        [HttpGet("subtrair")]
        public IActionResult Subtrair(int a, int b)
        {
            return Content(Convert.ToString(a - b));
        }

        [HttpGet("multiplicar")]
        public IActionResult Multiplicar(int a, int b)
        {
            return Content(Convert.ToString(a * b));
        }

        [HttpGet("dividir")]
        public IActionResult Dividir(int a, int b)
        {
            return Content(Convert.ToString(a / b));
        }

    }
}
