using WarehouseBase.Domain.Entities;

namespace WarehouseBase.Application.Services
{
    public interface IWarehouseBaseService
    {
        Task Create(BaseRecord baseRecord);

        Task<BaseRecord> GetById(int id);
        Task<IEnumerable<BaseRecord>> GetAll();

        Task AddItem(int id);

        Task RemoveItem(int id);

    }
}