using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string Correo { get; set; }
        [Required(ErrorMessage = "El campo contraseña es requerido")]
        [StringLength(200)]
        public string Password { get; set; }
        [Required(ErrorMessage = "El campo nombre es requerido")]
        [StringLength(100)]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El campo apellido es requerido")]
        [StringLength(150)]
        public string Apellido { get; set; }

    }
}
