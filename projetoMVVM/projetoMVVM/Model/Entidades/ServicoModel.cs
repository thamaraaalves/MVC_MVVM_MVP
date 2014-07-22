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

namespace projetoMVC.Models
{
    [Table("Servico")]
    public class Servico
    {
        //id servico
        [Key]
        [Display(Name = "ID")]
        public int nIdServico { get; set; }

        //descricao
        [Required]
        [Display(Name = "Descrição")]
        public string sDescricao { get; set; }

        //tempo duracao
        [Required]
        [Display(Name = "Tempo duração (minutos)")]
        public int nTempo { get; set; }

        //preco
        [Required]
        [Display(Name = "Preço")]           
        [DataType(DataType.Currency)]        
        public double nPreco { get; set; }
                             
        //pessoa - funcionário
        [Required]
        [Display(Name = "Pessoa")]
        public string sCpf { get; set; }
        [ForeignKey("sCpf")]
        public virtual Pessoa Pessoa { get; set; }
                
    }
}