namespace LocadoraApp
{
    partial class FrmNovaLocacao
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
            groupBox1 = new GroupBox();
            mtxtTelefone = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            mtxtCpf = new MaskedTextBox();
            txtNomeCliente = new TextBox();
            label1 = new Label();
            grbNovoItem = new GroupBox();
            numPrazoDevolução = new NumericUpDown();
            numQuantidade = new NumericUpDown();
            numValor = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnAdicionar = new Button();
            cmbMidias = new Componentes.MidiasComboBox();
            dgvItensLocacao = new DataGridView();
            btnCacncelar = new Button();
            btnFecharlocacao = new Button();
            groupBox1.SuspendLayout();
            grbNovoItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrazoDevolução).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensLocacao).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(mtxtTelefone);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(mtxtCpf);
            groupBox1.Controls.Add(txtNomeCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(914, 160);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // mtxtTelefone
            // 
            mtxtTelefone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            mtxtTelefone.Location = new Point(457, 108);
            mtxtTelefone.Mask = "(99) 99999-9999";
            mtxtTelefone.Name = "mtxtTelefone";
            mtxtTelefone.Size = new Size(415, 30);
            mtxtTelefone.TabIndex = 3;
            mtxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 85);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 4;
            label3.Text = "Telefone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 85);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 3;
            label2.Text = "CPF";
            // 
            // mtxtCpf
            // 
            mtxtCpf.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            mtxtCpf.Location = new Point(6, 108);
            mtxtCpf.Mask = "999.999.999-99";
            mtxtCpf.Name = "mtxtCpf";
            mtxtCpf.Size = new Size(437, 30);
            mtxtCpf.TabIndex = 2;
            mtxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeCliente.Location = new Point(6, 55);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(866, 27);
            txtNomeCliente.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // grbNovoItem
            // 
            grbNovoItem.BackColor = Color.DodgerBlue;
            grbNovoItem.Controls.Add(numPrazoDevolução);
            grbNovoItem.Controls.Add(numQuantidade);
            grbNovoItem.Controls.Add(numValor);
            grbNovoItem.Controls.Add(label6);
            grbNovoItem.Controls.Add(label5);
            grbNovoItem.Controls.Add(label4);
            grbNovoItem.Controls.Add(btnAdicionar);
            grbNovoItem.Controls.Add(cmbMidias);
            grbNovoItem.Location = new Point(18, 185);
            grbNovoItem.Name = "grbNovoItem";
            grbNovoItem.Size = new Size(908, 237);
            grbNovoItem.TabIndex = 1;
            grbNovoItem.TabStop = false;
            grbNovoItem.Text = "Itens da Locação";
            // 
            // numPrazoDevolução
            // 
            numPrazoDevolução.Location = new Point(521, 114);
            numPrazoDevolução.Name = "numPrazoDevolução";
            numPrazoDevolução.Size = new Size(381, 27);
            numPrazoDevolução.TabIndex = 7;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(268, 114);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(218, 27);
            numQuantidade.TabIndex = 6;
            // 
            // numValor
            // 
            numValor.DecimalPlaces = 2;
            numValor.Location = new Point(7, 114);
            numValor.Name = "numValor";
            numValor.Size = new Size(245, 27);
            numValor.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(268, 91);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 4;
            label6.Text = "Quantidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(516, 91);
            label5.Name = "label5";
            label5.Size = new Size(185, 20);
            label5.TabIndex = 3;
            label5.Text = "Prazo de Devolução (Dias)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 91);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 2;
            label4.Text = "Valor";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(791, 195);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(106, 37);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // cmbMidias
            // 
            cmbMidias.BackColor = Color.RebeccaPurple;
            cmbMidias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMidias.ForeColor = Color.White;
            cmbMidias.FormattingEnabled = true;
            cmbMidias.Location = new Point(6, 38);
            cmbMidias.Name = "cmbMidias";
            cmbMidias.Size = new Size(896, 28);
            cmbMidias.TabIndex = 0;
            // 
            // dgvItensLocacao
            // 
            dgvItensLocacao.BackgroundColor = Color.MediumTurquoise;
            dgvItensLocacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensLocacao.Location = new Point(18, 428);
            dgvItensLocacao.Name = "dgvItensLocacao";
            dgvItensLocacao.RowHeadersWidth = 51;
            dgvItensLocacao.RowTemplate.Height = 29;
            dgvItensLocacao.Size = new Size(908, 117);
            dgvItensLocacao.TabIndex = 2;
            // 
            // btnCacncelar
            // 
            btnCacncelar.Location = new Point(698, 560);
            btnCacncelar.Name = "btnCacncelar";
            btnCacncelar.Size = new Size(94, 37);
            btnCacncelar.TabIndex = 3;
            btnCacncelar.Text = "cancelar";
            btnCacncelar.UseVisualStyleBackColor = true;
            // 
            // btnFecharlocacao
            // 
            btnFecharlocacao.Location = new Point(798, 560);
            btnFecharlocacao.Name = "btnFecharlocacao";
            btnFecharlocacao.Size = new Size(122, 37);
            btnFecharlocacao.TabIndex = 4;
            btnFecharlocacao.Text = "Fechar Locação";
            btnFecharlocacao.UseVisualStyleBackColor = true;
            btnFecharlocacao.Click += btnFecharlocacao_Click;
            // 
            // FrmNovaLocacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 609);
            Controls.Add(btnFecharlocacao);
            Controls.Add(btnCacncelar);
            Controls.Add(dgvItensLocacao);
            Controls.Add(grbNovoItem);
            Controls.Add(groupBox1);
            Name = "FrmNovaLocacao";
            Text = "Nova Locação";
            Load += FrmNovaLocacao_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grbNovoItem.ResumeLayout(false);
            grbNovoItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrazoDevolução).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensLocacao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private MaskedTextBox mtxtCpf;
        private TextBox txtNomeCliente;
        private Label label1;
        private MaskedTextBox mtxtTelefone;
        private Label label3;
        private GroupBox grbNovoItem;
        private Componentes.MidiasComboBox cmbMidias;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnAdicionar;
        private NumericUpDown numPrazoDevolução;
        private NumericUpDown numQuantidade;
        private NumericUpDown numValor;
        private DataGridView dgvItensLocacao;
        private Button btnCacncelar;
        private Button btnFecharlocacao;
    }
}