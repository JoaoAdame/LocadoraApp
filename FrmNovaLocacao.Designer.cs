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
            midiasComboBox1 = new Componentes.MidiasComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            groupBox2.Controls.Add(midiasComboBox1);
            groupBox2.Location = new Point(18, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(908, 237);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Itens da Locação";
            // 
            // midiasComboBox1
            // 
            midiasComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            midiasComboBox1.FormattingEnabled = true;
            midiasComboBox1.Location = new Point(6, 38);
            midiasComboBox1.Name = "midiasComboBox1";
            midiasComboBox1.Size = new Size(896, 28);
            midiasComboBox1.TabIndex = 0;
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
    }
}