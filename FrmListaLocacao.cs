using LocadoraApp.Classes;
using LocadoraApp.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraApp
{
    public partial class FrmListaLocacao : Form
    {
        public FrmListaLocacao()
        {
            InitializeComponent();
        }

        private List<Locacao> GetLocacao()
        {
            string StatusFiltro = cmbStatus.Text;

            using (var contexto = new LocadoraAppDbContext())
            {
                // Retorna todas as midias do banco de dados
                return contexto.Locacoes
                    .Where(l => l.Status == StatusFiltro) //Filtra pelos status selecionados
                    .ToList();
            }
        }

        private void FrmListaMidias_Load(object sender, EventArgs e)
        {
            CarregaDadosDGV();
        }

        private void CarregaDadosDGV()
        {
            // Carregando os dados para DGV
            dgvListaLocacao.DataSource = GetLocacao();

            // Personalizar o DGV
            dgvListaLocacao.Columns["LocacaoId"].HeaderText = "Código";
            dgvListaLocacao.Columns["Nome"].HeaderText = "Nome do Cliente";
            dgvListaLocacao.Columns["Data"].HeaderText = "Data do Pedido";
            dgvListaLocacao.Columns["Status"].HeaderText = "Status";
            dgvListaLocacao.Columns["ValorTotal"].HeaderText = "Total";

            //Muda a formatação do campo valor total para notação dinheiro (Currency C)
            dgvListaLocacao.Columns["ValorTotal"].DefaultCellStyle.Format = "C";

            dgvListaLocacao.Columns["Cpf"].Visible = false;
            dgvListaLocacao.Columns["Telefone"].Visible = false;


            // Redimensiona as colunas
            dgvListaLocacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvListaLocacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar se clicou em uma linha valida
            if (e.RowIndex >= 0)
            {
                // Pega a linha selecionada pelo usuário
                DataGridViewRow linha = dgvListaLocacao.Rows[e.RowIndex];

                // Pega o campo de ID da linha clicada
                int LocacaoId = (int)linha.Cells["LocacaoId"].Value;

                FrmNovaLocacao frmNovaLocacao = new FrmNovaLocacao();
                frmNovaLocacao.ShowDialog();

                CarregaDadosDGV();
            }
        }

        private void FrmListaLocacoes_Load(object sender, EventArgs e)
        {
            CarregaDadosDGV();
        }

        private void dgvListaLocacao_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Pega toda a linha que está selecionada
                DataGridViewRow linha = dgvListaLocacao.Rows[e.RowIndex];

                int LocacaoId = (int)linha.Cells["LocacaoId"].Value;

                FrmNovaLocacao frmNovaLocacao = new FrmNovaLocacao(LocacaoId);
                frmNovaLocacao.ShowDialog();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaDadosDGV();
        }
    }
}
