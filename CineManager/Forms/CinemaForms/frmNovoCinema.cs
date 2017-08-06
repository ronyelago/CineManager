using CineManager.Classes;
using CineManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineManager.Forms.CinemaForms
{
    public partial class frmNovoCinema : Form
    {
        public frmNovoCinema()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Cinema cinema = new Cinema();
                cinema.Id = tboId.Text.ToUpper();
                cinema.Nome = tboNome.Text;
                cinema.Endereco = tboEndereco.Text;
                cinema.NSalas = int.Parse(cboNSalas.SelectedItem.ToString());
                cinema.Capacidade = int.Parse(mtbCapacidade.Text);
                cinema.Foto = Photo.ConvertFileToByte(pbFoto);

                CinemaDAO.Inserir(cinema);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Photo.SelectImage(pbFoto);
        }
    }
}
