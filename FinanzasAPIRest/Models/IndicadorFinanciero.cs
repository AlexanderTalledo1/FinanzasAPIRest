using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FinanzasAPIRest.Models
{
    [Table("IndicadorFinanciero")]
    public class IndicadorFinanciero
    {
        [Key]
        public int IdOperacion { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Precio { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Van { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Tir { get; set; }        
        public int IdTasa { get; set; }
        [ForeignKey("IdTasa")]
        public Tasa Tasa { get; set; }
        public int IdMoneda { get; set; }
        [ForeignKey("IdMoneda")]
        public Moneda Moneda { get; set; }
        public int IdUnidad { get; set; }
        [ForeignKey("IdMoneda")]
        public UnidadTiempo Tiempo { get; set; }
        

    }
}
