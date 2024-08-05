using Bloco_de_notas.Models;

namespace Bloco_de_notas.Facade.Interfaces {
    public interface IFacadeNota {
        public List<EntidadeDominio> SelecionarTodasNotas();
        public void SalvarNota(EntidadeDominio entidade);
        public EntidadeDominio SelecionarPorId(int Id);
        public void AtualizarNota(EntidadeDominio entidade);
        public void ApagarNota(int Id);
    }
}
