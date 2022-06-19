using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FinanzasAPIRest.Models
{
    [Table("Moneda")]
    public class Moneda
    {
        [Key]
        public int IdMoneda { get; set; }
        [Required(ErrorMessage ="El campo nombre de moneda es requerido")]
        [StringLength(200)]
        public string NombreMoneda { get; set; }
    }
}
