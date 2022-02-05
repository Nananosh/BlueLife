using System.Collections;
using BlueLife.Migrations;
using BlueLife.Models;

namespace BlueLife.Business.Interfaces
{
    public interface IAdminService
    {
        public MedicineName AddMedicineName(MedicineName medicineName);
        public MedicineType AddMedicineType(MedicineType medicineType);
        public MedicineManufacturer AddMedicineManufacturer(MedicineManufacturer medicineManufacturer);
        public MedicineUnit AddMedicineUnit(MedicineUnit medicineUnit);
        public CatalogMedicine AddCatalogMedicine(CatalogMedicine catalogMedicine);
        public Medicine AddMedicine(Medicine medicine);
        public ReleaseMedicine AddReleaseMedicine(ReleaseMedicine releaseMedicine);
        public PharmacyWarehouse AddPharmacyWarehouse(PharmacyWarehouse pharmacyWarehouse);
        public IEnumerable GetAllCatalogMedicine();
        public IEnumerable GetAllMedicineType();
        public IEnumerable GetAllMedicineName();
        public IEnumerable GetAllMedicineUnit();
        public IEnumerable GetAllMedicineManufacturer();
        public IEnumerable GetAllMedicine();
        public IEnumerable GetAllPharmacyWarehouses();
        public IEnumerable GetAllReleaseMedicine();
        public IEnumerable GetAllOrders();
        public IEnumerable GetAllOrderStatus();
        public MedicineName EditMedicineName(MedicineName medicineName);
        public MedicineType EditMedicineType(MedicineType medicineType);
        public MedicineManufacturer EditMedicineManufacturer(MedicineManufacturer medicineManufacturer);
        public MedicineUnit EditMedicineUnit(MedicineUnit medicineUnit);
        public CatalogMedicine EditCatalogMedicine(CatalogMedicine catalogMedicine);
        public Medicine EditMedicine(Medicine medicine);
        public ReleaseMedicine EditReleaseMedicine(ReleaseMedicine releaseMedicine);
        public PharmacyWarehouse EditPharmacyWarehouse(PharmacyWarehouse pharmacyWarehouse);
        public Order EditOrder(Order order);
        public void DeleteMedicineName(MedicineName medicineName);
        public void DeleteMedicineType(MedicineType medicineType);
        public void DeleteMedicineManufacturer(MedicineManufacturer medicineManufacturer);
        public void DeleteMedicineUnit(MedicineUnit medicineUnit);
        public void DeleteCatalogMedicine(CatalogMedicine catalogMedicine);
        public void DeleteMedicine(Medicine medicine);
        public void DeleteReleaseMedicine(ReleaseMedicine releaseMedicine);
        public void DeletePharmacyWarehouse(PharmacyWarehouse pharmacyWarehouse);
    }
}