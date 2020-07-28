using System.Collections.Generic;
using System.Threading.Tasks;
using CirclePrototype.Models;

namespace CirclePrototype.Repository
{
    public interface IHistoryRepository
    {
         public Task<List<History>> GetList();
    }
}