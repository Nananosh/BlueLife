using System.Collections;
using BlueLife.Business.Interfaces;
using BlueLife.Migrations;
using BlueLife.Models;
using Microsoft.AspNetCore.Routing.Internal;
using Microsoft.EntityFrameworkCore;

namespace BlueLife.Business.Services
{
    public class AdminService : IAdminService
    {
        public void AddMedicineName(ApplicationContext db, MedicineName medicineName)
        {
            db.MedicineName.Add(medicineName);
            db.SaveChanges();
        }

        public void AddMedicineType(ApplicationContext db, MedicineType medicineType)
        {
            db.MedicineType.Add(medicineType);
            db.SaveChanges();
        }

        public void AddMedicineManufacturer(ApplicationContext db, MedicineManufacturer medicineManufacturer)
        {
            db.MedicineManufacturer.Add(medicineManufacturer);
            db.SaveChanges();
        }

        public void AddMedicineUnit(ApplicationContext db, MedicineUnit medicineUnit)
        {
            db.MedicineUnit.Add(medicineUnit);
            db.SaveChanges();
        }

        public void AddCatalogMedicine(ApplicationContext db, CatalogMedicine catalogMedicine)
        {
            db.CatalogMedicine.Add(catalogMedicine);
            db.SaveChanges();
        }
        
        public void AddMedicine(ApplicationContext db, Medicine medicine)
        {
            db.Medicine.Add(medicine);
            db.SaveChanges();
        }

        public void AddReleaseMedicine(ApplicationContext db, ReleaseMedicine releaseMedicine)
        {
            db.ReleaseMedicine.Add(releaseMedicine);
            db.SaveChanges();
        }

        public void AddPharmacyWarehouse(ApplicationContext db, PharmacyWarehouse pharmacyWarehouse)
        {
            db.PharmacyWarehouses.Add(pharmacyWarehouse);
            db.SaveChanges();
        }

        public IEnumerable GetAllCatalogMedicine(ApplicationContext db)
        {
            var catalogMedicine = db.CatalogMedicine;
            return catalogMedicine;
        }

        public IEnumerable GetAllMedicineType(ApplicationContext db)
        {
            var medicineType = db.MedicineType;
            return medicineType;
        }

        public IEnumerable GetAllMedicineName(ApplicationContext db)
        {
            var medicineName = db.MedicineName;
            return medicineName;
        }

        public IEnumerable GetAllMedicineUnit(ApplicationContext db)
        {
            var medicineUnit = db.MedicineUnit;
            return medicineUnit;
        }

        public IEnumerable GetAllMedicineManufacturer(ApplicationContext db)
        {
            var medicineManufacturer = db.MedicineManufacturer;
            return medicineManufacturer;
        }

        public IEnumerable GetAllMedicine(ApplicationContext db)
        {
            var medicines = db.Medicine
                .Include(x => x.MedicineName)
                .ThenInclude(x => x.CatalogMedicines)
                .Include(x => x.MedicineType)
                .Include(x => x.MedicineUnit);
            return medicines;
        }

        public IEnumerable GetAllPharmacyWarehouses(ApplicationContext db)
        {
            var pharmacyWarehouses = db.PharmacyWarehouses;
            return pharmacyWarehouses;
        }
    }
}