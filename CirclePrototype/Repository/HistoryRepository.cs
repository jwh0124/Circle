using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CirclePrototype.Models;
using LightQuery.Client;
using Microsoft.EntityFrameworkCore;

namespace CirclePrototype.Repository
{
    public class HistoryRepository : IHistoryRepository
    {
        private readonly ApplicationContext _context;

        public HistoryRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<History>> GetList()
        {
            return await _context.Histories.ToListAsync();
        }
    }
}