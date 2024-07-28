using Bloco_de_notas.Models;

namespace Bloco_de_notas.Facade.Interfaces {
    public interface IFacadeNota {
        public List<EntidadeDominio> SelecionarTodasNotas();
        public void SalvarNota(EntidadeDominio entidade);
    }
}
