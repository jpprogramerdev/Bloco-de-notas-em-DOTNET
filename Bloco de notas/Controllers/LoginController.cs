using Microsoft.AspNetCore.Mvc;

namespace Bloco_de_notas.Controllers {
    public class LoginController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
