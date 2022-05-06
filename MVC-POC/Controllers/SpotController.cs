using Core;
using Microsoft.AspNetCore.Mvc;

namespace MVC_POC.Controllers
{
    public class SpotController : Controller
    {
        private readonly ICPUnitOfWork _uow;
        public SpotController(ICPUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<IActionResult> Index()
        {
            var spots = await _uow.Spots.GetAll();
            return View(spots);
        }
    }
}
