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

        public IActionResult EditarNota(int id) {
            IFacadeNota facadeNota = new FacadeNota();
            Nota nota = (Nota)facadeNota.SelecionarPorId(id);
            return View(nota);
        }

        [HttpPost]
        public IActionResult CriarNovaNota(Nota nota) {
            IFacadeNota facadeNota = new FacadeNota();
            facadeNota.SalvarNota(nota);
            return View("NovaNota");
        }

        [HttpPost]
        public IActionResult AtualizarNota(Nota Nota) {
            IFacadeNota facadeNota = new FacadeNota();
            facadeNota.AtualizarNota(Nota);
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
