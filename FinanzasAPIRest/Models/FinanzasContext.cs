using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanzasAPIRest.Models
{
    public class FinanzasContext : DbContext
    {
        public FinanzasContext(DbContextOptions<FinanzasContext> options) :
           base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<DatosBono> DatosBono { get; set; }
        public DbSet<IndicadorFinanciero> IndicadorFinanciero { get; set; }
        public DbSet<FrecuenciaPago> FrecuenciaPago { get; set; }
        //public DbSet<Moneda> Moneda { get; set; }
        //public DbSet<Tasa> Tasa { get; set; }
        //public DbSet<UnidadTiempo> UnidadTiempo { get; set; }


    }
}
