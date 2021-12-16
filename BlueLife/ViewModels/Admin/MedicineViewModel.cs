using BlueLife.Models;
using Newtonsoft.Json;

namespace BlueLife.ViewModels.Admin
{
    public class MedicineViewModel
    {
        public int Id { get; set; }
        public MedicineName MedicineName { get; set; }
        public int MedicineNameId { get; set; }
        public MedicineType MedicineType { get; set; }
        public int MedicineTypeId { get; set; }
        public MedicineUnit MedicineUnit { get; set; }
        public int MedicineUnitId { get; set; }
        public int Volume { get; set; }
        public double Dosage { get; set; }
        public string FullMedicine => $"{MedicineName.Name}, {MedicineName.CatalogMedicines.NameCatalogMedicine}, {MedicineType.Type}, {Volume} {MedicineUnit.Unit}, {Dosage} мг";
    }
}