namespace LocadoraApp
{
    partial class FrmListaLocacao
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
            dgvListaLocacao = new DataGridView();
            label1 = new Label();
            cmbStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListaLocacao).BeginInit();
            SuspendLayout();
            // 
            // dgvListaLocacao
            // 
            dgvListaLocacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaLocacao.Location = new Point(12, 66);
            dgvListaLocacao.Name = "dgvListaLocacao";
            dgvListaLocacao.RowHeadersWidth = 51;
            dgvListaLocacao.RowTemplate.Height = 29;
            dgvListaLocacao.Size = new Size(776, 372);
            dgvListaLocacao.TabIndex = 0;
            dgvListaLocacao.CellDoubleClick += dgvListaLocacao_CellDoubleClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Fechado", "Concluído" });
            cmbStatus.Location = new Point(12, 32);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(320, 28);
            cmbStatus.TabIndex = 2;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // FrmListaLocacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbStatus);
            Controls.Add(label1);
            Controls.Add(dgvListaLocacao);
            Name = "FrmListaLocacao";
            Text = "Lista da Locação";
            Load += FrmListaLocacoes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaLocacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListaLocacao;
        private Label label1;
        private ComboBox cmbStatus;
    }
}