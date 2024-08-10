using Bloco_de_notas.Facade;
using Bloco_de_notas.Facade.Interfaces;
using Bloco_de_notas.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bloco_de_notas.Controllers {
    public class LoginController : Controller {
        public IFacadeUsuario facadeUsuario { get; set; }

        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario Usuario) {
            facadeUsuario = new FacadeUsuario();
            Usuario userLogado = facadeUsuario.Login(Usuario);

            if(userLogado != null) {
                return RedirectToAction("TodasNotas", "Nota");   
            }

            TempData["FalhaLogin"] = "Email e/ou senha incorretos";

            return View("Index");
        }
    }
}
