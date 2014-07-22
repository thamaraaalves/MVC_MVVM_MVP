using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace projetoMVC.Models
{
    public class Pessoa
    {
        //cpf
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [KeyAttribute()]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string sCPF { get; set; }

        //nome
        [Display(Name = "Nome Completo")]        
        public string sNome { get; set; }

        //data nascimento
        [Display(Name = "Data Nasc.")]
        [Required(ErrorMessage="A Data de Nasc. é obrigatória.")]
        [DisplayFormat(DataFormatString = "{0:DD/MM/yyyy}")]
        public DateTime dDataNasci { get; set; }

        //tipo
        [Display(Name = "Tipo")]        
        [Range(0,2)]
        public int nTipo { get; set; }

        //email
        [Required(ErrorMessage = "O email é obrigatório.")]
        [Display(Name = "Email")]
        public string sEmail { get; set; }

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
    }
}