using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanzasAPIRest.IRepository;
using FinanzasAPIRest.Models;
using Microsoft.VisualBasic;

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
            IndicadorFinanciero indicador = new IndicadorFinanciero();            
            DatosBono dato= await _datos.FindOperacionById(IdOperacion);            

            const double impuestoRenta = 0.3;
            decimal gastosAdicionales = -dato.GastosAdicionales * dato.ValorComercial;
                     

            double[] bonoIndexado = new double[dato.Plazo];
            double[] bonoInicial = new double[dato.Plazo];
            double[] bonoFinal = new double[dato.Plazo];
            double[] cuota = new double[dato.Plazo];
            double[] amortizaciones = new double[dato.Plazo];
            double[] interesCupon = new double[dato.Plazo];
            double[] escudo = new double[dato.Plazo];

            //double[] otroFlujoCaja = new double[dato.Plazo];

            //flujos de caja

            //periodo cero
            decimal flujoBonista_Periodo_0 = -dato.ValorComercial - (dato.ValorComercial * (dato.Cavali + dato.Flotacion));
            decimal flujoEmisor_Periodo_0 = dato.ValorComercial + gastosAdicionales;
            decimal flujoEmisor_Escudo_Periodo_0 = flujoEmisor_Periodo_0;

            //periodos siguientes
            double[] flujoCajaBonista = new double[dato.Plazo ];
            double[] flujoCajaEmisor = new double[dato.Plazo];
            double[] flujoCajaEmisorEscudo = new double[dato.Plazo ];           

            double[] resultadoPrecioBono = new double[dato.Plazo];

            //double[] lista
            double[] lista_tir_emisor = new double[dato.Plazo + 1];
            double[] lista_tir_emisor_escudo = new double[dato.Plazo + 1];
            double[] lista_tir_bonista = new double[dato.Plazo + 1];
            lista_tir_bonista[0] = (double)flujoBonista_Periodo_0;
            lista_tir_emisor[0] = (double)flujoEmisor_Periodo_0;
            lista_tir_emisor_escudo[0] = (double)flujoEmisor_Escudo_Periodo_0;

            for(int i = 1; i <= dato.Plazo; i++)
            {
                if (bonoInicial[i-1]==bonoInicial[0])
                {
                    bonoInicial[0] = (double)(dato.ValorNominal);
                }
                else
                {
                    bonoInicial[i - 1] = bonoFinal[i-2]; 
                }             
                bonoIndexado[i - 1] = bonoInicial[i - 1] * (1 + Convert.ToDouble(dato.InflacionAnual)); //
                interesCupon[i - 1] = -bonoIndexado[i - 1] * (double)(dato.Cupon);
                cuota[i - 1] = -bonoIndexado[i - 1] * (double)(dato.Cupon) / (1 - Math.Pow((1 + Convert.ToDouble(dato.Cupon)), -(dato.Plazo - (i-1))));
                amortizaciones[i - 1] = cuota[i - 1] - interesCupon[i - 1];
                bonoFinal[i - 1] = bonoIndexado[i - 1] + amortizaciones[i - 1];
                escudo[i - 1] = -interesCupon[i - 1] * impuestoRenta;
                if (flujoCajaEmisor[i - 1] == flujoCajaEmisor[dato.Plazo - 1]) 
                {
                    double prima = -bonoIndexado[dato.Plazo - 1] * Convert.ToDouble(dato.PrimaRedencion);
                    flujoCajaEmisor[i - 1] = (cuota[i - 1])+prima;                    
                }
                else
                {
                    flujoCajaEmisor[i - 1] = (cuota[i - 1]);
                }               
                flujoCajaEmisorEscudo[i - 1] = flujoCajaEmisor[i - 1] + escudo[i - 1];
                flujoCajaBonista[i - 1] = -(flujoCajaEmisor[i - 1]);
                resultadoPrecioBono[i - 1] = flujoCajaBonista[i - 1] / Math.Pow(1 + (double)dato.TasaInteresMercado,i);


                lista_tir_emisor[i] = flujoCajaEmisor[i - 1];
                lista_tir_emisor_escudo[i] = flujoCajaEmisorEscudo[i - 1];
                lista_tir_bonista[i ] = flujoCajaBonista[i - 1];
                

            }
            double duracion = 0;
            double duracionModificada = duracion/(1+(double)dato.TasaInteresMercado);

            indicador.TIR_Emisor = (decimal)(Financial.IRR(ref lista_tir_emisor) * 100);
            indicador.TIR_Escudo = (decimal)(Financial.IRR(ref lista_tir_emisor_escudo) * 100);
            indicador.TIR_Bonista = (decimal)(Financial.IRR(ref lista_tir_bonista)*100);            
            indicador.PrecioBono = ((decimal)resultadoPrecioBono.Sum());
            indicador.VAN = indicador.PrecioBono + flujoBonista_Periodo_0;
            indicador.IdOperacion = IdOperacion;          
            indicador.TCEA_Emisor = 1;                      
            indicador.TREA_Bonista = 1;
            indicador.TCEA_Emisor = 1;           
            
            await _dbContext.IndicadorFinanciero.AddAsync(indicador);            
            await _dbContext.SaveChangesAsync();
        }
    }
}
