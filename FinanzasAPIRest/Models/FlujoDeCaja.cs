using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FinanzasAPIRest.Models
{
    public class FlujoDeCaja
    {
        public Usuario Usuario { get; set; }
        [ForeignKey("IdUsuario")]
        public int IdUsuario { get; set; }
        public IndicadorFinanciero Indicador { get; set; }
        [ForeignKey("IdOperacion")]
        public int IdOperacion { get; set; }        
        public int Periodo { get; set; }
        //[RegularExpression(@"^\d+(\.\d{1,2})?$")]
        //[Range(0,9999999999.99)]
        [Column(TypeName ="decimal(10,2)")]
        public decimal Monto { get; set; }
    }
}
