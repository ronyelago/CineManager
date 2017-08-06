using CineManager.Classes;
using CineManager.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CineManager.Forms.FilmeForms
{
    public partial class frmNovoFilme : Form
    {
        List<Genero> generos = null;
        DataTable dtGeneros = null;

        public frmNovoFilme()
        {
            InitializeComponent();
        }

        // Evento de carregamento do Form
        private void frmNovoFilme_Load(object sender, EventArgs e)
        {
            // Inicia o form com o cursor neste componente
            tboTituloOriginal.Focus();

            // Preenche os ítens do comboBox de classificação etária
            for (int i = 6; i <= 18; i++)
            {
                cboClassificacao.Items.Add(i + " anos");
            }

            // Preenche o DataTable com os dados vindos do banco de dados
            dtGeneros = GeneroDAO.Selecionar();
            // Instancia uma Lista de Gêneros vazia
            generos = new List<Genero>();

            // Preenche a lista de generos com dados do DataTable
            for (int i = 0; i < dtGeneros.Rows.Count; i++)
            {
                Genero g = new Genero();
                g.Id = dtGeneros.Rows[i]["Id"].ToString();
                g.Nome = dtGeneros.Rows[i]["Nome"].ToString();
                generos.Add(g);
            }

            // Preenche o comboBox de gêneros com a lista de gêneros
            foreach (var g in generos)
            {
                cboGeneros.Items.Add(g.Nome);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            // Este método seleciona uma imagem que é inserida
            // na PictureBox que é passada como parâmetro
            Photo.SelectImage(pbFoto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLista listaDiretores = new frmLista();
            listaDiretores.dgvLista.DataSource = AtorDiretorDAO.Selecionar();
            listaDiretores.Show();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
