using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBase.Domain.Entities;
using WarehouseBase.Domain.Interfaces;

namespace WarehouseBase.Application.Services
{
    public class WarehouseBaseService : IWarehouseBaseService
    {
        private readonly IWarehouseBaseRepository _warehouseBaseRepository;
        public WarehouseBaseService(IWarehouseBaseRepository warehouseBaseRepository)
        {
            _warehouseBaseRepository = warehouseBaseRepository;
        }
        public async Task Create(BaseRecord baseRecord)
        {
            await _warehouseBaseRepository.Create(baseRecord);
        }
    }
}
