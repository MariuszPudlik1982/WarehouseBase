using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBase.Domain.Entities;
using WarehouseBase.Domain.Interfaces;
using WarehouseBase.Infrastructure.Persistence;

namespace WarehouseBase.Infrastructure.Repositories
{
    internal class WarehouseBaseRepository : IWarehouseBaseRepository
    {
        private readonly WarehouseBaseDbContext _dbContext;
        public WarehouseBaseRepository(WarehouseBaseDbContext dbContext)
        {
                _dbContext = dbContext;
        }
        public async Task Create(BaseRecord baseRecord)
        {
           _dbContext.Add(baseRecord);
           await  _dbContext.SaveChangesAsync();
        }
    }
}
