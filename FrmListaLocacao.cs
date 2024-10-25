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

        private List<Midia> GetMidias()
        {
            using (var contexto = new LocadoraAppDbContext())
            {
                // Retorna todas as midias do banco de dados
                return contexto.Midias.ToList();
            }
        }

        private void FrmListaMidias_Load(object sender, EventArgs e)
        {
            CarregaDadosDGV();
        }

        private void CarregaDadosDGV()
        {
            // Carregando os dados para DGV
            dgvListaLocacao.DataSource = GetMidias();

            // Personalizar o DGV
            dgvListaLocacao.Columns["ItemID"].HeaderText = "Código";
            dgvListaLocacao.Columns["MidiaTitulo"].HeaderText = "Título";
            dgvListaLocacao.Columns["PrazoDevolucao"].HeaderText = "Devolução";
            dgvListaLocacao.Columns["Valor"].HeaderText = "Valor";
            dgvListaLocacao.Columns["Quantidade"].HeaderText = "Quantidade";
            dgvListaLocacao.Columns["ValorTotal"].HeaderText = "Total";

            dgvListaLocacao.Columns["ItemID"].DisplayIndex = 0;
            dgvListaLocacao.Columns["MidiaTitulo"].DisplayIndex = 1;
            dgvListaLocacao.Columns["PrazoDevolucao"].DisplayIndex = 2;
            dgvListaLocacao.Columns["Valor"].DisplayIndex = 3;
            dgvListaLocacao.Columns["Quantidade"].DisplayIndex = 4;
            dgvListaLocacao.Columns["ValorTotal"].DisplayIndex = 5;

            dgvListaLocacao.Columns["MidiaID"].Visible = false;
            dgvListaLocacao.Columns["Midia"].Visible = false;
            dgvListaLocacao.Columns["Locacao"].Visible = false;
            dgvListaLocacao.Columns["LocacaoId"].Visible = false;
            dgvListaLocacao.Columns["Status"].Visible = false;


            // Redimensiona as colunas
            dgvListaLocacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvListaMidias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar se clicou em uma linha valida
            if (e.RowIndex >= 0)
            {
                // Pega a linha selecionada pelo usuário
                DataGridViewRow linha = dgvListaLocacao.Rows[e.RowIndex];

                // Pega o campo de ID da linha clicada
                int MidiaId = (int)linha.Cells["MidiaId"].Value;

                FrmNovaMidia frmNovaMidia = new FrmNovaMidia(MidiaId);
                frmNovaMidia.ShowDialog();

                CarregaDadosDGV();
            }
        }

        private void FrmListaLocacoes_Load(object sender, EventArgs e)
        {
            
        }
    }
}
