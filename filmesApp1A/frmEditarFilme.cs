using filmesApp1A.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmesApp1A
{
    public partial class frmEditarFilme : Form
    {
        Filme filme;
        Contexto db;

        public frmEditarFilme(Filme filme)
        {
            InitializeComponent();

            this.filme = filme;
            this.db = new Contexto();

            txtNome.Text = filme.Nome;

            numericAnoLancamento.Minimum = 1800;
            numericAnoLancamento.Maximum = 2024;
            numericAnoLancamento.Value = filme.AnoLancamento;

            List<Pais> paises = this.db.Pais.ToList();
            cbxNacionalidade.DataSource = paises;

            cbxNacionalidade.SelectedIndex =
                cbxNacionalidade.FindStringExact(filme.Nacionalidade.Nome);

            dgvFilmes.DataSource = filme.Atores;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            filme.Nome = txtNome.Text;
            filme.AnoLancamento = (int)numericAnoLancamento.Value;
            filme.Nacionalidade = this.db.Pais
                .Where(p => p.Nome == cbxNacionalidade.SelectedItem.ToString())
                .First();

            this.db.Filme.Update(filme);
            this.db.SaveChanges();

            MessageBox.Show("Sucesso!");
        }
    }
}
