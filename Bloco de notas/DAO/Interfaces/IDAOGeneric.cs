using Bloco_de_notas.Models;

namespace Bloco_de_notas.DAO.Interfaces {
    public interface IDAOGeneric {
        public List<EntidadeDominio> SelectAll();
        public void Insert(EntidadeDominio entidade);
        public void Update(EntidadeDominio entidade);
        public void Delete(EntidadeDominio entidade);
    }
}
