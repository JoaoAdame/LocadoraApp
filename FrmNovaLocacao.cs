using LocadoraApp.Classes;
using LocadoraApp.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        public FrmNovaLocacao(int LocacaoId)
        {
            InitializeComponent();

            //Coloca os campos em apenas leitura
            CamposApenasLeitura(true);

            //Busca a Locação no banco de dados
            LocacaoAtual = GetLocacaoById(LocacaoId);

            //Carrega os dados para os campos
            CarregaDadosLocacaoCampos();

        }

        private void CarregaDadosLocacaoCampos()
        {
            txtNomeCliente.Text = LocacaoAtual.Nome;
            mtxtCpf.Text = LocacaoAtual.Cpf;
            mtxtTelefone.Text = LocacaoAtual.Telefone;

            CarregaDadosItensLocacao();
        }

        private Locacao GetLocacaoById(int id)
        {
            using (var contexto = new LocadoraAppDbContext())
            {
                return contexto.Locacoes.Include(l => l.Itens)
                    .ThenInclude(i => i.Midia)
                    .FirstOrDefault(l => l.LocacaoId == id);
            }
        }

        private void CamposApenasLeitura(bool status)
        {
            //Marca a propriedade ReadOnly como true nos campos de texto
            txtNomeCliente.ReadOnly = status;
            mtxtCpf.ReadOnly = status;
            mtxtTelefone.ReadOnly = status;

            //Oculta o formulário de novos itens
            grbNovoItem.Visible = !status;

            // Mostra o groupBox de dados
            grbDadosLocacao.Visible = status;

            //Oculta o botão de fechar locação
            btnFecharlocacao.Visible = !status;

            //Oculta o botão de cancelar
            btnCacncelar.Visible = !status;

            //Desabilita o DataGridView dos itens
            dgvItensLocacao.ReadOnly = status;


        }

        private void FrmNovaLocacao_Load(object sender, EventArgs e)
        {

            if (LocacaoAtual == null)
            {
                //Carrega os dados da mídia
                cmbMidias.CarregarMidias();

                //Instância da locação
                LocacaoAtual = new Locacao();

                //Adiciona os itens da Locação no Data Grid View
                dgvItensLocacao.DataSource = LocacaoAtual.Itens;

                CarregaDadosItensLocacao();
            }
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
            dgvItensLocacao.Columns["PrazoDevolucao"].HeaderText = "Prazo";
            dgvItensLocacao.Columns["DataDevolucao"].HeaderText = " Data Devolução";
            dgvItensLocacao.Columns["Valor"].HeaderText = "Valor";
            dgvItensLocacao.Columns["Quantidade"].HeaderText = "Quantidade";
            dgvItensLocacao.Columns["ValorTotal"].HeaderText = "Total";

            //Formata os campos de valor para moeda
            dgvItensLocacao.Columns["Valor"].DefaultCellStyle.Format = "C";
            dgvItensLocacao.Columns["ValorTotal"].DefaultCellStyle.Format = "C";

            //Ordena os campos
            dgvItensLocacao.Columns["ItemID"].DisplayIndex = 0;
            dgvItensLocacao.Columns["MidiaTitulo"].DisplayIndex = 1;
            dgvItensLocacao.Columns["PrazoDevolucao"].DisplayIndex = 2;
            dgvItensLocacao.Columns["DataDevolucao"].DisplayIndex = 3;
            dgvItensLocacao.Columns["Valor"].DisplayIndex = 4;
            dgvItensLocacao.Columns["Quantidade"].DisplayIndex = 5;
            dgvItensLocacao.Columns["ValorTotal"].DisplayIndex = 6;

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

            //Adiciona os dados da locação
            LocacaoAtual.Cpf = mtxtCpf.Text;
            LocacaoAtual.Nome = txtNomeCliente.Text;
            LocacaoAtual.Telefone = mtxtTelefone.Text;
            LocacaoAtual.Status = "Fechado";
            LocacaoAtual.Data = DateTime.Now;

            //abre o contexto para salvar a locação
            using (var contexto = new LocadoraAppDbContext())
            {
                //Adiciona todas as midias ao contexto para não serem inseridas novamente
                foreach (var item in LocacaoAtual.Itens)
                {
                    contexto.Midias.Attach(item.Midia);
                    LocacaoAtual.ValorTotal += item.ValorTotal; //Soma o valor total do item na locãção
                }

                contexto.Locacoes.Add(LocacaoAtual);
                int resultado = contexto.SaveChanges();

                if (resultado > 0)
                {
                    var opcao = MessageBox.Show(
                        "Locação criada com sucesso! Deseja criar outra?",
                        "Locação criada",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1
                        );

                    if (opcao == DialogResult.Yes)
                    {
                        //limpa o Formulário
                        LimpaCamposDados();


                    }
                    else
                    {
                        //Fecha o formulário
                        this.Close();
                    }
                }
            }
        }

        private void LimpaCamposDados()
        {
            txtNomeCliente.Clear();
            mtxtCpf.Clear();
            mtxtTelefone.Clear();
            CarregaDadosItensLocacao();

            LocacaoAtual = new Locacao();
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
