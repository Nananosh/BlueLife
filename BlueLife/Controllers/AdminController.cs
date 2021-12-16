using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using BlueLife.Business.Interfaces;
using BlueLife.Migrations;
using BlueLife.Models;
using BlueLife.ViewModels;
using BlueLife.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;

namespace BlueLife.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationContext db;
        private readonly IAdminService adminService;
        private readonly IMapper mapper;
        
        public AdminController(ApplicationContext db, IAdminService adminService, IMapper mapper)
        {
            this.db = db;
            this.adminService = adminService;
            this.mapper = mapper;
        }

        public IActionResult AddMedicineName()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMedicineName(MedicineNameViewModel model)
        {
            adminService.AddMedicineName(db,mapper.Map<MedicineName>(model));
            return RedirectToAction();
        }
        
        public IActionResult AddMedicineManufacturer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMedicineManufacturer(MedicineManufacturerViewModel model)
        {
            adminService.AddMedicineManufacturer(db,mapper.Map<MedicineManufacturer>(model));
            return RedirectToAction();
        }
        
        public IActionResult AddMedicineType()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMedicineType(MedicineTypeViewModel model)
        {
            adminService.AddMedicineType(db,mapper.Map<MedicineType>(model));
            return RedirectToAction();
        }
        
        public IActionResult AddMedicineUnit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMedicineUnit(MedicineUnitViewModel model)
        {
            adminService.AddMedicineUnit(db,mapper.Map<MedicineUnit>(model));
            return RedirectToAction();
        }
        
        public IActionResult AddCatalogMedicine()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCatalogMedicine(CatalogMedicineViewModel model)
        {
            adminService.AddCatalogMedicine(db,mapper.Map<CatalogMedicine>(model));
            return RedirectToAction();
        }
        
        public IActionResult AddMedicine()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMedicine(MedicineViewModel model)
        {
            adminService.AddMedicine(db,mapper.Map<Medicine>(model));
            return RedirectToAction();
        }
        
        public IActionResult AddReleaseMedicine()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddReleaseMedicine(ReleaseMedicineViewModel model)
        {
            adminService.AddReleaseMedicine(db,mapper.Map<ReleaseMedicine>(model));
            return RedirectToAction();
        }

        public IActionResult GetAllCatalogMedicine()
        {
            var catalogMedicine = adminService.GetAllCatalogMedicine(db);
            return Json(mapper.Map<IEnumerable<CatalogMedicineViewModel>>(catalogMedicine));
        }
        
        public IActionResult GetAllMedicineType()
        {
            var medicineType = adminService.GetAllMedicineType(db);
            return Json(mapper.Map<IEnumerable<MedicineTypeViewModel>>(medicineType));
        }
        
        public IActionResult GetAllMedicineName()
        {
            var medicineName = adminService.GetAllMedicineName(db);
            return Json(mapper.Map<IEnumerable<MedicineNameViewModel>>(medicineName));
        }
        
        public IActionResult GetAllMedicineUnit()
        {
            var medicineUnit = adminService.GetAllMedicineUnit(db);
            return Json(mapper.Map<IEnumerable<MedicineUnitViewModel>>(medicineUnit));
        }
        
        public IActionResult GetAllMedicineManufacturer()
        {
            var medicineManufacturer = adminService.GetAllMedicineManufacturer(db);
            return Json(mapper.Map<IEnumerable<MedicineManufacturerViewModel>>(medicineManufacturer));
        }
        
        public IActionResult GetAllMedicine()
        {
            var medicine = adminService.GetAllMedicine(db);
            return Json(mapper.Map<IEnumerable<MedicineViewModel>>(medicine));
        }
    }
}