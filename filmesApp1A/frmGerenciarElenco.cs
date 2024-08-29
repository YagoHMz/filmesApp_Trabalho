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
    public partial class frmGerenciarElenco : Form
    {
        Ator ator;
        Filme filme;
        Contexto db;
        private Filme selecionado;

        public frmGerenciarElenco(Filme filme, Contexto db)
        {
            InitializeComponent();
            this.filme = filme;
            this.db = db;
            RecarregarElenco();
            CarregarAtoresDisponiveis();
        }

        public frmGerenciarElenco(Filme selecionado)
        {
            this.selecionado = selecionado;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Ator atorSelecionado = (Ator)cbxElenco.SelectedItem;
            filme.Atores.Add(atorSelecionado);
            db.SaveChanges();
            RecarregarElenco();
            CarregarAtoresDisponiveis();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            int idAtor = (int)dgvElenco.SelectedCells[0].Value;
            Ator atorRemover = filme.Atores.First(a => a.Id == idAtor);
            filme.Atores.Remove(atorRemover);
            db.SaveChanges();
            RecarregarElenco();
            CarregarAtoresDisponiveis();
        }

        private void RecarregarElenco()
        {
            dgvElenco.DataSource = filme.Atores.ToList();
        }

        private void CarregarAtoresDisponiveis()
        {
            var atoresDisponiveis = db.Ator.Where(a => !filme.Atores.Contains(a)).ToList();
            cbxElenco.DataSource = atoresDisponiveis;
        }



    }
}
