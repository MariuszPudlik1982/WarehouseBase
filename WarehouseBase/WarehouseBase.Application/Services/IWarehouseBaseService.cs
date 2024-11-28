using WarehouseBase.Domain.Entities;

namespace WarehouseBase.Application.Services
{
    public interface IWarehouseBaseService
    {
        Task Create(BaseRecord baseRecord);
    }
}