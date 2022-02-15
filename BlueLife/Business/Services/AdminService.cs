using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using BlueLife.Business.Interfaces;
using BlueLife.Migrations;
using BlueLife.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueLife.Business.Services
{
    public class AdminService : IAdminService
    {
        private readonly ApplicationContext db;

        public AdminService(ApplicationContext db)
        {
            this.db = db;
        }

        public MedicineName AddMedicineName(MedicineName medicineName)
        {
            db.MedicineName.Add(medicineName);
            db.SaveChanges();
            var addedMedicineName = db.MedicineName
                .Include(x => x.CatalogMedicines)
                .FirstOrDefault(x => x.Id == medicineName.Id);

            return addedMedicineName;
        }

        public MedicineType AddMedicineType(MedicineType medicineType)
        {
            db.MedicineType.Add(medicineType);
            db.SaveChanges();
            var addedMedicineType = db.MedicineType.FirstOrDefault(x => x.Id == medicineType.Id);

            return addedMedicineType;
        }

        public MedicineManufacturer AddMedicineManufacturer(MedicineManufacturer medicineManufacturer)
        {
            db.MedicineManufacturer.Add(medicineManufacturer);
            db.SaveChanges();
            var addedMedicineManufacturer =
                db.MedicineManufacturer.FirstOrDefault(x => x.Id == medicineManufacturer.Id);

            return addedMedicineManufacturer;
        }

        public MedicineUnit AddMedicineUnit(MedicineUnit medicineUnit)
        {
            db.MedicineUnit.Add(medicineUnit);
            db.SaveChanges();
            var addedMedicineUnit = db.MedicineUnit.FirstOrDefault(x => x.Id == medicineUnit.Id);

            return addedMedicineUnit;
        }

        public CatalogMedicine AddCatalogMedicine(CatalogMedicine catalogMedicine)
        {
            db.CatalogMedicine.Add(catalogMedicine);
            db.SaveChanges();
            var addedCatalogMedicine = db.CatalogMedicine.FirstOrDefault(x => x.Id == catalogMedicine.Id);

            return addedCatalogMedicine;
        }

        public Medicine AddMedicine(Medicine medicine)
        {
            db.Medicine.Add(medicine);
            db.SaveChanges();
            var addedMedicine = db.Medicine
                .Include(x => x.MedicineName)
                .ThenInclude(x => x.CatalogMedicines)
                .Include(x => x.MedicineType)
                .Include(x => x.MedicineUnit)
                .FirstOrDefault(x => x.Id == medicine.Id);

            return addedMedicine;
        }

        public ReleaseMedicine AddReleaseMedicine(ReleaseMedicine releaseMedicine)
        {
            db.ReleaseMedicine.Add(releaseMedicine);
            db.SaveChanges();
            var addedReleaseMedicine = db.ReleaseMedicine
                .Include(x => x.Manufacturer)
                .Include(x => x.Medicine)
                .ThenInclude(x => x.MedicineName)
                .ThenInclude(x => x.CatalogMedicines)
                .Include(x => x.Medicine)
                .ThenInclude(x => x.MedicineType)
                .Include(x => x.Medicine)
                .ThenInclude(x => x.MedicineUnit)
                .FirstOrDefault(x => x.Id == releaseMedicine.Id);

            return addedReleaseMedicine;
        }

        public PharmacyWarehouse AddPharmacyWarehouse(PharmacyWarehouse pharmacyWarehouse)
        {
            db.PharmacyWarehouses.Add(pharmacyWarehouse);
            db.SaveChanges();
            var addedPharmacyWarehouse = db.PharmacyWarehouses
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Manufacturer)
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineName)
                .ThenInclude(x => x.CatalogMedicines)
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineType)
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineUnit)
                .FirstOrDefault(x => x.Id == pharmacyWarehouse.Id);

            return addedPharmacyWarehouse;
        }

        public IEnumerable GetAllCatalogMedicine()
        {
            var catalogMedicine = db.CatalogMedicine;
            return catalogMedicine;
        }

        public IEnumerable GetAllMedicineType()
        {
            var medicineType = db.MedicineType;
            return medicineType;
        }

        public IEnumerable GetAllMedicineName()
        {
            var medicineName = db.MedicineName.Include(x => x.CatalogMedicines);
            return medicineName;
        }

        public IEnumerable GetAllMedicineUnit()
        {
            var medicineUnit = db.MedicineUnit;
            return medicineUnit;
        }

        public IEnumerable GetAllMedicineManufacturer()
        {
            var medicineManufacturer = db.MedicineManufacturer;
            return medicineManufacturer;
        }

        public IEnumerable GetAllMedicine()
        {
            var medicines = db.Medicine
                .Include(x => x.MedicineName)
                .ThenInclude(x => x.CatalogMedicines)
                .Include(x => x.MedicineType)
                .Include(x => x.MedicineUnit);
            return medicines;
        }

        public IEnumerable GetAllPharmacyWarehouses()
        {
            var pharmacyWarehouses = db.PharmacyWarehouses
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Manufacturer)
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineName)
                .ThenInclude(x => x.CatalogMedicines)
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineType)
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineUnit);
            return pharmacyWarehouses;
        }

        public IEnumerable GetAllReleaseMedicine()
        {
            var releaseMedicines = db.ReleaseMedicine
                .Include(x => x.Manufacturer)
                .Include(x => x.Medicine)
                .ThenInclude(x => x.MedicineName)
                .ThenInclude(x => x.CatalogMedicines)
                .Include(x => x.Medicine)
                .ThenInclude(x => x.MedicineType)
                .Include(x => x.Medicine)
                .ThenInclude(x => x.MedicineUnit);

            return releaseMedicines;
        }

        public IEnumerable GetAllOrders()
        {
            var orders = db.Order.Include(x => x.User).Include(x => x.OrderStatus);

            return orders;
        }

        public IEnumerable GetAllOrderStatus()
        {
            var orderStatus = db.OrderStatus;

            return orderStatus;
        }

        public MedicineName EditMedicineName(MedicineName medicineName)
        {
            var editMedicineName = db.MedicineName.FirstOrDefault(x => x.Id == medicineName.Id);
            if (editMedicineName != null)
            {
                editMedicineName.Name = medicineName.Name;
                editMedicineName.CatalogMedicinesId = medicineName.CatalogMedicinesId;
                db.SaveChanges();
            }

            var editedMedicineName = db.MedicineName
                .Include(x => x.CatalogMedicines)
                .FirstOrDefault(x => x.Id == editMedicineName.Id);

            return editedMedicineName;
        }

        public MedicineType EditMedicineType(MedicineType medicineType)
        {
            var editMedicineType = db.MedicineType.FirstOrDefault(x => x.Id == medicineType.Id);
            if (editMedicineType != null)
            {
                editMedicineType.Type = medicineType.Type;
                db.SaveChanges();
            }

            var editedMedicineType = db.MedicineType.FirstOrDefault(x => x.Id == editMedicineType.Id);

            return editedMedicineType;
        }

        public MedicineManufacturer EditMedicineManufacturer(MedicineManufacturer medicineManufacturer)
        {
            var editMedicineManufacturer = db.MedicineManufacturer.FirstOrDefault(x => x.Id == medicineManufacturer.Id);
            if (editMedicineManufacturer != null)
            {
                editMedicineManufacturer.Manufacturer = medicineManufacturer.Manufacturer;
                db.SaveChanges();
            }

            var editedMedicineManufacturer =
                db.MedicineManufacturer.FirstOrDefault(x => x.Id == editMedicineManufacturer.Id);

            return editedMedicineManufacturer;
        }

        public MedicineUnit EditMedicineUnit(MedicineUnit medicineUnit)
        {
            var editMedicineUnit = db.MedicineUnit.FirstOrDefault(x => x.Id == medicineUnit.Id);
            if (editMedicineUnit != null)
            {
                editMedicineUnit.Unit = medicineUnit.Unit;
                db.SaveChanges();
            }

            var editedMedicineUnit = db.MedicineUnit.FirstOrDefault(x => x.Id == editMedicineUnit.Id);

            return editedMedicineUnit;
        }

        public CatalogMedicine EditCatalogMedicine(CatalogMedicine catalogMedicine)
        {
            var editCatalogMedicine = db.CatalogMedicine.FirstOrDefault(x => x.Id == catalogMedicine.Id);
            if (editCatalogMedicine != null)
            {
                editCatalogMedicine.NameCatalogMedicine = catalogMedicine.NameCatalogMedicine;
                db.SaveChanges();
            }

            var editedCatalogMedicine = db.CatalogMedicine.FirstOrDefault(x => x.Id == editCatalogMedicine.Id);

            return editedCatalogMedicine;
        }

        public Medicine EditMedicine(Medicine medicine)
        {
            var editMedicine = db.Medicine.FirstOrDefault(x => x.Id == medicine.Id);
            if (editMedicine != null)
            {
                editMedicine.Dosage = medicine.Dosage;
                editMedicine.Volume = medicine.Volume;
                editMedicine.MedicineNameId = medicine.MedicineNameId;
                editMedicine.MedicineTypeId = medicine.MedicineTypeId;
                editMedicine.MedicineUnitId = medicine.MedicineUnitId;
                db.SaveChanges();
            }

            var editedMedicine = db.Medicine
                .Include(x => x.MedicineName)
                .ThenInclude(x => x.CatalogMedicines)
                .Include(x => x.MedicineType)
                .Include(x => x.MedicineUnit)
                .FirstOrDefault(x => x.Id == editMedicine.Id);

            return editedMedicine;
        }

        public ReleaseMedicine EditReleaseMedicine(ReleaseMedicine releaseMedicine)
        {
            var editReleaseMedicine = db.ReleaseMedicine.FirstOrDefault(x => x.Id == releaseMedicine.Id);
            if (editReleaseMedicine != null)
            {
                editReleaseMedicine.Description = releaseMedicine.Description;
                editReleaseMedicine.Image = releaseMedicine.Image;
                editReleaseMedicine.ManufacturerId = releaseMedicine.ManufacturerId;
                editReleaseMedicine.MedicineId = releaseMedicine.MedicineId;
                editReleaseMedicine.ExpirationDate = releaseMedicine.ExpirationDate;
                editReleaseMedicine.ReleaseDate = releaseMedicine.ReleaseDate;
                db.SaveChanges();
            }

            var editedMedicine = db.ReleaseMedicine
                .Include(x => x.Manufacturer)
                .Include(x => x.Medicine)
                .ThenInclude(x => x.MedicineName)
                .ThenInclude(x => x.CatalogMedicines)
                .Include(x => x.Medicine)
                .ThenInclude(x => x.MedicineType)
                .Include(x => x.Medicine)
                .ThenInclude(x => x.MedicineUnit)
                .FirstOrDefault(x => x.Id == editReleaseMedicine.Id);

            return editedMedicine;
        }

        public PharmacyWarehouse EditPharmacyWarehouse(PharmacyWarehouse pharmacyWarehouse)
        {
            var editPharmacyWarehouse = db.PharmacyWarehouses.FirstOrDefault(x => x.Id == pharmacyWarehouse.Id);
            if (editPharmacyWarehouse != null)
            {
                editPharmacyWarehouse.Price = pharmacyWarehouse.Price;
                editPharmacyWarehouse.Quantity = pharmacyWarehouse.Quantity;
                editPharmacyWarehouse.ReleaseMedicineId = pharmacyWarehouse.ReleaseMedicineId;
                editPharmacyWarehouse.IsRecipe = pharmacyWarehouse.IsRecipe;
                db.SaveChanges();
            }

            var editedPharmacyWarehouse = db.PharmacyWarehouses
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Manufacturer)
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineName)
                .ThenInclude(x => x.CatalogMedicines)
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineType)
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineUnit)
                .FirstOrDefault(x => x.Id == editPharmacyWarehouse.Id);

            return editedPharmacyWarehouse;
        }

        private async Task SendEditOrderStatusEmail(User user, string lastStatus, Order order)
        {
            EmailConfim emailService = new EmailConfim();
            await emailService.SendEmailDefault(user.Email, $"Заказ №{order.Id}",
                $"Статус вашего заказа изменился с  \"{lastStatus}\" на \"{order.OrderStatus.Status}\".");
            if (order.OrderStatusId == 2)
            {
                await emailService.SendEmailDefault(user.Email, $"Заказ №{order.Id}",
                    $"Заказ можно получить в аптеке \"BlueLife\" по адресу {order.OrderAddress.Address}. Срок хранение заказа в аптеке составляет 7 дней.");
            }
        }
        
        public Order EditOrder(Order order)
        {
            var editOrder = db.Order.Include(x => x.OrderStatus).Include(x => x.OrderAddress).FirstOrDefault(x => x.Id == order.Id);
            var lastStatus = editOrder.OrderStatus.Status;
            if (editOrder != null)
            {
                editOrder.OrderStatusId = order.OrderStatusId;
                db.SaveChanges();
            }
            
            var editedOrder = db.Order.Include(x => x.User).Include(x => x.OrderStatus)
                .FirstOrDefault(x => x.Id == editOrder.Id);
            var user = db.Users.FirstOrDefault(x => x.Id == editedOrder.UserId);
            SendEditOrderStatusEmail(user, lastStatus, editedOrder);

            return editedOrder;
        }

        public void DeleteMedicineName(MedicineName medicineName)
        {
            var deleteMedicineName = db.MedicineName.FirstOrDefault(x => x.Id == medicineName.Id);
            if (deleteMedicineName != null)
            {
                db.MedicineName.Remove(deleteMedicineName);
                db.SaveChanges();
            }
        }

        public void DeleteMedicineType(MedicineType medicineType)
        {
            var deleteMedicineType = db.MedicineType.FirstOrDefault(x => x.Id == medicineType.Id);
            if (deleteMedicineType != null)
            {
                db.MedicineType.Remove(deleteMedicineType);
                db.SaveChanges();
            }
        }

        public void DeleteMedicineManufacturer(MedicineManufacturer medicineManufacturer)
        {
            var deleteMedicineManufacturer =
                db.MedicineManufacturer.FirstOrDefault(x => x.Id == medicineManufacturer.Id);
            if (deleteMedicineManufacturer != null)
            {
                db.MedicineManufacturer.Remove(deleteMedicineManufacturer);
                db.SaveChanges();
            }
        }

        public void DeleteMedicineUnit(MedicineUnit medicineUnit)
        {
            var deleteMedicineUnit = db.MedicineUnit.FirstOrDefault(x => x.Id == medicineUnit.Id);
            if (deleteMedicineUnit != null)
            {
                db.MedicineUnit.Remove(deleteMedicineUnit);
                db.SaveChanges();
            }
        }

        public void DeleteCatalogMedicine(CatalogMedicine catalogMedicine)
        {
            var deleteCatalogMedicine = db.CatalogMedicine.FirstOrDefault(x => x.Id == catalogMedicine.Id);
            if (deleteCatalogMedicine != null)
            {
                db.CatalogMedicine.Remove(deleteCatalogMedicine);
                db.SaveChanges();
            }
        }

        public void DeleteMedicine(Medicine medicine)
        {
            var deleteMedicine = db.Medicine.FirstOrDefault(x => x.Id == medicine.Id);
            if (deleteMedicine != null)
            {
                db.Medicine.Remove(deleteMedicine);
                db.SaveChanges();
            }
        }

        public void DeleteReleaseMedicine(ReleaseMedicine releaseMedicine)
        {
            var deleteReleaseMedicine = db.ReleaseMedicine.FirstOrDefault(x => x.Id == releaseMedicine.Id);
            var deletePharmacyWarehouses =
                db.PharmacyWarehouses.Where(x => x.ReleaseMedicine.Id == deleteReleaseMedicine.Id);
            if (deleteReleaseMedicine != null)
            {
                db.PharmacyWarehouses.RemoveRange(deletePharmacyWarehouses);
                db.ReleaseMedicine.Remove(deleteReleaseMedicine);
                db.SaveChanges();
            }
        }

        public void DeletePharmacyWarehouse(PharmacyWarehouse pharmacyWarehouse)
        {
            var deletePharmacyWarehouse = db.PharmacyWarehouses.FirstOrDefault(x => x.Id == pharmacyWarehouse.Id);
            if (deletePharmacyWarehouse != null)
            {
                db.PharmacyWarehouses.Remove(deletePharmacyWarehouse);
                db.SaveChanges();
            }
        }
    }
}