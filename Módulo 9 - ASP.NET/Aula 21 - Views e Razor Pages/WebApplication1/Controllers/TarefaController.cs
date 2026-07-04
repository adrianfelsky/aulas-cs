using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TarefaController : Controller
    {
        public IActionResult Index()
        {
            var lista = new List<Tarefa>
            {
                new Tarefa { Titulo = "Estudar C#", Concluida = true },
                new Tarefa { Titulo = "Configurar banco de dados", Concluida = false },
                new Tarefa { Titulo = "Revisar Lógica de Programação", Concluida = true },
                new Tarefa { Titulo = "Finalizar projeto final", Concluida = false }
            };

            return View(lista);
        }
    }
}