using CineManager.Classes;
using CineManager.DAO;
using System;
using System.Windows.Forms;

namespace CineManager.Forms
{
    public partial class frmNovoAtorDiretor : Form
    {
        public frmNovoAtorDiretor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                AtorDiretor p = new AtorDiretor();
                p.Nome = tboNome.Text;
                p.DataNascimento = DateTime.Parse(tboDataNascimento.Text);
                p.Nacionalidade = tboNacionalidade.Text;
                // Converte a foto do PictureBox em um array de bytes.
                // O objeto pbFoto (PictureBox) é passado como argumento.
                p.Foto = Photo.ConvertFileToByte(pbFoto);

                AtorDiretorDAO.Inserir(p);

                Close();

                frmLista listaAD = new frmLista();
                listaAD.dgvLista.DataSource = AtorDiretorDAO.Selecionar();
                listaAD.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Photo.SelectImage(pbFoto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
