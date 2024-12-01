using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBase.Domain.Entities;

namespace WarehouseBase.Domain.Interfaces
{
    public interface IWarehouseBaseRepository
    {
        Task Create(BaseRecord baseRecord);

        Task<IEnumerable<BaseRecord>> GetAll();

        public  Task<BaseRecord> GetById(int id);

        Task Commit();
    }
}
