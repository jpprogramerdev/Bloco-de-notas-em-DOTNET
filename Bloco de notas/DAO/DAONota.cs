using Bloco_de_notas.DAO.Interfaces;
using Bloco_de_notas.Models;
using System.Data.SqlClient;

namespace Bloco_de_notas.DAO {
    public class DAONota : IDAOGeneric {
        public IDAODatabase Database { get; set; }

        public DAONota() {
            Database = new DAOSQLServer();
        }

        public void Delete(int id) {
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
                Database.CloseConnection(conn);
            }
        }

        public List<EntidadeDominio> SelectAll() {
            string Select = "SELECT * FROM NOTAS;";

            List<EntidadeDominio> dados = new();

            using (SqlConnection conn = Database.OpenConnection()) {
                using (SqlCommand query = new(Select, conn)) {
                    using (SqlDataReader reader = query.ExecuteReader()) {
                        while (reader.Read()) {
                            Nota nota = new Nota();
                            nota.Titulo = reader.GetString(reader.GetOrdinal("NTS_Titulo"));
                            nota.Id = reader.GetInt32(reader.GetOrdinal("NTS_Id"));
                            nota.DataCriacao = reader.GetDateTime(reader.GetOrdinal("NTS_DataCriacao"));
                            nota.DataAlteracao = reader.GetDateTime(reader.GetOrdinal("NTS_DataUltimaAtualizacao"));

                            dados.Add(nota);
                        }
                    }
                }
                Database.CloseConnection(conn);
            }

            return dados;
        }

        public EntidadeDominio SelectById(int id) {
            string Select = "SELECT * FROM NOTAS WHERE NTS_Id = @Id";

            Nota nota = new();

            using (SqlConnection conn = Database.OpenConnection()) {
                using (SqlCommand query = new(Select, conn)) {
                    query.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = query.ExecuteReader()) {
                        while (reader.Read()) {
                            nota.Titulo = reader.GetString(reader.GetOrdinal("NTS_Titulo"));
                            nota.DataCriacao = reader.GetDateTime(reader.GetOrdinal("NTS_DataCriacao"));
                            nota.DataAlteracao = reader.GetDateTime(reader.GetOrdinal("NTS_DataUltimaAtualizacao"));
                            nota.Texto = reader.GetString(reader.GetOrdinal("NTS_Texto"));
                        }
                    }
                }
            }

            return nota;
        }

        public void Update(EntidadeDominio entidade) {
            string Update = @"
                UPDATE NOTAS SET
                NTS_Titulo = @Titulo,
                NTS_Texto = @Texto, 
                NTS_DataCriacao = @DtCriacao,
                NTS_DataUltimaAtualizacao = @DtAtualizacao
                WHERE NTS_Id = @Id";

            Nota nota = (Nota)entidade;

            using (SqlConnection conn = Database.OpenConnection()) {
                using (SqlCommand query = new(Update, conn)) {
                    query.Parameters.AddWithValue("@Id", nota.Id);
                    query.Parameters.AddWithValue("@Titulo", nota.Titulo);
                    query.Parameters.AddWithValue("@Texto", nota.Texto);
                    query.Parameters.AddWithValue("DtCriacao", nota.DataCriacao.ToString("yyyy-MM-dd"));
                    query.Parameters.AddWithValue("@DtAtualizacao", DateTime.Now);
                    query.ExecuteNonQuery();
                }
            }
        }
    }
}
