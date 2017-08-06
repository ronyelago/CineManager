using CineManager.Classes;
using CineManager.DAO;
using System;
using System.Windows.Forms;

namespace CineManager.Forms.GeneroForms
{
    public partial class frmFindGenero : Form
    {
        public frmFindGenero()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza?", "Confirmar", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                GeneroDAO.Deletar(tboPesquisar.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Genero genero = GeneroDAO.Selecionar(tboPesquisar.Text);

            if (genero != null)
            {
                tboNome.Text = genero.Nome;
            }
            else
            {
                MessageBox.Show("Gênero não encontrado.", "Ops!");
            }
        }
    }
}
