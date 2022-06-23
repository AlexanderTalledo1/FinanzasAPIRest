using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FinanzasAPIRest.Models
{
    [Table("FrecuenciaPago")]
    public class FrecuenciaPago
    {
        [Key]
        public int IdFrecuencia { get; set; }
        [Required(ErrorMessage ="El campo nombre frecuencia es requerido")]
        [StringLength(200)]        
        public string NombreUnidad { get; set; }        
    }
}
