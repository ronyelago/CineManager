using CineManager.Classes;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;
using System;

namespace CineManager.DAO
{
    class AtorDiretorDAO
    {
        private static string connectionString = @"Data Source=CineManager.db3;Version=3";

        // Retorna um DataTable com todos os Atores/Diretores
        public static DataTable Selecionar()
        {
            string commandText = @"SELECT Id, Nome, Nacionalidade, DtNascimento, Foto FROM AtorDiretor";
            DataTable dtAtoresDiretores = null;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        dtAtoresDiretores = new DataTable();
                        adapter.Fill(dtAtoresDiretores);

                        return dtAtoresDiretores;
                    }
                }
            }
        }

        // Retorna um único registro que será localizado pelo id
        public static AtorDiretor Selecionar(int id)
        {
            string commandText = @"SELECT Id, Nome, Nacionalidade, DtNascimento, Foto "+ 
                                  "FROM AtorDiretor WHERE Id = " + id;
            AtorDiretor atorDiretor = null;

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
                            atorDiretor = new AtorDiretor();
                            atorDiretor.Id = int.Parse(reader[0].ToString());
                            atorDiretor.Nome = reader[1].ToString();
                            atorDiretor.Nacionalidade = reader[2].ToString();
                            atorDiretor.DataNascimento = DateTime.Parse(reader[3].ToString());
                            atorDiretor.Foto = (byte[])reader[4];   
                        }
                    }
                }
            }

            return atorDiretor;
        }

        // Insere um novo registro
        public static void Inserir(AtorDiretor atorDiretor)
        {
            string commandText = @"INSERT INTO AtorDiretor(Nome, Nacionalidade, DtNascimento, Foto) " + 
                                  "VALUES('"+atorDiretor.Nome+"','"+atorDiretor.Nacionalidade+"','" +
                                  atorDiretor.DataNascimento+"', @Foto)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    SQLiteParameter foto = new SQLiteParameter("@Foto", DbType.Binary);
                    foto.Value = atorDiretor.Foto;

                    command.Parameters.Add(foto);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro adicionado com sucesso.");
                }
            }
        }

        public static void Atualizar(int id)
        {

        }

        // Deleta um registro que será localizado pelo Id
        public static void Deletar(int id)
        {
            string commandText = @"DELETE FROM AtorDiretor WHERE id = " + id;

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

        // Deleta um registro que será localizado pelo nome
        public static void Deletar(string nome)
        {
            string commandText = @"DELETE FROM AtorDiretor WHERE Nome = " + nome;

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
    }
}
