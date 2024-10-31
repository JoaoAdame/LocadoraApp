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
    public partial class FrmMudaStatus : Form
    {
        Item ItemAtual;
        public FrmMudaStatus(Item item)
        {
            InitializeComponent();
            ItemAtual = item;
            CarregaDadosItemLocacao();
        }

        public void CarregaDadosItemLocacao()
        {
            txtStatusAtual.Text = ItemAtual.Status;
            txctMidiaAlocada.Text = ItemAtual.Midia.Titulo;
            datePrazoDevolucao.Value = ItemAtual.DataDevolucao;

            if (ItemAtual.DataDevolucao < DateTime.Now)
            {
                pnlPrazoDevolucao.BackColor = Color.Red;
            }
            else
            {
                pnlPrazoDevolucao.BackColor = Color.Green;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbNovoStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um novo status!");
                return;
            }
            using (var contexto = new LocadoraAppDbContext())
            {
                var ItemAlteracao = contexto.Itens.Find(ItemAtual.ItemId);

                ItemAlteracao.Status = cmbNovoStatus.SelectedItem.ToString();

                contexto.SaveChanges();
            }
        }
    }
}
