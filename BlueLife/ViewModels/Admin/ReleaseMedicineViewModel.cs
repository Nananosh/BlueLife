using System;
using BlueLife.Models;

namespace BlueLife.ViewModels.Admin
{
    public class ReleaseMedicineViewModel
    {
        public int Id { get; set; }
        public MedicineViewModel Medicine { get; set; }
        public int MedicineId { get; set; }
        public MedicineManufacturer Manufacturer { get; set; }
        public int ManufacturerId { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string FullReleaseMedicine => $"{Medicine.MedicineName.Name}, {Medicine.MedicineName.CatalogMedicines.NameCatalogMedicine}, {Medicine.MedicineType.Type}, {Medicine.Volume} {Medicine.MedicineUnit.Unit}, {Medicine.Dosage} мг, {Manufacturer.Manufacturer}";
    }
}