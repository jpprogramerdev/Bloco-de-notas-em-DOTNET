using Bloco_de_notas.DAO.Interfaces;
using Bloco_de_notas.Models;
using System.Data.SqlClient;

namespace Bloco_de_notas.DAO {
    public class DAONota : IDAOGeneric {
        public IDAODatabase Database { get; set; }

        public DAONota(){
            Database = new DAOSQLServer();
        }

        public void Delete(EntidadeDominio entidade) {
            throw new NotImplementedException();
        }

        public void Insert(EntidadeDominio entidade) {
            string Insert = "INSERT INTO NOTAS(NTS_Titulo, NTS_Texto, NTS_DataCriacao, NTS_DataUltimaAtualizacao) " +
                            "VALUES (@Titulo, @Texto, @DtCriacao, @DtAtualizacao);";

            Nota nota = (Nota)entidade;

            using (SqlConnection conn = Database.OpenConnection()) {
                using (SqlCommand query = new(Insert, conn)) {
                    query.Parameters.AddWithValue("@Titulo", nota.Titulo);
                    query.Parameters.AddWithValue("@Texto", nota.Texto);
                    query.Parameters.AddWithValue("@DtCriacao", DateTime.Now);
                    query.Parameters.AddWithValue("@DtAtualizacao", DateTime.Now);

                    query.ExecuteNonQuery();
                } 
            }
        }

        public List<EntidadeDominio> SelectAll() {
            throw new NotImplementedException();
        }

        public void Update(EntidadeDominio entidade) {
            throw new NotImplementedException();
        }
    }
}
