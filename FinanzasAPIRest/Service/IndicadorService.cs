using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanzasAPIRest.IRepository;
using FinanzasAPIRest.Models;
namespace FinanzasAPIRest.Service
{
    public class IndicadorService : IIndicadorRepository
    {
        public readonly FinanzasContext _dbContext;
        public readonly IDatosBonoRepository _datos;
        
        public IndicadorService(FinanzasContext dbContext, IDatosBonoRepository datos)
        {
            _dbContext = dbContext;
            _datos = datos;
        }
        public async Task Insert(int IdOperacion)        
        {
            const double impuestoRenta = 0.3;
            List<double> Resultado= new List<double>();

            IndicadorFinanciero indicador = new IndicadorFinanciero();            
            DatosBono dato= await _datos.FindOperacionById(IdOperacion);
           
            decimal flujoEmisor = 0;
            decimal flujoEmisorEscudo = 0;
            decimal flujoBonista = dato.ValorComercial - (dato.ValorComercial*(dato.Cavali+dato.Flotacion) );

            decimal van = 0;


            //decimal flujoBonista_periodo_cero = dato.ValorComercial - (dato.ValorComercial * (dato.Flotacion + dato.Cavali));            
            decimal flujoBonista_periodo_cero = 1;            
            for(int i = 0; i <= dato.Plazo; i++)
            {
                 //Resultado[i] += (1 / Math.Pow(1 + Convert.ToDouble(indicador.TIR_Bonista),2));         
                //Math.Pow(Convert.ToDouble((1 + dato.InflacionAnual)),Convert.ToDouble( 1+dato.PrimaRedencion));
                //indicador.PrecioBono = (dato.Cupon* Convert.ToDecimal(Resultado[i])) + (dato.ValorNominal/(1+indicador.TIR_Emisor));
            }
            //indicador.PrecioBono = (dato.Cupon * Convert.ToDecimal(Resultado)) + (dato.ValorNominal / (1 + indicador.TIR_Emisor));
            indicador.PrecioBono = flujoBonista;
            indicador.IdOperacion = IdOperacion;
            indicador.TIR_Emisor = 1;
            indicador.TCEA_Emisor = 1;
            indicador.TIR_Escudo = 1;
            indicador.TIR_Bonista = 1;
            indicador.TREA_Bonista = 1;
            indicador.TCEA_Emisor = Convert.ToDecimal(Math.Pow(1 + Convert.ToDouble(indicador.TIR_Emisor), 2))-1;
            indicador.VAN = indicador.PrecioBono - flujoBonista_periodo_cero; 
            
            await _dbContext.IndicadorFinanciero.AddAsync(indicador);            
            await _dbContext.SaveChangesAsync();
        }
    }
}
