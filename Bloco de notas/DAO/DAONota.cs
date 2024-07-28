using Bloco_de_notas.DAO.Interfaces;
using Bloco_de_notas.Models;

namespace Bloco_de_notas.DAO {
    public class DAONota : IDAOGeneric {
        public void Delete(EntidadeDominio entidade) {
            throw new NotImplementedException();
        }

        public void Insert(EntidadeDominio entidade) {
            string Insert = "INSERT INTO NOTAS(NST_Titulo, NST_Texto, NST_DataCriacao, NTS_DataUltimaAtualizacao) " +
                            "VALUES (@Titulo, @Texto, @DtCriacao, @DtAtualizacao);";
        }

        public List<EntidadeDominio> SelectAll() {
            throw new NotImplementedException();
        }

        public void Update(EntidadeDominio entidade) {
            throw new NotImplementedException();
        }
    }
}
