namespace filmesApp1A
{
    partial class frmNovoFilme
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
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            cbxNacionalidade = new ComboBox();
            btCadastrar = new Button();
            label3 = new Label();
            numericAnoLancamento = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericAnoLancamento).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 38);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 101);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Nacionalidade:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(167, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 23);
            txtNome.TabIndex = 2;
            // 
            // cbxNacionalidade
            // 
            cbxNacionalidade.FormattingEnabled = true;
            cbxNacionalidade.Location = new Point(167, 98);
            cbxNacionalidade.Name = "cbxNacionalidade";
            cbxNacionalidade.Size = new Size(150, 23);
            cbxNacionalidade.TabIndex = 3;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(153, 157);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(75, 23);
            btCadastrar.TabIndex = 4;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 72);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 5;
            label3.Text = "Ano de Lançamento:";
            // 
            // numericAnoLancamento
            // 
            numericAnoLancamento.Location = new Point(167, 69);
            numericAnoLancamento.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numericAnoLancamento.Minimum = new decimal(new int[] { 1800, 0, 0, 0 });
            numericAnoLancamento.Name = "numericAnoLancamento";
            numericAnoLancamento.Size = new Size(150, 23);
            numericAnoLancamento.TabIndex = 7;
            numericAnoLancamento.Value = new decimal(new int[] { 1800, 0, 0, 0 });
            // 
            // frmNovoFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 207);
            Controls.Add(numericAnoLancamento);
            Controls.Add(label3);
            Controls.Add(btCadastrar);
            Controls.Add(cbxNacionalidade);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovoFilme";
            Text = "Novo Filme";
            ((System.ComponentModel.ISupportInitialize)numericAnoLancamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private ComboBox cbxNacionalidade;
        private Button btCadastrar;
        private Label label3;
        private NumericUpDown numericAnoLancamento;
    }
}