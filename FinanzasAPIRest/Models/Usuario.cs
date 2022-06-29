using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace FinanzasAPIRest.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required(ErrorMessage ="El campo correo es requerido")]
        [StringLength(200)]
        [EmailAddress]
        [Column]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El campo contraseña es requerido")]
        [StringLength(200)]
        [Column]
        public string Password { get; set; }
        
        
        [StringLength(100)]
        [Column]
        public string Nombres { get; set; }        
        
        [StringLength(150)]
        [Column]
        public string Apellido { get; set; }

    }
}
