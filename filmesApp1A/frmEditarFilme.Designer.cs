namespace filmesApp1A
{
    partial class frmEditarFilme
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
            dgvFilmes = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            atorBindingSource = new BindingSource(components);
            btSalvar = new Button();
            cbxNacionalidade = new ComboBox();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            numericAnoLancamento = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAnoLancamento).BeginInit();
            SuspendLayout();
            // 
            // dgvFilmes
            // 
            dgvFilmes.AutoGenerateColumns = false;
            dgvFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvFilmes.DataSource = atorBindingSource;
            dgvFilmes.Location = new Point(53, 215);
            dgvFilmes.Name = "dgvFilmes";
            dgvFilmes.Size = new Size(464, 228);
            dgvFilmes.TabIndex = 13;
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
            // btSalvar
            // 
            btSalvar.Location = new Point(230, 129);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 12;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // cbxNacionalidade
            // 
            cbxNacionalidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNacionalidade.FormattingEnabled = true;
            cbxNacionalidade.Location = new Point(249, 84);
            cbxNacionalidade.Name = "cbxNacionalidade";
            cbxNacionalidade.Size = new Size(144, 23);
            cbxNacionalidade.TabIndex = 11;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(248, 26);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(145, 23);
            txtNome.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 189);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 9;
            label3.Text = "Atores:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 87);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 8;
            label2.Text = "Nacionalidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 29);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 57);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 14;
            label4.Text = "Ano de Lançamento:";
            // 
            // numericAnoLancamento
            // 
            numericAnoLancamento.Location = new Point(249, 55);
            numericAnoLancamento.Name = "numericAnoLancamento";
            numericAnoLancamento.Size = new Size(144, 23);
            numericAnoLancamento.TabIndex = 15;
            // 
            // frmEditarFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 491);
            Controls.Add(numericAnoLancamento);
            Controls.Add(label4);
            Controls.Add(dgvFilmes);
            Controls.Add(btSalvar);
            Controls.Add(cbxNacionalidade);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditarFilme";
            Text = "Editar Filme";
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAnoLancamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFilmes;
        private Button btSalvar;
        private ComboBox cbxNacionalidade;
        private TextBox txtNome;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource atorBindingSource;
        private Label label4;
        private NumericUpDown numericAnoLancamento;
    }
}