using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarehouseBase.Application.Services;
using WarehouseBase.Domain.Entities;

namespace WarehouseBase.MVC.Controllers
{
    public class WarehouseBaseController : Controller
    {
        // GET: WarehouseBaseController
        private readonly IWarehouseBaseService _warehouseBaseService;
        public WarehouseBaseController(IWarehouseBaseService warehouseBaseService)
        {
                _warehouseBaseService = warehouseBaseService;
        }

        public IActionResult Create()
        {
            return View();
        }
        // GET: WarehouseBaseController/Create
        [HttpPost]
        public async Task<IActionResult> Create(BaseRecord baseRecord)
        {
           await _warehouseBaseService.Create(baseRecord);
            return RedirectToAction(nameof(Create));//TODO:Refactor
        }

       
        // GET: WarehouseBaseController/Delete/5
       
    }
}
