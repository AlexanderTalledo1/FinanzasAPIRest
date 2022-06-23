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
        public async Task Insert(IndicadorFinanciero indicador,int idOperacion)
        {
            await _datos.FindOperacionById(idOperacion);
            indicador.IdOperacion = idOperacion;
            foreach(DatosBono datos in _datos.FindAll())
            await _dbContext.IndicadorFinanciero.AddAsync(indicador);            
            await _dbContext.SaveChangesAsync();
        }
    }
}
