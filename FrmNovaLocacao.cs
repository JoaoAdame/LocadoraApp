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
    public partial class FrmNovaLocacao : Form
    {

        private Locacao LocacaoAtual;

        public FrmNovaLocacao()
        {
            InitializeComponent();
        }

        private void FrmNovaLocacao_Load(object sender, EventArgs e)
        {
            //Carrega os dados da mídia
            cmbMidias.CarregarMidias();

            //Instância da locação
            LocacaoAtual = new Locacao();

            //Adiciona os itens da Locação no Data Grid View
            dgvItensLocacao.DataSource = LocacaoAtual.Itens;

            CarregaDadosItensLocacao();
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidaDadosDoItem())
            {
                return;
            }

            Item NovoItem = new Item()
            {
                PrazoDevolucao = (int)numPrazoDevolução.Value,
                Valor = numValor.Value,
                Quantidade = (int)numQuantidade.Value,
                Status = "Pendente",
                MidiaId = cmbMidias.MidiaSelecionada.MidiaId,
                Midia = cmbMidias.MidiaSelecionada
            };

            //Adiciona o novo item dentro da locação
            LocacaoAtual.Itens.Add(NovoItem);

            //Limpa os campos do item
            LimpaCampoItens();

            MessageBox.Show("Item adicionado com sucesso");
        }

        private void LimpaCampoItens()
        {
            //Limpa campo do valor
            numValor.Value = 0;
            //limpa campo da midia
            cmbMidias.SelectedIndex = 0;
            //Limpa campo de Prazo
            numPrazoDevolução.Value = 0;
            //Limpa campo de quantidade
            numQuantidade.Value = 1;
        }

        private bool ValidaDadosDoItem()
        {
            if (cmbMidias.MidiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma mídia");
                cmbMidias.Focus();
                return false;
            }

            if (numQuantidade.Value < 1)
            {
                MessageBox.Show("A quantidade não pode ser menor que um!");
                numQuantidade.Focus();
                return false;
            }

            if (numPrazoDevolução.Value < 1)
            {
                MessageBox.Show("O prazo não pode ser menor que um dia!");
                numPrazoDevolução.Focus();
                return false;
            }

            if (numValor.Value == 0)
            {
                MessageBox.Show("O valor não pode ser zero!");
                numValor.Focus();
                return false;
            }

            return true;
        }
        public void CarregaDadosItensLocacao()
        {
            // Carregando os dados para DGV
            dgvItensLocacao.DataSource = LocacaoAtual.Itens;

            // Personalizar o DGV
            dgvItensLocacao.Columns["ItemID"].HeaderText = "Código";
            dgvItensLocacao.Columns["MidiaTitulo"].HeaderText = "Título";
            dgvItensLocacao.Columns["PrazoDevolucao"].HeaderText = "Devolução";
            dgvItensLocacao.Columns["Valor"].HeaderText = "Valor";
            dgvItensLocacao.Columns["Quantidade"].HeaderText = "Quantidade";
            dgvItensLocacao.Columns["ValorTotal"].HeaderText = "Total";

            //Ordena os campos
            dgvItensLocacao.Columns["ItemID"].DisplayIndex = 0;
            dgvItensLocacao.Columns["MidiaTitulo"].DisplayIndex = 1;
            dgvItensLocacao.Columns["PrazoDevolucao"].DisplayIndex = 2;
            dgvItensLocacao.Columns["Valor"].DisplayIndex = 3;
            dgvItensLocacao.Columns["Quantidade"].DisplayIndex = 4;
            dgvItensLocacao.Columns["ValorTotal"].DisplayIndex = 5;

            dgvItensLocacao.Columns["MidiaID"].Visible = false;
            dgvItensLocacao.Columns["Midia"].Visible = false;
            dgvItensLocacao.Columns["Locacao"].Visible = false;
            dgvItensLocacao.Columns["LocacaoId"].Visible = false;
            dgvItensLocacao.Columns["Status"].Visible = false;

            // Redimensiona as colunas
            dgvItensLocacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnFecharlocacao_Click(object sender, EventArgs e)
        {
            if (!ValidaDadosLocacao())
            {
                return;
            }
        }

        private bool ValidaDadosLocacao()
        {
            //Verifica se tem nome
            if (txtNomeCliente == null)
            {
                MessageBox.Show("Nome é obrigatório!");
                txtNomeCliente.Focus();
                return false;
            }
            
            //Verifica se tem CPF
            if (mtxtCpf == null)
            {
                MessageBox.Show("CPF obrigatório!");
                mtxtCpf.Focus();
                return false;
            }
            
            //Verifica se tem telefone valido
            if (mtxtTelefone == null)
            {
                MessageBox.Show("Número de telefone obrigatório!");
                mtxtTelefone.Focus();
                return false;
            }


            return true;
        }
    }
}
