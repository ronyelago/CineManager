using CineManager.Classes;
using CineManager.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CineManager.Forms.SalaForms
{
    public partial class frmNovaSala : Form
    {
        List<Cinema> cinemas = null;
        DataTable dtCinemas = null;

        public frmNovaSala()
        {
            InitializeComponent();
        }

        private void frmNovaSala_Load(object sender, EventArgs e)
        {
            try
            {
                // Cria um DataTable e o preenche com cinemas vindos do banco de dados
                dtCinemas = new DataTable();
                dtCinemas = CinemaDAO.Selecionar();

                // Cria e preenche uma lista de cinemas com os cinemas do DataTable
                cinemas = new List<Cinema>();

                for (int i = 0; i < dtCinemas.Rows.Count; i++)
                {
                    Cinema c = new Cinema();
                    c.Id = dtCinemas.Rows[i]["Id"].ToString();
                    c.Nome = dtCinemas.Rows[i]["Nome"].ToString();
                    c.Endereco = dtCinemas.Rows[i]["Endereco"].ToString();
                    c.NSalas = int.Parse(dtCinemas.Rows[i]["NSalas"].ToString());
                    c.Capacidade = int.Parse(dtCinemas.Rows[i]["Capacidade"].ToString());
                    cinemas.Add(c);
                }

                // Preenche a comboBox com uma lista de cinemas vindos do banco de dados
                foreach (Cinema c in cinemas)
                {
                    cboCinema.Items.Add(c.Nome);
                }

                // Lista suspensa e não editável e primeiro ítem da lista é selecionado (index 0)
                cboCinema.DropDownStyle = ComboBoxStyle.DropDownList;
                cboCinema.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }

            tboId.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Sala s = new Sala();
            string idCinema = String.Empty;

            // Se houver um ítem selecionado na comboBox este bloco é executado:
            if (cboCinema.SelectedItem != null)
            {
                // Seleciona o id do cinema selecionado na comboBox de cinemas
                idCinema = cinemas.Single(c => c.Nome == cboCinema.SelectedItem.ToString()).Id;
            }

            try
            {
                // Se todos os campos estiverem preenchidos corretamente este bloco é executado:
                if (tboId.Text != String.Empty && idCinema != null && mtbCapacidade.Text != String.Empty)
                {
                    s.Id = tboId.Text;
                    s.IdCinema = idCinema;
                    s.Capacidade = byte.Parse(mtbCapacidade.Text);

                    SalaDAO.Inserir(s);
                }
                // Do contrário, esta mensagem será exibida:
                else
                {
                    MessageBox.Show("Favor preencher todos os campos.", "Erro");
                }     
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

    }
}
