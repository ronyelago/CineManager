using CineManager.Classes;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace CineManager.DAO
{
    class FilmeDAO
    {
        private static string connectionString = @"Data Source=CineManager.db3;Version=3";

        // Método que recebe um objeto Filme como parâmetro e o insere no banco de dados
        public static void Inserir(Filme filme)
        {
            string commandText = @"INSERT INTO Filme(Titulo, TituloPT, IdGenero, Sinopse, Duracao,"+
                                  "Origem, Ano, Foto, IdDiretor, Classificacao) "+
                                  "VALUES('"+filme.Titulo+"', '"+filme.TituloPT+"', '"+
                                   filme.IdGenero+"', '"+filme.Sinopse+"', '"+filme.Duracao+"', '"+
                                   filme.Origem+"', '"+filme.Ano+"', @Foto, '"+filme.IdDiretor+"', "+
                                   filme.Classificacao+")";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    SQLiteParameter foto = new SQLiteParameter("@Foto", DbType.Binary);
                    foto.Value = filme.Foto;

                    command.Parameters.Add(foto);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Filme adicionado com sucesso.", "Sucesso");
                }
            }
        }

        public static void Atualizar(int id)
        {

        }

        // Método que retorna um DataTable com dados das tabelas Filme, Genero e AtorDiretor
        // para exibir o nome do diretor e o nome do gênero ao invés de seus Id's
        public static DataTable Selecionar()
        {
            DataTable dtFilmes = null;
            string commandText = @"SELECT Filme.Titulo AS 'Título Original', Filme.TituloPT AS 'Título em Português', " +
                                 "Genero.Nome AS 'Gênero', Filme.Duracao AS 'Duração', Filme.Origem, Filme.Ano, " + 
                                 "AtorDiretor.Nome AS 'Diretor', Filme.Classificacao AS 'Classificação' "+
                                 "FROM Filme "+
                                 "INNER JOIN Genero ON Filme.IdGenero = Genero.Id "+
                                 "INNER JOIN AtorDiretor ON Filme.IdDiretor = AtorDiretor.Id";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        dtFilmes = new DataTable();
                        adapter.Fill(dtFilmes);

                        return dtFilmes;
                    }
                }
            }
        }

        public static DataTable Selecionar(params string[] campos)
        {
            DataTable dtFilmes = null;

            StringBuilder builder = new StringBuilder();
            builder.Append(@"SELECT ");

            foreach (var c in campos)
            {
                builder.Append(c);
                builder.Append(",");
            }

            builder.Remove(builder.Length-1, 1);
            builder.Append(" FROM Filme");

            string commandText = builder.ToString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        dtFilmes = new DataTable();
                        adapter.Fill(dtFilmes);

                        return dtFilmes;
                    }
                }
            }
        }

        public static void Delete(int id)
        {
           
        }
    }
}
