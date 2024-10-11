using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LocadoraApp.Classes;
using Pomelo.EntityFrameworkCore.MySql;

namespace LocadoraApp.Contexto
{
    internal class LocadoraAppDbContext : DbContext
    {
        public DbSet<Midia> Midias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexao = "Server=localhost;Database=locadoraapp;User=root;Password=12345;";
            
            optionsBuilder.UseMySql(conexao,
                ServerVersion.AutoDetect(conexao));
        }
    }
}
