using Bloco_de_notas.Models;

namespace Bloco_de_notas.DAO.Interfaces {
    public interface IDAOGeneric {
        public EntidadeDominio SelectById(int id);
        public List<EntidadeDominio> SelectAll();
        public void Insert(EntidadeDominio entidade);
        public void Update(EntidadeDominio entidade);
        public void Delete(EntidadeDominio entidade);
    }
}
