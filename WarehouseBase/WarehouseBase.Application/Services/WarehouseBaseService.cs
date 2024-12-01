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

        public async Task<IEnumerable<BaseRecord>> GetAll()
        {
           var baseRecords= await _warehouseBaseRepository.GetAll();    
            return baseRecords;
        }

        public async Task<BaseRecord> GetById(int id)
        {
            var baseRecord = await _warehouseBaseRepository.GetById(id);

            return baseRecord;
        }


        public async Task AddItem(int id)
        {
            var baseRecord=await _warehouseBaseRepository.GetById(id);

           baseRecord.NumberOfPartsInBase= baseRecord.NumberOfPartsInBase + 1;

           await _warehouseBaseRepository.Commit();
        }

        public async Task RemoveItem(int id)
        {
            var baseRecord = await _warehouseBaseRepository.GetById(id);
            if (baseRecord.NumberOfPartsInBase>0)
            {
                baseRecord.NumberOfPartsInBase = baseRecord.NumberOfPartsInBase - 1;
            }
            else
            {
                baseRecord.NumberOfPartsInBase = 0;
            }

            await _warehouseBaseRepository.Commit();
        }
    }

}
