using System.Collections.Generic;
using CirclePrototype.Models;

namespace CirclePrototype.Repository
{
    public interface IHistoryRepository
    {
         public IEnumerable<History> GetList();
    }
}