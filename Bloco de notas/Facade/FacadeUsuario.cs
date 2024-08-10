using Bloco_de_notas.DAO;
using Bloco_de_notas.DAO.Interfaces;
using Bloco_de_notas.Facade.Interfaces;
using Bloco_de_notas.Models;

namespace Bloco_de_notas.Facade {
    public class FacadeUsuario : IFacadeUsuario {
        public IDAOUsuario DAO { get; set; }

        public FacadeUsuario() {
            DAO = new DAOUsuario();
        }

        public Usuario Login(Usuario usuario) => DAO.SelectOne(usuario);
    }
}
