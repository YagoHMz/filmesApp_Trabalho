namespace filmesApp1A
{
    partial class frmGerenciarElenco
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
            dgvElenco = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            atorBindingSource = new BindingSource(components);
            label1 = new Label();
            cbxElenco = new ComboBox();
            btAdicionar = new Button();
            btExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvElenco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvElenco
            // 
            dgvElenco.AutoGenerateColumns = false;
            dgvElenco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElenco.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvElenco.DataSource = atorBindingSource;
            dgvElenco.Location = new Point(12, 128);
            dgvElenco.Name = "dgvElenco";
            dgvElenco.Size = new Size(476, 300);
            dgvElenco.TabIndex = 0;
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
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            // 
            // atorBindingSource
            // 
            atorBindingSource.DataSource = typeof(Models.Ator);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 59);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 1;
            label1.Text = "Atores Disponíveis:";
            // 
            // cbxElenco
            // 
            cbxElenco.FormattingEnabled = true;
            cbxElenco.Location = new Point(243, 56);
            cbxElenco.Name = "cbxElenco";
            cbxElenco.Size = new Size(195, 23);
            cbxElenco.TabIndex = 2;
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(12, 99);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(234, 23);
            btAdicionar.TabIndex = 3;
            btAdicionar.Text = "Adicionar ao Elenco";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(252, 99);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(236, 23);
            btExcluir.TabIndex = 4;
            btExcluir.Text = "Excluir do Elenco";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // frmGerenciarElenco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 440);
            Controls.Add(btExcluir);
            Controls.Add(btAdicionar);
            Controls.Add(cbxElenco);
            Controls.Add(label1);
            Controls.Add(dgvElenco);
            Name = "frmGerenciarElenco";
            Text = "Gerenciar Elenco";
            ((System.ComponentModel.ISupportInitialize)dgvElenco).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvElenco;
        private Label label1;
        private ComboBox cbxElenco;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource atorBindingSource;
        private Button btAdicionar;
        private Button btExcluir;
    }
}