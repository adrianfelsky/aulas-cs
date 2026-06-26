using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("produtos")]
    public class ProdutosController : Controller
    {
        public List<string> produtos = new() { "Laranjinha", "Max Framboesa", "Guaraná Zero", "Fanta Uva", "Água" };
        [HttpGet]
        public IActionResult Index()
        {
            return Json(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult Detalhes(int id)
        {
            Console.WriteLine(id);
            if (id < 0 || id >= produtos.Count)
            {
                return NotFound();
            }
            var produto = produtos[id];
            return Content($"{id}. {produto}");
        }

        [HttpGet("antiga")]
        public IActionResult Antiga()
        {
            return RedirectToAction("Nova");
        }

        [HttpGet("nova")]
        public IActionResult Nova()
        {
            return Content("Esta é a nova versão.");
        }
    }
}
