using Bloco_de_notas.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bloco_de_notas.Controllers {
    public class NotaController : Controller {
        public IActionResult NovaNota() {
            return View();
        }

        [HttpPost]
        public IActionResult CriarNovaNota(Nota nota) { 
        
        }
    }
}
