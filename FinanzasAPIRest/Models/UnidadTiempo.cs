using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FinanzasAPIRest.Models
{
    [Table("UnidadTiempo")]
    public class UnidadTiempo
    {
        [Key]
        public int IdUnidad { get; set; }
        [Required(ErrorMessage ="El campo nombre unidad es requerido")]
        [StringLength(200)]        
        public string NombreUnidad { get; set; }        
    }
}
