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
        public FrmNovaLocacao()
        {
            InitializeComponent();
        }

        private void FrmNovaLocacao_Load(object sender, EventArgs e)
        {
            cmbMidias.CarregarMidias();
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (! ValidaDadosDoItem())
            {
                return;
            }

            MessageBox.Show("Item adicionado com sucesso");
        }

        private bool ValidaDadosDoItem()
        {
            if (cmbMidias.MidiaIdSelecionada == null)
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

    }
}
