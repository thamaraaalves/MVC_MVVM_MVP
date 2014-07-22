using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace projetoMVC.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Required]
        [Display(Name = "Nome de usuário")]
        [KeyAttribute()]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string sNomeUsuario { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Endereço Email")]
        public string sEmail { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} dever ter o minímo {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string sSenha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirma senha")]
        [Compare("sSenha", ErrorMessage = "A senha e confirmação de senha devem ser iguais.")]
        public string sConfirmaSenha { get; set; }

        [Required]
        [Display(Name = "Pessoa")]
        public string sCpf { get; set; }
        [ForeignKey("sCpf")]
        public virtual Pessoa Pessoa { get; set; }
    }
}