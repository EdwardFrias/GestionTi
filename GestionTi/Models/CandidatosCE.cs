using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionTi.Models
{
    public class CandidatosCE
    {
        [Required]
        [Display(Name = "Cedula")]
        [StringLength(maximumLength:11)]
        public string Candidatos_Cedula { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Candidatos_Nombre { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public string Candidatos_Apellido { get; set; }
        [Required]
        [Display(Name = "Fecha")]
        public DateTime Candidatos_FechaNacimiento { get; set; }
    }
    [MetadataType(typeof(CandidatosCE))]
    public partial class Candidatos
    {

    }
    

   
}