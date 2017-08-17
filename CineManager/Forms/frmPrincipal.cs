using System;
using System.Windows.Forms;
using CineManager.Forms;
using CineManager.Forms.CinemaForms;
using CineManager.DAO;
using CineManager.Forms.FilmeForms;
using CineManager.Forms.SessaoForms;
using System.Data;
using System.Collections.Generic;
using CineManager.Classes;
using System.Drawing;
using System.Linq;
using CineManager.Forms.SalaForms;

namespace CineManager
{
    public partial class frmPrincipal : Form
    {
        frmNovaSessao frmEditar = null;
        frmNovoAtorDiretor editarAd = null;
        frmLista listaSessoes = null;
        frmLista listaAD = null;
        DataTable dtSessoes = null;
        List<Sessao> sessoes = null;
        DataTable dtAtoresDiretores = null;
        List<AtorDiretor> atoresDiretores = null;
        DataTable dtGeneros = null;
        List<Genero> generos = null;
        DataTable dtSalas = null;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void adicionarCinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovoCinema novoCinema = new frmNovoCinema();
            novoCinema.MdiParent = this;
            novoCinema.Show();
        }

        private void listaDeCinemasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLista listaCinemas = new frmLista();
            listaCinemas.Text = "Lista de Cinemas - CineManager";
            listaCinemas.dgvLista.DataSource = CinemaDAO.Selecionar();
            listaCinemas.Show();
            
        }

        private void adicionarFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovoFilme nf = new frmNovoFilme();
            nf.Show();
        }

        private void listaDeFilmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria um form que possui um dataGridView
            frmLista listaFilmes = new frmLista();
            
            // Especifica qual a fonte de dados do DataGridView
            listaFilmes.dgvLista.DataSource = FilmeDAO.Selecionar();
            
            // Exibe o form com o DataGridView
            listaFilmes.Show();
        }

        private void novaSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovaSessao ns = new frmNovaSessao();
            ns.Show();
        }

        private void listaDeSessõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaSessoes = new frmLista();
            listaSessoes.Load += ListaSessoes_Load;
            listaSessoes.Text = "Lista de Sessões";
            listaSessoes.Show();
        }

        private void ListaSessoes_Load(object sender, EventArgs e)
        {
            dtSessoes = SessaoDAO.Selecionar();
            listaSessoes.dgvLista.DataSource = dtSessoes;
            listaSessoes.dgvLista.CellContentClick += new DataGridViewCellEventHandler(dgvLista_CellContentClick);

            var exibir = new DataGridViewButtonColumn();
            exibir.Text = "Exibir";
            exibir.HeaderText = "Exibir";
            exibir.Name = "clmEditar";
            exibir.UseColumnTextForButtonValue = true;
            listaSessoes.dgvLista.Columns.Add(exibir);
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                frmEditar = new frmNovaSessao();
                frmEditar.Load += FrmEditar_Load;
                frmEditar.Show();
            }
        }

        private void FrmEditar_Load(object sender, EventArgs e)
        {
            dtSessoes = SessaoDAO.Selecionar("Id", "IdCinema", "IdFilme", "Hora_Inicial", "Hora_Final", "Data");

            sessoes = new List<Sessao>();

            for (int i = 0; i < dtSessoes.Rows.Count; i++)
            {
                Sessao s = new Sessao();
                s.Id = int.Parse(dtSessoes.Rows[i]["Id"].ToString());
                s.IdCinema = dtSessoes.Rows[i]["IdCinema"].ToString();
                s.IdFilme = int.Parse(dtSessoes.Rows[i]["IdFilme"].ToString());
                s.HoraInicial = DateTime.Parse(dtSessoes.Rows[i]["Hora_Inicial"].ToString());
                s.HoraFinal = DateTime.Parse(dtSessoes.Rows[i]["Hora_final"].ToString());
                s.Data = DateTime.Parse(dtSessoes.Rows[i]["Data"].ToString());
                sessoes.Add(s);
            }

            var id = listaSessoes.dgvLista.SelectedCells[0];

            Sessao sessao = sessoes.Single(s => s.Id == int.Parse(id.Value.ToString()));

            frmEditar.dtpData.Text = sessao.Data.ToString();
            frmEditar.mtbHoraInicial.Text = sessao.HoraInicial.ToString();
            frmEditar.mtbHoraFinal.Text = sessao.HoraFinal.ToString();
            frmEditar.tboCinema.Text = sessao.IdCinema;
            frmEditar.tboFilme.Text = sessao.IdFilme.ToString();

            frmEditar.dtpData.Enabled = false;
            frmEditar.mtbHoraInicial.Enabled = false;
            frmEditar.mtbHoraFinal.Enabled = false;
            frmEditar.tboCinema.Enabled = false;
            frmEditar.tboFilme.Enabled = false;
            frmEditar.btnFilme.Enabled = false;
            frmEditar.btnCinema.Enabled = false;
            frmEditar.btnSalvar.Enabled = false;
            frmEditar.btnSalvar.Size = new Size(94, 23);
            frmEditar.btnSalvar.Location = new Point(345, 186);

            frmEditar.btnCancelar.Location = new Point(100, 186);
            frmEditar.btnCancelar.Size = new Size(94, 23);

            Button btnEditar = new Button();
            btnEditar.Location = new Point(240, 186);
            btnEditar.Size = new Size(94, 23);
            btnEditar.Text = "Editar";
            btnEditar.Click += BtnEditar_Click;
            frmEditar.Controls.Add(btnEditar);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            frmEditar.dtpData.Enabled = true;
            frmEditar.mtbHoraInicial.Enabled = true;
            frmEditar.mtbHoraFinal.Enabled = true;
            frmEditar.tboCinema.Enabled = true;
            frmEditar.tboFilme.Enabled = true;
            frmEditar.btnFilme.Enabled = true;
            frmEditar.btnCinema.Enabled = true;
            frmEditar.btnSalvar.Enabled = true;
        }

        private void novaSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovaSala novaSala = new frmNovaSala();
            novaSala.Show();
        }

        private void adicionarAtorDiretorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovoAtorDiretor novoAD = new frmNovoAtorDiretor();
            novoAD.Show();
        }

        private void listaDeAtoresDiretoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaAD = new frmLista();
            listaAD.Load += ListaAD_Load;
            listaAD.Show();
        }

        private void ListaAD_Load(object sender, EventArgs e)
        {
            // Preenche o dataTable com registros do banco de dados
            dtAtoresDiretores = AtorDiretorDAO.Selecionar();
            // Preenche o dataGrid com todos os atoresDiretores

            listaAD.dgvLista.Columns.Add("Id", "Id");
            listaAD.dgvLista.Columns.Add("Nome", "Nome");
            listaAD.dgvLista.Columns.Add("Nacionalidade", "Nacionalidade");
            listaAD.dgvLista.Columns.Add("dtNascimento", "Data de Nascimento");

            for (int i = 0; i < dtAtoresDiretores.Rows.Count; i++)
            {
                listaAD.dgvLista.Rows.Add(
                                    dtAtoresDiretores.Rows[i]["Id"].ToString(),
                                    dtAtoresDiretores.Rows[i]["Nome"].ToString(),
                                    dtAtoresDiretores.Rows[i]["Nacionalidade"].ToString(),
                                    dtAtoresDiretores.Rows[i]["dtNascimento"].ToString()
                                    );
            }

            // Delega o evento de click ao botão btnPesquisar
            listaAD.btnPesquisar.Click += BtnPesquisar_Click;
            // Delega o evento de pressionamento de tecla a textBox tboPesquisa
            listaAD.tboPesquisa.KeyPress += TboPesquisa_KeyPress;
            // Delega o evento de doubleClick ao dataGrid
            listaAD.dgvLista.DoubleClick += DgvLista_DoubleClick;

            atoresDiretores = new List<AtorDiretor>();

            // Preenche a lista com os registros do DataTable de Atores/Diretores
            for (int i = 0; i < dtAtoresDiretores.Rows.Count; i++)
            {
                AtorDiretor ad = new AtorDiretor();
                ad.Id = int.Parse(dtAtoresDiretores.Rows[i]["Id"].ToString());
                ad.Nome = dtAtoresDiretores.Rows[i]["Nome"].ToString();
                ad.Nacionalidade = dtAtoresDiretores.Rows[i]["Nacionalidade"].ToString();
                ad.DataNascimento = DateTime.Parse(dtAtoresDiretores.Rows[i]["DtNascimento"].ToString());
                ad.Foto = (byte[])dtAtoresDiretores.Rows[i]["Foto"];
                atoresDiretores.Add(ad);
            }
        }

        private void DgvLista_DoubleClick(object sender, EventArgs e)
        {
            var id = int.Parse(listaAD.dgvLista.SelectedCells[0].Value.ToString());

            AtorDiretor ad = new AtorDiretor();
            ad = atoresDiretores.Single(a => a.Id == id);

            editarAd = new frmNovoAtorDiretor();
            editarAd.tboNome.Text = ad.Nome;
            editarAd.tboDataNascimento.Text = ad.DataNascimento.ToString();
            editarAd.tboNacionalidade.Text = ad.Nacionalidade;
            editarAd.pbFoto.Image = Photo.ConvertByteToImage(ad.Foto);
            editarAd.pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;

            editarAd.tboNome.Enabled = false;
            editarAd.tboNacionalidade.Enabled = false;
            editarAd.tboDataNascimento.Enabled = false;
            editarAd.btnSelecionar.Enabled = false;

            editarAd.btnSalvar.Hide();
            Button btnEditar = new Button();
            btnEditar.Text = "Editar";
            btnEditar.Size = new Size(97, 23);
            btnEditar.Location = new Point(272, 465);
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Parent = editarAd;
            btnEditar.Show();
            btnEditar.Click += BtnEditar_Click1;

            editarAd.Show();
        }

        // Evento de click do botão Editar do form Editar Ator/Diretor
        private void BtnEditar_Click1(object sender, EventArgs e)
        {
            editarAd.tboNome.Enabled = true;
            editarAd.tboDataNascimento.Enabled = true;
            editarAd.tboNacionalidade.Enabled = true;
            editarAd.btnSelecionar.Enabled = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var btnEditar = (Button)sender;

            if (btnEditar.Text == "Editar")
            {
                editarAd.tboNome.Enabled = true;
                editarAd.tboNacionalidade.Enabled = true;
                editarAd.tboDataNascimento.Enabled = true;
                editarAd.btnSelecionar.Enabled = true;
            }
        }

        private void TboPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tboPesquisa = (TextBox)sender;
           
            // Se a tecla pressionada foi "Enter" e a TextBox não estiver vazia este bloco é executado
            if (e.KeyChar == 13 && tboPesquisa.Text != String.Empty)
            {
                // Busca todos os registros em que o nome contém a substring digitada na TextBox
                var listAD = (from ad in atoresDiretores
                             where ad.Nome.ToUpper().Contains(tboPesquisa.Text.ToUpper())
                             select ad).ToList();

                // Se forem encontrados registros, este bloco é executado
                if (listAD.Count != 0)
                {
                    // Limpa o dataGrid
                    listaAD.dgvLista.DataSource = null;
                    // Preenche o dataGrid com os registros encontrados
                    listaAD.dgvLista.DataSource = listAD;
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Resultado da Busca");
                }
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            // Se a TextBox tboPesquisa não estiver vazia, este bloco é executado
            if (listaAD.tboPesquisa.Text != String.Empty)
            {
                // Busca todos os registros em que o nome contém a substring digitada na TextBox
                var listAD = (from ad in atoresDiretores
                              where ad.Nome.ToUpper().Contains(listaAD.tboPesquisa.Text.ToUpper())
                              select ad).ToList();

                // Se forem encontrados registros, este bloco é executado
                if (listAD.Count != 0)
                {
                    // Limpa o dataGrid
                    listaAD.dgvLista.DataSource = null;
                    // Preenche o dataGrid com os registros encontrados
                    listaAD.dgvLista.DataSource = listAD;
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Resultado da Busca");
                }
            }
        }

        private void listaDeSalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtSalas = SalaDAO.Selecionar();
            frmLista listaSalas = new frmLista();
            listaSalas.dgvLista.DataSource = dtSalas;

            listaSalas.Show();
        }

        private void listaDeGênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtGeneros = GeneroDAO.Selecionar();
            frmLista listaGeneros = new frmLista();
            listaGeneros.dgvLista.DataSource = dtGeneros;

            listaGeneros.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por\n\n Ronye do Lago Cornetti Rocha\n\n 2017", "Sobre");
        }
    }
}
