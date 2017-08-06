using CineManager.Classes;
using CineManager.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CineManager.Forms.SessaoForms
{
    public partial class frmNovaSessao : Form
    {
        List<Filme> filmes = null;
        List<Cinema> cinemas = null;
        List<Sala> salas = null;
        frmLista lista = null;

        /** 
         * Método que cria um Button e o retorna 
         * Parâmetros: 
         * text => define o texto do button
         * point => define a localização do button 
         * size => define o tamanho do button
        **/
        public static Button CriaButton(string text, Point point, Size size)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Location = point;
            btn.Size = size;

            return btn;
        }

        public frmNovaSessao()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Sessao sessao = new Sessao();
                sessao.Data = dtpData.Value.Date;
                sessao.HoraInicial = DateTime.Parse(mtbHoraInicial.Text);
                sessao.HoraFinal = DateTime.Parse(mtbHoraFinal.Text);
                sessao.IdCinema = cinemas.Single(c => c.Nome == tboCinema.Text).Id;
                sessao.IdFilme = filmes.Single(c => c.Titulo == tboFilme.Text).Id;
                sessao.IdSala = cboSala.SelectedItem.ToString();

                SessaoDAO.Inserir(sessao);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCinema_Click(object sender, EventArgs e)
        {
            // Cria um frmLista em tempo de execução
            lista = new frmLista();

            DataTable dtSalas = SalaDAO.Selecionar();
            salas = new List<Sala>();

            for (int i = 0; i < dtSalas.Rows.Count; i++)
            {
                Sala s = new Sala();
                s.Id = dtSalas.Rows[i]["Id"].ToString();
                s.IdCinema = dtSalas.Rows[i]["IdCinema"].ToString();
                s.Capacidade = byte.Parse(dtSalas.Rows[i]["Capacidade"].ToString());
                salas.Add(s);
            }

            // Preenche um DataTable com objetos Cinema vindos do banco de dados
            DataTable dtCinemas = CinemaDAO.Selecionar();
            cinemas = new List<Cinema>();

            // Preenche a lista de cinemas com o DataTable 
            for (int i = 0; i < dtCinemas.Rows.Count; i++)
            {
                Cinema cine = new Cinema();
                cine.Id = dtCinemas.Rows[i]["Id"].ToString();
                cine.Nome = dtCinemas.Rows[i]["Nome"].ToString();
                cine.Endereco = dtCinemas.Rows[i]["Endereco"].ToString();
                cine.NSalas = int.Parse(dtCinemas.Rows[i]["NSalas"].ToString());
                cine.Capacidade = int.Parse(dtCinemas.Rows[i]["Capacidade"].ToString());
                cinemas.Add(cine);
            }

            // Preenche o DataGrid com a lista de cinemas
            lista.dgvLista.DataSource = cinemas;

            // Invoca o método CriaButton para criar um botão em tempo de execução
            // Point(int horizontal, int vertical)
            // Size(int largura, int altura)
            Button btnSelecionar = CriaButton("Selecionar", new Point(800, 473), new Size(100, 30));

            // Delega o evento de click ao button criado dinamicamente
            btnSelecionar.Click += new EventHandler(btnSelecionar_Click);
            // Delega o evendo DoubleClick ao DataGrid
            lista.dgvLista.DoubleClick += new EventHandler(dgvLista_DoubleClick);

            // Adiciona o button ao form
            lista.Controls.Add(btnSelecionar);
            lista.Show();
        }

        private void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            // Captura ítem de índice zero da linha selecionada no DataGrid
            // A variável implicitamente tipada IdCine passa a referenciar este ítem (Id)
            var IdCine = lista.dgvLista.SelectedCells[0];

            tboCinema.Text = lista.dgvLista.SelectedCells[1].Value.ToString();

            // Limpa o ComboBox de Salas
            cboSala.Items.Clear();

            // Preenche o ComboBox de Salas de acordo com o Cinema que foi selecionado
            foreach (var s in salas)
            {
                if (s.IdCinema == IdCine.Value.ToString())
                {
                    cboSala.Items.Add(s.Id);
                }
            }

            // Se algum Cinema foi selecionado, o ComboBox de Salas é ativado
            if (tboCinema.Text != string.Empty)
            {
                cboSala.Enabled = true;
            }

            // Lista suspensa com edição desabilitada e primeiro ítem selecionado
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;

            if (cboSala.Items.Count != 0)
            {
                cboSala.SelectedIndex = 0;
            }            

            lista.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            // Captura ítem de índice zero da linha selecionada no DataGrid
            // A variável implicitamente tipada IdCine passa a referenciar este ítem (Id)
            var IdCine = lista.dgvLista.SelectedCells[0];

            // Insere o nome do cinema selecionado no DataGrid
            tboCinema.Text = lista.dgvLista.SelectedCells[1].Value.ToString();

            // Limpa o ComboBox de Salas
            cboSala.Items.Clear();

            // Preenche o ComboBox de Salas de acordo com o Cinema que foi selecionado
            foreach (var s in salas)
            {
                if (s.IdCinema == IdCine.Value.ToString())
                {
                    cboSala.Items.Add(s.Id);
                }
            }

            // Se algum Cinema foi selecionado, o ComboBox de Salas é ativado
            if (tboCinema.Text != string.Empty)
            {
                cboSala.Enabled = true;
            }

            // Lista suspensa com edição desabilitada e primeiro ítem selecionado
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSala.SelectedIndex = 0;

            lista.Close();
        }

        private void btnFilme_Click(object sender, EventArgs e)
        {
            DataTable dtFilmes = FilmeDAO.Selecionar();

            lista = new frmLista();
            lista.dgvLista.DataSource = dtFilmes;

            dtFilmes = FilmeDAO.Selecionar("Id", "Titulo", "TituloPT");
            filmes = new List<Filme>();

            for (int i = 0; i < dtFilmes.Rows.Count; i++)
            {
                Filme f = new Filme();
                f.Id = int.Parse(dtFilmes.Rows[i]["Id"].ToString());
                f.Titulo = dtFilmes.Rows[i]["Titulo"].ToString();
                f.TituloPT = dtFilmes.Rows[i]["TituloPT"].ToString();
                filmes.Add(f);
            }

            Button btnOk = CriaButton("Ok", new Point(800, 473), new Size(100, 30));
            btnOk.Click += new EventHandler(btnOk_Click);

            lista.dgvLista.DoubleClick += new EventHandler(dgvListaFilmes_DoubleClick);

            lista.Controls.Add(btnOk);
            lista.Show();
            Hide();
        }

        private void dgvListaFilmes_DoubleClick(object sender, EventArgs e)
        {
            // Insere na textBox o título do filme que está selecionado no DataGrid
            tboFilme.Text = lista.dgvLista.SelectedCells[1].Value.ToString();

            // Fecha a lista de filmes e exibe o form NovaSessao
            lista.Close();
            Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Insere na textBox o título do filme que está selecionado no DataGrid
            tboFilme.Text = lista.dgvLista.SelectedCells[1].Value.ToString();

            // Fecha a lista de filmes e exibe o form NovaSessao
            lista.Close();
            Show();
        }

        private void Lista_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void frmNovaSessao_Load(object sender, EventArgs e)
        {
            cboSala.Enabled = false;
        }
    }
}
