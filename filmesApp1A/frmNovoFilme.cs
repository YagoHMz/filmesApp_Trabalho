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
    public partial class frmNovoFilme : Form
    {
        Contexto db;
        public frmNovoFilme()
        {
            InitializeComponent();

            this.db = new Contexto();

            List<Pais> paises = this.db.Pais.ToList();
            cbxNacionalidade.DataSource = paises;
        }


        private void btCadastrar_Click_1(object sender, EventArgs e)
        {
            Filme novo = new Filme();
            novo.Nome = txtNome.Text;

            novo.AnoLancamento = (int)numericAnoLancamento.Value;

            Pais p = this.db.Pais
                .Where(
                pais => pais.Nome == cbxNacionalidade.SelectedItem.ToString()
                ).First();

            novo.Nacionalidade = p;

            this.db.Filme.Add(novo);
            this.db.SaveChanges();

            MessageBox.Show("Sucesso!");
            this.Close();
        }
    }
}
