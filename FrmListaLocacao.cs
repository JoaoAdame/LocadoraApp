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
            using (var contexto = new LocadoraAppDbContext())
            {
                // Retorna todas as midias do banco de dados
                return contexto.Locacoes.ToList();
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

            dgvListaLocacao.Columns["LocacaoId"].DisplayIndex = 0;
            dgvListaLocacao.Columns["Nome"].DisplayIndex = 1;
            dgvListaLocacao.Columns["Data"].DisplayIndex = 2;
            dgvListaLocacao.Columns["Status"].DisplayIndex = 3 ;
            dgvListaLocacao.Columns["ValorTotal"].DisplayIndex = 4;

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
    }
}
