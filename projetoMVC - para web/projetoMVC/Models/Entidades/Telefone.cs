using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace projetoMVC.Models
{
    [Table("Telefone")]
    public class Telefone
    {
        //id telefone
        [Key]
        [Display(Name = "ID")]
        public int nIdTelefone { get; set; }

        //cpf
        [Required]
        [Display(Name = "CPF")]
        public string sCpf { get; set; }
        [ForeignKey("sCpf")]
        public virtual Pessoa Pessoa { get; set; }

        //DDD
        [Required]
        [Display(Name = "DDD")]
        public int nDDD { get; set; }

        //telefone
        [Required]
        [Display(Name = "Telefone")]
        public int sTel { get; set; }

        //celular
        [Required]
        [Display(Name = "Celular")]
        public int sCel { get; set; } 

        //principal
        [Required]
        [Display(Name = "Principal")]
        [Range(0,1)]
        public int nPrincipal { get; set; }
    }
}