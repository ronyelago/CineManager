using CineManager.Classes;
using System;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace CineManager.DAO
{
    class SessaoDAO
    {
        private static string connectionString = @"Data Source=CineManager.db3;Version=3";

        public static void Inserir(Sessao sessao)
        {
            string commandText = @"INSERT INTO Sessao(IdCinema, IdFilme, IdSala, Hora_Inicial, Hora_Final, Data)" +
                                 " VALUES('" + sessao.IdCinema + "','" + sessao.IdFilme + "','" + sessao.IdSala +
                                 "','" + sessao.HoraInicial + "','" + sessao.HoraFinal + "','" + sessao.Data + "')";

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

        public static DataTable Selecionar()
        {
            DataTable dtSessoes = null;
            string commandText = @"SELECT Sessao.Id AS 'Código', Cinema.Nome AS 'Cinema'," +
                                 "Filme.Titulo AS 'Filme', Sessao.Hora_Inicial AS 'Hora Inicial'," +
                                 "Sessao.Hora_Final AS 'HoraFinal', Sessao.Data AS 'Data'" +
                                 "FROM Sessao " +
                                 "INNER JOIN Cinema ON Sessao.IdCinema = Cinema.Id " +
                                 "INNER JOIN Filme ON Sessao.IdFilme = Filme.Id";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        dtSessoes = new DataTable();
                        adapter.Fill(dtSessoes);

                        return dtSessoes;
                    }
                }
            }
        }

        public static DataTable Selecionar(params string[] campos)
        {
            DataTable dtSessoes = null;

            StringBuilder builder = new StringBuilder();
            builder.Append(@"SELECT ");

            foreach (var c in campos)
            {
                builder.Append(c);
                builder.Append(",");
            }

            builder.Remove(builder.Length - 1, 1);
            builder.Append(" FROM Sessao");

            string commandText = builder.ToString();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        dtSessoes = new DataTable();
                        adapter.Fill(dtSessoes);

                        return dtSessoes;
                    }
                }
            }
        }

        public static Sessao Selecionar(int id)
        {
            Sessao s = null;
            StringBuilder builder = new StringBuilder();
            builder.Append(@"SELECT Id, IdCinema, IdFilme, Hora_Inicial, Hora_Final, Data ");
            builder.Append("FROM Sessao WHERE Id = " + id);
            string commandText = builder.ToString();

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
                            s = new Sessao();
                            s.Id = int.Parse(reader[0].ToString());
                            s.IdCinema = reader[1].ToString();
                            s.IdFilme = int.Parse(reader[2].ToString());
                            s.HoraInicial = DateTime.Parse(reader[3].ToString());
                            s.HoraFinal = DateTime.Parse(reader[4].ToString());
                            s.Data = DateTime.Parse(reader[5].ToString());
                        }
                    }
                }
            }

            return s;
        }

        public static void Deletar(string id)
        {
            string commandText = @"DELETE FROM Sessao WHERE Id = " + id;

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

        public static void Atualizar(int id, params string[] campos)
        {
            
        }
    }
}
