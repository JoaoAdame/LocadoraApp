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
            grbDadosLocacao = new GroupBox();
            numValorTotal = new NumericUpDown();
            txtStatus = new TextBox();
            dateDataLocacao = new DateTimePicker();
            label7 = new Label();
            lblValorTotal = new Label();
            lblDataLocacao = new Label();
            dgvItensLocacao = new DataGridView();
            btnCacncelar = new Button();
            btnFecharlocacao = new Button();
            groupBox1.SuspendLayout();
            grbNovoItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrazoDevolução).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            grbDadosLocacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numValorTotal).BeginInit();
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
            grbNovoItem.Location = new Point(18, 185);
            grbNovoItem.Name = "grbNovoItem";
            grbNovoItem.Size = new Size(908, 192);
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
            btnAdicionar.Location = new Point(793, 147);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(106, 37);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // grbDadosLocacao
            // 
            grbDadosLocacao.BackColor = Color.LightSkyBlue;
            grbDadosLocacao.Controls.Add(numValorTotal);
            grbDadosLocacao.Controls.Add(txtStatus);
            grbDadosLocacao.Controls.Add(dateDataLocacao);
            grbDadosLocacao.Controls.Add(label7);
            grbDadosLocacao.Controls.Add(lblValorTotal);
            grbDadosLocacao.Controls.Add(lblDataLocacao);
            grbDadosLocacao.Location = new Point(18, 185);
            grbDadosLocacao.Name = "grbDadosLocacao";
            grbDadosLocacao.Size = new Size(908, 192);
            grbDadosLocacao.TabIndex = 8;
            grbDadosLocacao.TabStop = false;
            grbDadosLocacao.Text = "Dados da Locação";
            // 
            // numValorTotal
            // 
            numValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numValorTotal.Location = new Point(451, 114);
            numValorTotal.Name = "numValorTotal";
            numValorTotal.ReadOnly = true;
            numValorTotal.Size = new Size(415, 34);
            numValorTotal.TabIndex = 7;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStatus.Location = new Point(451, 48);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(415, 34);
            txtStatus.TabIndex = 6;
            // 
            // dateDataLocacao
            // 
            dateDataLocacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateDataLocacao.Format = DateTimePickerFormat.Short;
            dateDataLocacao.Location = new Point(7, 46);
            dateDataLocacao.Name = "dateDataLocacao";
            dateDataLocacao.Size = new Size(430, 34);
            dateDataLocacao.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(451, 23);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 4;
            label7.Text = "Status";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Location = new Point(451, 91);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(80, 20);
            lblValorTotal.TabIndex = 3;
            lblValorTotal.Text = "Valor Total";
            // 
            // lblDataLocacao
            // 
            lblDataLocacao.AutoSize = true;
            lblDataLocacao.Location = new Point(6, 23);
            lblDataLocacao.Name = "lblDataLocacao";
            lblDataLocacao.Size = new Size(121, 20);
            lblDataLocacao.TabIndex = 2;
            lblDataLocacao.Text = "Data da Locação";
            // 
            // dgvItensLocacao
            // 
            dgvItensLocacao.BackgroundColor = Color.MediumTurquoise;
            dgvItensLocacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensLocacao.Location = new Point(20, 383);
            dgvItensLocacao.Name = "dgvItensLocacao";
            dgvItensLocacao.RowHeadersWidth = 51;
            dgvItensLocacao.RowTemplate.Height = 29;
            dgvItensLocacao.Size = new Size(908, 171);
            dgvItensLocacao.TabIndex = 2;
            dgvItensLocacao.CellDoubleClick += dgvItensLocacao_CellDoubleClick;
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
            Controls.Add(grbDadosLocacao);
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
            grbDadosLocacao.ResumeLayout(false);
            grbDadosLocacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numValorTotal).EndInit();
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
        private GroupBox grbDadosLocacao;
        private Label label7;
        private Label lblValorTotal;
        private Label lblDataLocacao;
        private TextBox txtStatus;
        private DateTimePicker dateDataLocacao;
        private NumericUpDown numValorTotal;
    }
}