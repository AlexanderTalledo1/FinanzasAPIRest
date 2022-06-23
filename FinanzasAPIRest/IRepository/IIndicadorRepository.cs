using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanzasAPIRest.Models;
namespace FinanzasAPIRest.IRepository
{
    public interface IIndicadorRepository
    {
        Task Insert(int idOperacion);
    }
}
