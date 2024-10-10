﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LocadoraApp.Classes;

namespace LocadoraApp.Contexto
{
    internal class LocadoraAppDbContext : DbContext
    {
        public DbSet<Midia> Midias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=locadoraapp;User=root;Password=12345;");
            
        }
    }
}
