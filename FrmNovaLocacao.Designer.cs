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
            groupBox2 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnAdicionar = new Button();
            midiasComboBox1 = new Componentes.MidiasComboBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            mtxtCpf.Location = new Point(0, 108);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown3);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnAdicionar);
            groupBox2.Controls.Add(midiasComboBox1);
            groupBox2.Location = new Point(18, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(908, 237);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Itens da Locação";
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
            // 
            // midiasComboBox1
            // 
            midiasComboBox1.BackColor = Color.RebeccaPurple;
            midiasComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            midiasComboBox1.ForeColor = Color.White;
            midiasComboBox1.FormattingEnabled = true;
            midiasComboBox1.Location = new Point(6, 38);
            midiasComboBox1.Name = "midiasComboBox1";
            midiasComboBox1.Size = new Size(896, 28);
            midiasComboBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(7, 114);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(245, 27);
            numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(268, 114);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(218, 27);
            numericUpDown2.TabIndex = 6;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(521, 114);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(381, 27);
            numericUpDown3.TabIndex = 7;
            // 
            // FrmNovaLocacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 557);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmNovaLocacao";
            Text = "Nova Locação";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
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
        private GroupBox groupBox2;
        private Componentes.MidiasComboBox midiasComboBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnAdicionar;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
    }
}