using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FinanzasAPIRest.Models
{
    [Table("Tasa")]
    public class Tasa
    {
        [Key]
        public int IdTasa { get; set; }
        [Required(ErrorMessage ="El campo nombre de tasa es requerido")]
        [StringLength(200)]
        public string NombreTasa { get; set; }
    
    }
}
