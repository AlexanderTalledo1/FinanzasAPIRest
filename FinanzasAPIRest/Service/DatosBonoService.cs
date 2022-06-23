using FinanzasAPIRest.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanzasAPIRest.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanzasAPIRest.Service
{
    public class DatosBonoService : IDatosBonoRepository
    {
        public readonly FinanzasContext _dbContext;
       
        public DatosBonoService(FinanzasContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<DatosBono> FindAll() => _dbContext.DatosBono.ToList();
        public async Task<DatosBono> FindOperacionById(int idOperacion) => await _dbContext.DatosBono.FindAsync(idOperacion);

        public async Task Insert(DatosBono datos)
        {
            await _dbContext.AddAsync(datos);
            await _dbContext.SaveChangesAsync();
        }
    }
    
}
