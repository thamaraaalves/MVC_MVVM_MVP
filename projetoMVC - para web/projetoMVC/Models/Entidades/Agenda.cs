using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace projetoMVC.Models
{
    [Table("Agenda")]
    public class Agenda
    {
        //id agenda
        [Key]
        public int nIdAgenda { get; set; }

        //data e hora
        [Required(ErrorMessage = "A data é obrigatória.")]
        [Display(Name="Data")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime dData{ get; set; }
        
        //hora
        //data e hora
        [Required(ErrorMessage = "O horário é obrigatório.")]
        [Display(Name = "Hora.")]
        [DisplayFormat(DataFormatString = "{0:t}")]
        public DateTime dHora { get; set; }

        //execucao
       /* [Required(ErrorMessage = "")]
        public int nIdExecucao { get; set; }
        [ForeignKey("nIdExecucao")]
        public virtual Execucao Execucao { get; set; }*/

        //id serviço
        [Required]
        [Display(Name = "ID")]
        public int nIdServico { get; set; }
        [ForeignKey("nIdServico")]
        public virtual Servico Servico { get; set; }
           
        //status                
        public int nStatus { get; set; }
    }
}