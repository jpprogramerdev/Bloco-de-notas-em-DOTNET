using Bloco_de_notas.Models;

namespace Bloco_de_notas.DAO.Interfaces {
    public interface IDAOUsuario : IDAOGeneric{
        public Usuario SelectOne(Usuario usuario);
    }
}
