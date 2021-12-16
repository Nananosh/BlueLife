using System.Collections;
using BlueLife.Migrations;
using BlueLife.Models;

namespace BlueLife.Business.Interfaces
{
    public interface IAdminService
    {
        public void AddMedicineName(ApplicationContext db, MedicineName medicineName);
        public void AddMedicineType(ApplicationContext db, MedicineType medicineType);
        public void AddMedicineManufacturer(ApplicationContext db, MedicineManufacturer medicineManufacturer);
        public void AddMedicineUnit(ApplicationContext db, MedicineUnit medicineUnit);
        public void AddCatalogMedicine(ApplicationContext db, CatalogMedicine catalogMedicine);
        public void AddMedicine(ApplicationContext db, Medicine medicine);
        public void AddReleaseMedicine(ApplicationContext db, ReleaseMedicine releaseMedicine);
        public void AddPharmacyWarehouse(ApplicationContext db, PharmacyWarehouse pharmacyWarehouse);
        public IEnumerable GetAllCatalogMedicine(ApplicationContext db);
        public IEnumerable GetAllMedicineType(ApplicationContext db);
        public IEnumerable GetAllMedicineName(ApplicationContext db);
        public IEnumerable GetAllMedicineUnit(ApplicationContext db);
        public IEnumerable GetAllMedicineManufacturer(ApplicationContext db);
        public IEnumerable GetAllMedicine(ApplicationContext db);
        public IEnumerable GetAllPharmacyWarehouses(ApplicationContext db);

    }
}