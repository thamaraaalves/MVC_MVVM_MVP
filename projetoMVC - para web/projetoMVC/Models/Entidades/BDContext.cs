using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace projetoMVC.Models.Entidades
{
    public class BDContext : DbContext
    {
        public BDContext()
            : base("BDContext") { }

        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }     
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }       
    }
}