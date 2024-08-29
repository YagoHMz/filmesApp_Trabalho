namespace filmesApp1A
{
    partial class frmFilmes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtBuscar = new TextBox();
            btBuscar = new Button();
            btCadastrar = new Button();
            btEditar = new Button();
            btRemover = new Button();
            dgvFilmes = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anoLancamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filmeBindingSource = new BindingSource(components);
            btGerenciar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 24);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(594, 23);
            txtBuscar.TabIndex = 0;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(612, 24);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 23);
            btBuscar.TabIndex = 1;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(12, 415);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(126, 23);
            btCadastrar.TabIndex = 2;
            btCadastrar.Text = "Cadastrar Filme";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // btEditar
            // 
            btEditar.Location = new Point(457, 415);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(102, 23);
            btEditar.TabIndex = 3;
            btEditar.Text = "Editar Filme";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btRemover
            // 
            btRemover.Location = new Point(565, 415);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(122, 23);
            btRemover.TabIndex = 4;
            btRemover.Text = "Remover Filme";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // dgvFilmes
            // 
            dgvFilmes.AutoGenerateColumns = false;
            dgvFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, anoLancamentoDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvFilmes.DataSource = filmeBindingSource;
            dgvFilmes.Location = new Point(12, 62);
            dgvFilmes.Name = "dgvFilmes";
            dgvFilmes.Size = new Size(675, 347);
            dgvFilmes.TabIndex = 5;
            dgvFilmes.CellClick += dgvFilmes_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // anoLancamentoDataGridViewTextBoxColumn
            // 
            anoLancamentoDataGridViewTextBoxColumn.DataPropertyName = "AnoLancamento";
            anoLancamentoDataGridViewTextBoxColumn.HeaderText = "AnoLancamento";
            anoLancamentoDataGridViewTextBoxColumn.Name = "anoLancamentoDataGridViewTextBoxColumn";
            // 
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            // 
            // filmeBindingSource
            // 
            filmeBindingSource.DataSource = typeof(Models.Filme);
            // 
            // btGerenciar
            // 
            btGerenciar.Location = new Point(335, 415);
            btGerenciar.Name = "btGerenciar";
            btGerenciar.Size = new Size(116, 23);
            btGerenciar.TabIndex = 6;
            btGerenciar.Text = "Gerenciar Elenco";
            btGerenciar.UseVisualStyleBackColor = true;
            btGerenciar.Click += btGerenciar_Click;
            // 
            // frmFilmes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 450);
            Controls.Add(btGerenciar);
            Controls.Add(dgvFilmes);
            Controls.Add(btRemover);
            Controls.Add(btEditar);
            Controls.Add(btCadastrar);
            Controls.Add(btBuscar);
            Controls.Add(txtBuscar);
            Name = "frmFilmes";
            Text = "Filmes";
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Button btBuscar;
        private Button btCadastrar;
        private Button btEditar;
        private Button btRemover;
        private DataGridView dgvFilmes;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anoLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource filmeBindingSource;
        private Button btGerenciar;
    }
}