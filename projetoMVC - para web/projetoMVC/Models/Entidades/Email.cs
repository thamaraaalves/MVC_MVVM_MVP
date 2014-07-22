using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace projetoMVC.Models
{
    [Table("Email")]
    public class Email
    {
        // id email
        [Key]
        [Display(Name = "ID")]
        public int nIdEmail { get; set; }

        //cpf
        [Required(ErrorMessage="A pessoa é obrigatória")]
        [Display(Name = "CPF")]
        public string sCpf { get; set; }
        [ForeignKey("sCpf")]
        public virtual Pessoa Pessoa { get; set; }

        //email
        [Required(ErrorMessage = "O email é obrigatório.")]
        [Display(Name = "Email")]
        public string sEmail { get; set; }

        //principal
        [Required]
        [Display(Name = "Principal")]
        public int nPrincipal { get; set; }
    }
}