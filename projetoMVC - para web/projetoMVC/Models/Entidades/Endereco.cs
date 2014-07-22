using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace projetoMVC.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        //id endereco
        [Key]
        [Display(Name = "ID")]
        public int nIdEndereco { get; set; }

        //cpf
        [Required]
        [Display(Name= "CPF")]
        public string sCpf { get; set; }
        [ForeignKey("sCpf")]        
        public virtual Pessoa Pessoa { get; set; }
        
        //rua
        [Required]
        [Display(Name = "Rua")]
        public string sRua { get; set; }

        //nro
        [Required]
        [Display(Name = "Nro")]
        public int nNro { get; set; }

        //bairro
        [Required]
        [Display(Name = "Bairro")]
        public string sBairro { get; set; }

        //CEP
        [Required]
        [Display(Name = "CEP")]
        public string sCep { get; set; }

        //cidade
        [Required]
        [Display(Name = "Cidade")]
        public string sCidade { get; set; }

        //estado
        [Required]
        [Display(Name = "Estado")]
        public string sEstado { get; set; }

        //principal
        [Required]
        [Display(Name = "Principal")]
        [Range(0,1)]
        public int nPrincipal { get; set; }

    }
}