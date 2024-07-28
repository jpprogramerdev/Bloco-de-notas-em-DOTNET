using Bloco_de_notas.DAO.Interfaces;
using System.Data.SqlClient;

namespace Bloco_de_notas.DAO {
    public class DAOSQLServer : IDAODatabase {
        private string _StringConection;

        public DAOSQLServer(){
            StrConn = "Server=GORDOX\\SQLEXPRESS;Database=BlocoDeNotas;Integrated Security=SSPI;TrustServerCertificate=True;";
        }

        public string StrConn {
            get {
                    return _StringConection;
            }
            private set {
                _StringConection = value;
            }
        }

        public void CloseConnection(SqlConnection conn) {
            conn.Close();
        }

        public SqlConnection OpenConnection() {
            SqlConnection conn = new(StrConn);
            conn.Open();
            return conn;
        }
    }
}
