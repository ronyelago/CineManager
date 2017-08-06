using CineManager.Classes;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CineManager.DAO
{
    class CinemaDAO
    {
        // String de conexão
        private static string connectionString = @"Data Source=CineManager.db3;Version=3";

        // Método que retorna um DataTable com todos os cinemas
        public static DataTable Selecionar()
        {
            string commandText = @"SELECT Id, Nome, Endereco, NSalas, Capacidade FROM Cinema";
            DataTable dtCinemas = null;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        dtCinemas = new DataTable();
                        adapter.Fill(dtCinemas);

                        return dtCinemas;
                    }
                }
            }
        }

        // Método que recebe um objeto Cinema como parâmetro e o insere no banco de dados
        public static void Inserir(Cinema cinema)
        {
            string commandText = @"INSERT INTO Cinema(Id, Nome, Endereco, NSalas, Capacidade, Foto) " +
                                 "VALUES('" + cinema.Id + "','" + cinema.Nome + "','" + cinema.Endereco + "','" +
                                 cinema.NSalas + "','" + cinema.Capacidade + "', @Foto)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    SQLiteParameter foto = new SQLiteParameter("@Foto", DbType.Binary);
                    foto.Value = cinema.Foto;

                    command.Parameters.Add(foto);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro adicionado com sucesso.", "Sucesso");
                }
            }
        }

        public static void Deletar(string id)
        {
            string commandText = @"DELETE FROM Cinema WHERE id = '" + id + "'";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro apagado com sucesso.", "Sucesso");
                }
            }
        }

        public static void Atualizar(string id)
        {

        }
    }
}
