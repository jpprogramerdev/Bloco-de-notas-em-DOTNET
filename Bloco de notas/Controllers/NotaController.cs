using Bloco_de_notas.DAO;
using Bloco_de_notas.DAO.Interfaces;
using Bloco_de_notas.Facade;
using Bloco_de_notas.Facade.Interfaces;
using Bloco_de_notas.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bloco_de_notas.Controllers {
    public class NotaController : Controller {
        public IActionResult NovaNota() {
            return View();
        }

        public IActionResult TodasNotas() {
            IFacadeNota facadeNota = new FacadeNota();
            List<Nota> notas = CastingNota(facadeNota.SelecionarTodasNotas());
            return View(notas);
        }

        [HttpPost]
        public IActionResult CriarNovaNota(Nota nota) {
            IFacadeNota facadeNota = new FacadeNota();
            facadeNota.SalvarNota(nota);
            return View("NovaNota");
        }


        private List<Nota> CastingNota(List<EntidadeDominio> lista) {
            List<Nota> notas = new();
            
            foreach(Nota nota in lista) {
                notas.Add(nota);
            }

            return notas;
        }
    }
}
