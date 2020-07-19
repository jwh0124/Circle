using System.Collections.Generic;
using System.Linq;
using CirclePrototype.Models;

namespace CirclePrototype.Repository
{
    public class HistoryRepository : IHistoryRepository
    {
        private readonly ApplicationContext _context;

        public HistoryRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<History> GetList()
        {
            return _context.Histories.ToList();
        }
    }
}