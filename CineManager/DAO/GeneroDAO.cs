using CineManager.Classes;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace CineManager.DAO
{
    public static class GeneroDAO
    {
        private static string connectionString = @"Data Source=CineManager.db3;Version=3";

        public static void Inserir(Genero genero)
        {
            string commandText = @"INSERT INTO Genero(Id, Nome) " +
                                  "VALUES('" + genero.Id + "','" + genero.Nome + "')";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro inserido com sucesso.");
                }
            }
        }

        //Método Selecionar que retorna um DataTable com todos os Gêneros
        public static DataTable Selecionar()
        {
            string commandText = @"SELECT Id, Nome FROM Genero";
            DataTable dtGeneros = null;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        dtGeneros = new DataTable();
                        adapter.Fill(dtGeneros);
                        return dtGeneros;
                    }
                }
            }
        }

        // Sobrecarga do método Selecionar (retorna apenas um gênero)
        public static Genero Selecionar(string id)
        {
            string commandText = @"SELECT Id, Nome FROM Genero WHERE Id = '" + id.ToUpper() + "'";
            Genero genero = null;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                        if (reader.HasRows)
                        {
                            genero = new Genero();
                            genero.Id = reader[0].ToString();
                            genero.Nome = reader[1].ToString();
                        }
                    }
                }
            }

            return genero;
        }

        // Deleta um gênero 
        public static void Deletar(string id)
        {
            string commandText = @"DELETE FROM Genero WHERE Id = '"+id.ToUpper()+"'";

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
