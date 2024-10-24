namespace LocadoraApp
{
    partial class FrmNovaMidia
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
            numCodigo = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            txtTitulo = new TextBox();
            cmbGenero = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtAutor = new TextBox();
            cmbClassificacao = new ComboBox();
            numDuracao = new NumericUpDown();
            btnSalvar = new Button();
            btnCancelar = new Button();
            txtSinopse = new TextBox();
            btnEditar = new Button();
            btnApagar = new Button();
            numAnoLancamento = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numCodigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuracao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAnoLancamento).BeginInit();
            SuspendLayout();
            // 
            // numCodigo
            // 
            numCodigo.Location = new Point(56, 52);
            numCodigo.Name = "numCodigo";
            numCodigo.Size = new Size(341, 27);
            numCodigo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 26);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 1;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 100);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 2;
            label2.Text = "Título";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(56, 126);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(341, 27);
            txtTitulo.TabIndex = 3;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Animação", "Comédia", "Suspense", "Terror", "Aventura", "Romance" });
            cmbGenero.Location = new Point(56, 192);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(341, 28);
            cmbGenero.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 166);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 5;
            label3.Text = "Gênero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(59, 238);
            label4.Name = "label4";
            label4.Size = new Size(164, 23);
            label4.TabIndex = 6;
            label4.Text = "Ano de Lançamento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(435, 100);
            label5.Name = "label5";
            label5.Size = new Size(53, 23);
            label5.TabIndex = 7;
            label5.Text = "Autor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(435, 238);
            label6.Name = "label6";
            label6.Size = new Size(151, 23);
            label6.TabIndex = 8;
            label6.Text = "Duração (Minutos)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(435, 169);
            label7.Name = "label7";
            label7.Size = new Size(183, 23);
            label7.TabIndex = 9;
            label7.Text = "Classificação Indicativa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(59, 303);
            label8.Name = "label8";
            label8.Size = new Size(69, 23);
            label8.TabIndex = 10;
            label8.Text = "Sinopse";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(435, 126);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(322, 27);
            txtAutor.TabIndex = 12;
            // 
            // cmbClassificacao
            // 
            cmbClassificacao.FormattingEnabled = true;
            cmbClassificacao.Items.AddRange(new object[] { "12", "14", "16", "18+" });
            cmbClassificacao.Location = new Point(435, 195);
            cmbClassificacao.Name = "cmbClassificacao";
            cmbClassificacao.Size = new Size(322, 28);
            cmbClassificacao.TabIndex = 13;
            // 
            // numDuracao
            // 
            numDuracao.Location = new Point(436, 267);
            numDuracao.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numDuracao.Name = "numDuracao";
            numDuracao.Size = new Size(321, 27);
            numDuracao.TabIndex = 14;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(583, 412);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(683, 412);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtSinopse
            // 
            txtSinopse.Location = new Point(56, 329);
            txtSinopse.Multiline = true;
            txtSinopse.Name = "txtSinopse";
            txtSinopse.Size = new Size(701, 77);
            txtSinopse.TabIndex = 17;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(492, 412);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(392, 409);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(94, 29);
            btnApagar.TabIndex = 19;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // numAnoLancamento
            // 
            numAnoLancamento.Location = new Point(56, 264);
            numAnoLancamento.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numAnoLancamento.Name = "numAnoLancamento";
            numAnoLancamento.Size = new Size(341, 27);
            numAnoLancamento.TabIndex = 20;
            // 
            // FrmNovaMidia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numAnoLancamento);
            Controls.Add(btnApagar);
            Controls.Add(btnEditar);
            Controls.Add(txtSinopse);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(numDuracao);
            Controls.Add(cmbClassificacao);
            Controls.Add(txtAutor);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbGenero);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numCodigo);
            Name = "FrmNovaMidia";
            Text = "Nova Mídia";
            ((System.ComponentModel.ISupportInitialize)numCodigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuracao).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAnoLancamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numCodigo;
        private Label label1;
        private Label label2;
        private TextBox txtTitulo;
        private ComboBox cmbGenero;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtAutor;
        private ComboBox cmbClassificacao;
        private NumericUpDown numDuracao;
        private Button btnSalvar;
        private Button btnCancelar;
        private TextBox txtSinopse;
        private Button btnEditar;
        private Button btnApagar;
        private NumericUpDown numAnoLancamento;
    }
}