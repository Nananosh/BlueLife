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

        [HttpGet]
        public IActionResult AdminCatalogMedicine()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult AdminMedicineName()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult AdminMedicineUnit()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult AdminMedicineType()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult AdminMedicineManufacturer()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult AdminMedicine()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult AdminReleaseMedicine()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult AdminPharmacyWarehouses()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult AdminPanel()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddMedicineName(MedicineNameViewModel model)
        {
            var medicineName = adminService.AddMedicineName(mapper.Map<MedicineName>(model));
            return Json(mapper.Map<MedicineNameViewModel>(medicineName));
        }

        [HttpPost]
        public IActionResult AddMedicineManufacturer(MedicineManufacturerViewModel model)
        {
            var medicineManufacturer = adminService.AddMedicineManufacturer(mapper.Map<MedicineManufacturer>(model));
            return Json(mapper.Map<MedicineManufacturerViewModel>(medicineManufacturer));
        }
        

        [HttpPost]
        public IActionResult AddMedicineType(MedicineTypeViewModel model)
        {
            var medicineType = adminService.AddMedicineType(mapper.Map<MedicineType>(model));
            return Json(mapper.Map<MedicineTypeViewModel>(medicineType));;
        }

        [HttpPost]
        public IActionResult AddMedicineUnit(MedicineUnitViewModel model)
        {
            var medicineUnit = adminService.AddMedicineUnit(mapper.Map<MedicineUnit>(model));
            return Json(mapper.Map<MedicineUnitViewModel>(medicineUnit));
        }

        [HttpPost]
        public IActionResult AddCatalogMedicine(CatalogMedicineViewModel model)
        {
            var catalogMedicine =  adminService.AddCatalogMedicine(mapper.Map<CatalogMedicine>(model));
            return Json(mapper.Map<CatalogMedicineViewModel>(catalogMedicine));
        }

        [HttpPost]
        public IActionResult AddMedicine(MedicineViewModel model)
        {
            var medicine = adminService.AddMedicine(mapper.Map<Medicine>(model));
            return Json(mapper.Map<MedicineViewModel>(medicine));
        }

        [HttpPost]
        public IActionResult AddReleaseMedicine(ReleaseMedicineViewModel model)
        {
            var releaseMedicine = adminService.AddReleaseMedicine(mapper.Map<ReleaseMedicine>(model));
            return Json(mapper.Map<ReleaseMedicineViewModel>(releaseMedicine));
        }
        
        [HttpPost]
        public IActionResult AddPharmacyWarehouses(PharmacyWarehouseViewModel model)
        {
            var pharmacyWarehouses = adminService.AddPharmacyWarehouse(mapper.Map<PharmacyWarehouse>(model));
            return Json(mapper.Map<PharmacyWarehouseViewModel>(pharmacyWarehouses));
        }

        public IActionResult GetAllCatalogMedicine()
        {
            var catalogMedicine = adminService.GetAllCatalogMedicine();
            return Json(mapper.Map<IEnumerable<CatalogMedicineViewModel>>(catalogMedicine));
        }
        
        public IActionResult GetAllMedicineType()
        {
            var medicineType = adminService.GetAllMedicineType();
            return Json(mapper.Map<IEnumerable<MedicineTypeViewModel>>(medicineType));
        }
        
        public IActionResult GetAllMedicineName()
        {
            var medicineName = adminService.GetAllMedicineName();
            return Json(mapper.Map<IEnumerable<MedicineNameViewModel>>(medicineName));
        }
        
        public IActionResult GetAllMedicineUnit()
        {
            var medicineUnit = adminService.GetAllMedicineUnit();
            return Json(mapper.Map<IEnumerable<MedicineUnitViewModel>>(medicineUnit));
        }
        
        public IActionResult GetAllMedicineManufacturer()
        {
            var medicineManufacturer = adminService.GetAllMedicineManufacturer();
            return Json(mapper.Map<IEnumerable<MedicineManufacturerViewModel>>(medicineManufacturer));
        }
        
        public IActionResult GetAllMedicine()
        {
            var medicine = adminService.GetAllMedicine();
            return Json(mapper.Map<IEnumerable<MedicineViewModel>>(medicine));
        }
        public IActionResult GetAllPharmacyWarehouses()
        {
            var pharmacyWarehouses = adminService.GetAllPharmacyWarehouses();
            return Json(mapper.Map<IEnumerable<PharmacyWarehouseViewModel>>(pharmacyWarehouses));
        }
        
        public IActionResult GetAllReleaseMedicine()
        {
            var releaseMedicine = adminService.GetAllReleaseMedicine();
            return Json(mapper.Map<IEnumerable<ReleaseMedicineViewModel>>(releaseMedicine));
        }
        
        [HttpPost]
        public IActionResult EditMedicineName(MedicineNameViewModel model)
        {
            var medicineName = adminService.EditMedicineName(mapper.Map<MedicineName>(model));
            return Json(mapper.Map<MedicineNameViewModel>(medicineName));
        }

        [HttpPost]
        public IActionResult EditMedicineManufacturer(MedicineManufacturerViewModel model)
        {
            var medicineManufacturer = adminService.EditMedicineManufacturer(mapper.Map<MedicineManufacturer>(model));
            return Json(mapper.Map<MedicineManufacturerViewModel>(medicineManufacturer));
        }
        

        [HttpPost]
        public IActionResult EditMedicineType(MedicineTypeViewModel model)
        {
            var medicineType = adminService.EditMedicineType(mapper.Map<MedicineType>(model));
            return Json(mapper.Map<MedicineTypeViewModel>(medicineType));;
        }

        [HttpPost]
        public IActionResult EditMedicineUnit(MedicineUnitViewModel model)
        {
            var medicineUnit = adminService.EditMedicineUnit(mapper.Map<MedicineUnit>(model));
            return Json(mapper.Map<MedicineUnitViewModel>(medicineUnit));
        }

        [HttpPost]
        public IActionResult EditCatalogMedicine(CatalogMedicineViewModel model)
        {
            var catalogMedicine =  adminService.EditCatalogMedicine(mapper.Map<CatalogMedicine>(model));
            return Json(mapper.Map<CatalogMedicineViewModel>(catalogMedicine));
        }

        [HttpPost]
        public IActionResult EditMedicine(MedicineViewModel model)
        {
            var medicine = adminService.EditMedicine(mapper.Map<Medicine>(model));
            return Json(mapper.Map<MedicineViewModel>(medicine));
        }

        [HttpPost]
        public IActionResult EditReleaseMedicine(ReleaseMedicineViewModel model)
        {
            var releaseMedicine = adminService.EditReleaseMedicine(mapper.Map<ReleaseMedicine>(model));
            return Json(mapper.Map<ReleaseMedicineViewModel>(releaseMedicine));
        }
        
        [HttpPost]
        public IActionResult EditPharmacyWarehouses(PharmacyWarehouseViewModel model)
        {
            var pharmacyWarehouses = adminService.EditPharmacyWarehouse(mapper.Map<PharmacyWarehouse>(model));
            return Json(mapper.Map<PharmacyWarehouseViewModel>(pharmacyWarehouses));
        }
        
        [HttpDelete]
        public void DeleteMedicineName(MedicineNameViewModel model)
        {
            adminService.DeleteMedicineName(mapper.Map<MedicineName>(model));
        }

        [HttpDelete]
        public void DeleteMedicineManufacturer(MedicineManufacturerViewModel model)
        {
            adminService.DeleteMedicineManufacturer(mapper.Map<MedicineManufacturer>(model));
        }
        
        [HttpDelete]
        public void DeleteMedicineType(MedicineTypeViewModel model)
        {
           adminService.DeleteMedicineType(mapper.Map<MedicineType>(model));
        }

        [HttpDelete]
        public void DeleteMedicineUnit(MedicineUnitViewModel model)
        {
            adminService.DeleteMedicineUnit(mapper.Map<MedicineUnit>(model));
        }

        [HttpDelete]
        public void DeleteCatalogMedicine(CatalogMedicineViewModel model)
        {
            adminService.DeleteCatalogMedicine(mapper.Map<CatalogMedicine>(model));
        }

        [HttpDelete]
        public void DeleteMedicine(MedicineViewModel model)
        {
            adminService.DeleteMedicine(mapper.Map<Medicine>(model));
        }

        [HttpDelete]
        public void DeleteReleaseMedicine(ReleaseMedicineViewModel model)
        {
            adminService.DeleteReleaseMedicine(mapper.Map<ReleaseMedicine>(model));
        }
        
        [HttpDelete]
        public void DeletePharmacyWarehouses(PharmacyWarehouseViewModel model)
        {
            adminService.DeletePharmacyWarehouse(mapper.Map<PharmacyWarehouse>(model));
        }
    }
}