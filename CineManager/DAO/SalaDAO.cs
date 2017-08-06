using CineManager.Classes;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CineManager.DAO
{
    class SalaDAO
    {
        private static string connectionString = @"Data Source=CineManager.db3;Version=3";

        public static void Inserir(Sala sala)
        {
            string commandText = @"INSERT INTO Sala(id, IdCinema, Capacidade) " +
                                 "VALUES('" + sala.Id + "','" + sala.IdCinema + "','" + sala.Capacidade + "')";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro inserido com sucesso.", "Sucesso");
                }
            }
        }

        public static DataTable Selecionar()
        {
            DataTable dtSalas = null;
            string commandText = @"SELECT Id, IdCinema, Capacidade FROM Sala";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        dtSalas = new DataTable();
                        adapter.Fill(dtSalas);

                        return dtSalas;
                    }
                }
            }
        }

        public static void Deletar(string id)
        {
            string commandText = @"DELETE FROM Sala WHERE Id = '" + id.ToUpper() + "'";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro deletado com sucesso.");
                }
            }

        }

        public static void Atualizar(Genero genero)
        {

        }
    }
}
