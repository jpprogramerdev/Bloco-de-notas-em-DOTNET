using System.Data.SqlClient;

namespace Bloco_de_notas.DAO.Interfaces {
    public interface IDAODatabase {
        public SqlConnection OpenConnection();
        public void CloseConnection(SqlConnection conn);
    }
}
