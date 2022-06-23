using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanzasAPIRest.Models;
namespace FinanzasAPIRest.IRepository
{
    public interface IDatosBonoRepository
    {
        List<DatosBono> FindAll();
        Task<DatosBono> FindOperacionById(int idOperacion);
        Task Insert(DatosBono datos);
    }
}
