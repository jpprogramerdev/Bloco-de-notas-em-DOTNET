using Bloco_de_notas.DAO;
using Bloco_de_notas.DAO.Interfaces;
using Bloco_de_notas.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bloco_de_notas.Controllers {
    public class NotaController : Controller {
        public IActionResult NovaNota() {
            return View();
        }

        [HttpPost]
        public IActionResult CriarNovaNota(Nota nota) {
            IDAOGeneric dAO = new DAONota();
            dAO.Insert(nota);

            return View("NovaNota");
        }
    }
}
