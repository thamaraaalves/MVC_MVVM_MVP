using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace projetoMVVM.Models.Entidades
{
    public class BDContext : DbContext
    {
        public BDContext()
            : base("BDContext") { }

        public DbSet<Pesso> PessoaModel { get; set; }
        public DbSet<Servico> ServicoModel { get; set; }      
        public DbSet<Usuario> Usuarios { get; set; }       
    }
}