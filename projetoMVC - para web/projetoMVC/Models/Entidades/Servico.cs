using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Tempo duração")]
        public int nTempo { get; set; }

        //preco
        [Required]
        [Display(Name = "Preço")]
        public decimal nPreco { get; set; }

        //pessoa - funcionário
        [Required]
        [Display(Name = "Pessoa")]
        public string sCpf { get; set; }
        [ForeignKey("sCpf")]
        public virtual Pessoa Pessoa { get; set; }
                
    }
}