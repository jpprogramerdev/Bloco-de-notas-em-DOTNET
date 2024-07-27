using Microsoft.AspNetCore.Mvc;

namespace Bloco_de_notas.Controllers {
    public class NotaController : Controller {
        public IActionResult NovaNota() {
            return View();
        }
    }
}
