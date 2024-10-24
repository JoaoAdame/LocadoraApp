using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraApp.Classes;
using LocadoraApp.Contexto;

namespace LocadoraApp.Componentes
{
    public partial class MidiasComboBox : ComboBox
    {
        public MidiasComboBox()
        {
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.BackColor = Color.RebeccaPurple;
            this.ForeColor = Color.White;

        }

        public void CarregarMidias()
        {
            using (var contexto = new LocadoraAppDbContext())
            {
                //define os dados que o combobox irá usar
                this.DataSource = contexto.Midias
                    .OrderBy(m => m.Titulo)
                    .ToList();

                //define qual campo será usado como texto
                this.DisplayMember = "Titulo";

                //definir qual o campo será o valor real
                this.ValueMember = "MidiaId";
            }
        }

        public Midia? MidiaSelecionada
        {
            get
            {
                return this.SelectedItem as Midia;
            }
        }

        public int? MidiaIdSelecionada
        {
            get
            {
                return this.SelectedItem as int?;
            }
        }
    }
}
