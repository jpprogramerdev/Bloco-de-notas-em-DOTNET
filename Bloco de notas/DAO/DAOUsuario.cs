using Bloco_de_notas.DAO.Interfaces;
using Bloco_de_notas.Models;
using System.Data.SqlClient;

namespace Bloco_de_notas.DAO {
    public class DAOUsuario : IDAOUsuario {
        public IDAODatabase Database { get; set; }

        public DAOUsuario(){
            Database = new DAOSQLServer();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public void Insert(EntidadeDominio entidade) {
            throw new NotImplementedException();
        }

        public List<EntidadeDominio> SelectAll() {
            throw new NotImplementedException();
        }

        public EntidadeDominio SelectById(int id) {
            throw new NotImplementedException();
        }

        public Usuario SelectOne(Usuario usuario) {
            string Select = "SELECT * FROM USUARIOS WHERE USU_EMAIL = @email AND USU_Senha = @senha;";

            Usuario user = new();

            using(SqlConnection conn = Database.OpenConnection()) {
                using (SqlCommand query = new(Select, conn)) {
                    query.Parameters.AddWithValue("@email", usuario.Email);
                    query.Parameters.AddWithValue("@senha", usuario.Senha);
                    using (SqlDataReader reader = query.ExecuteReader()) {
                        if (reader.Read()) {
                            while (reader.Read()) {
                                user.Nome = reader.GetString(reader.GetOrdinal("USU_Nome"));
                                user.Email = reader.GetString(reader.GetOrdinal("USU_Email"));
                                user.Senha = reader.GetString(reader.GetOrdinal("USU_Senha"));
                            }
                        } else {
                            user = null;
                        }
                    }
                }
                Database.CloseConnection(conn);
            }

            
            return user;
        }

        public void Update(EntidadeDominio entidade) {
            throw new NotImplementedException();
        }
    }
}
