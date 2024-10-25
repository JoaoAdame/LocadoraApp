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
            ((System.ComponentModel.ISupportInitialize)dgvListaLocacao).BeginInit();
            SuspendLayout();
            // 
            // dgvListaLocacao
            // 
            dgvListaLocacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaLocacao.Location = new Point(12, 12);
            dgvListaLocacao.Name = "dgvListaLocacao";
            dgvListaLocacao.RowHeadersWidth = 51;
            dgvListaLocacao.RowTemplate.Height = 29;
            dgvListaLocacao.Size = new Size(776, 426);
            dgvListaLocacao.TabIndex = 0;
            // 
            // FrmListaLocacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListaLocacao);
            Name = "FrmListaLocacao";
            Text = "Lista da Locação";
            Load += FrmListaLocacoes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaLocacao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaLocacao;
    }
}