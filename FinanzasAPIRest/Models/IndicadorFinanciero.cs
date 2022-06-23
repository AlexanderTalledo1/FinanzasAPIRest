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
        public int IdIndicador { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal TIR_Emisor { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal TCEA_Emisor { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal TIR_Escudo { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal TCEA_Escudo { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal TIR_Bonista { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal TREA_Bonista { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal PrecioBono { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public decimal VAN { get; set; }

        public int IdOperacion { get; set; }
        [ForeignKey("IdOperacion")]       
        public DatosBono Bono { get; set; }



    }
}
