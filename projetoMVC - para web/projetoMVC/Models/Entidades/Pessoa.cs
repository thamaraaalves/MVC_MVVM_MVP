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
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime dDataNasci { get; set; }

        //tipo
        [Display(Name = "Tipo")]        
        [Range(0,2)]
        public int nTipo { get; set; }     
    }
}