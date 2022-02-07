using System.Collections.Generic;
using System.Diagnostics;
using AutoMapper;
using BlueLife.Business.Interfaces;
using BlueLife.Models;
using BlueLife.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlueLife.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBuyMedicineService buyMedicineService;
        private readonly IMapper mapper;

        public HomeController(ILogger<HomeController> logger, IBuyMedicineService buyMedicineService, IMapper mapper)
        {
            _logger = logger;
            this.buyMedicineService = buyMedicineService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var medicines = buyMedicineService.GetAllPharmacyWarehouse();
            medicines.Reverse();
            return View(mapper.Map<List<PharmacyWarehouseViewModel>>(medicines));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}