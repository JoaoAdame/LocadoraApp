﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraApp.Classes
{
    public class Locacao
    {
            public int LocacaoId { get; set; }
            public string Nome { get; set; }
            public string Cpf { get; set; }
            public string Status { get; set; }
            public string Telefone { get; set; }
            public DateTime Data { get; set; }
            public decimal ValorTotal { get; set; }

            // Relação com os itens
            public BindingList<Item> Itens { get; set; }

        public Locacao()
        {
            Itens = new BindingList<Item>();
        }
    }
}
