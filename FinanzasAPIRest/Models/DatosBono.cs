using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FinanzasAPIRest.Models
{
    [Table("DatosBono")]
    public class DatosBono
    {

        [Required]
        [Key]
        public int IdOperacion { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal ValorNominal { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal ValorComercial { get; set; }
        
        [Required]
        public int Plazo { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal TasaCupon { get; set; }


        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal TasaInteresMercado { get; set; }




        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal PrimaRedencion { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal Estructuracion { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal Colocacion { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal Flotacion { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal Cavali { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal GastosAdicionales { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal InflacionAnual { get; set; }

        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        
        public int IdFrecuencia { get; set; }
        [ForeignKey("IdFrecuencia")]
        public FrecuenciaPago Frecuencia { get; set; }
    }
}
