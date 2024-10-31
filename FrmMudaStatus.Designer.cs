namespace LocadoraApp
{
    partial class FrmMudaStatus
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
            txctMidiaAlocada = new TextBox();
            txtStatusAtual = new TextBox();
            label3 = new Label();
            datePrazoDevolucao = new DateTimePicker();
            grbAlteracaoStatus = new GroupBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            cmbNovoStatus = new ComboBox();
            label4 = new Label();
            pnlPrazoDevolucao = new Panel();
            grbAlteracaoStatus.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Mídia Alocada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Status Atual";
            // 
            // txctMidiaAlocada
            // 
            txctMidiaAlocada.Location = new Point(12, 32);
            txctMidiaAlocada.Name = "txctMidiaAlocada";
            txctMidiaAlocada.ReadOnly = true;
            txctMidiaAlocada.Size = new Size(522, 27);
            txctMidiaAlocada.TabIndex = 2;
            // 
            // txtStatusAtual
            // 
            txtStatusAtual.Location = new Point(12, 113);
            txtStatusAtual.Name = "txtStatusAtual";
            txtStatusAtual.ReadOnly = true;
            txtStatusAtual.Size = new Size(249, 27);
            txtStatusAtual.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 90);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 4;
            label3.Text = "Prazo de Devolução";
            // 
            // datePrazoDevolucao
            // 
            datePrazoDevolucao.Format = DateTimePickerFormat.Short;
            datePrazoDevolucao.Location = new Point(277, 113);
            datePrazoDevolucao.Name = "datePrazoDevolucao";
            datePrazoDevolucao.Size = new Size(257, 27);
            datePrazoDevolucao.TabIndex = 5;
            // 
            // grbAlteracaoStatus
            // 
            grbAlteracaoStatus.BackColor = Color.MediumTurquoise;
            grbAlteracaoStatus.Controls.Add(btnSalvar);
            grbAlteracaoStatus.Controls.Add(btnCancelar);
            grbAlteracaoStatus.Controls.Add(cmbNovoStatus);
            grbAlteracaoStatus.Controls.Add(label4);
            grbAlteracaoStatus.Location = new Point(1, 161);
            grbAlteracaoStatus.Name = "grbAlteracaoStatus";
            grbAlteracaoStatus.Size = new Size(546, 229);
            grbAlteracaoStatus.TabIndex = 6;
            grbAlteracaoStatus.TabStop = false;
            grbAlteracaoStatus.Text = "Alteração de status";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.Location = new Point(446, 194);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(6, 194);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // cmbNovoStatus
            // 
            cmbNovoStatus.FormattingEnabled = true;
            cmbNovoStatus.Items.AddRange(new object[] { "Pendente", "Atrasado", "Devolvido" });
            cmbNovoStatus.Location = new Point(6, 46);
            cmbNovoStatus.Name = "cmbNovoStatus";
            cmbNovoStatus.Size = new Size(517, 28);
            cmbNovoStatus.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(375, 20);
            label4.TabIndex = 7;
            label4.Text = "Selecione abaixo o novo status para o item da locação.";
            // 
            // pnlPrazoDevolucao
            // 
            pnlPrazoDevolucao.Location = new Point(277, 113);
            pnlPrazoDevolucao.Name = "pnlPrazoDevolucao";
            pnlPrazoDevolucao.Size = new Size(257, 27);
            pnlPrazoDevolucao.TabIndex = 7;
            // 
            // FrmMudaStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 390);
            Controls.Add(grbAlteracaoStatus);
            Controls.Add(datePrazoDevolucao);
            Controls.Add(label3);
            Controls.Add(txtStatusAtual);
            Controls.Add(txctMidiaAlocada);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlPrazoDevolucao);
            Name = "FrmMudaStatus";
            Text = "Mudar o status do item";
            grbAlteracaoStatus.ResumeLayout(false);
            grbAlteracaoStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txctMidiaAlocada;
        private TextBox txtStatusAtual;
        private Label label3;
        private DateTimePicker datePrazoDevolucao;
        private GroupBox grbAlteracaoStatus;
        private Button btnSalvar;
        private Button btnCancelar;
        private ComboBox cmbNovoStatus;
        private Label label4;
        private Panel pnlPrazoDevolucao;
    }
}