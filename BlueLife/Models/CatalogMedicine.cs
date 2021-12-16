using System.Collections.Generic;

namespace BlueLife.Models
{
    public class CatalogMedicine
    {
        public int Id { get; set; }
        public string NameCatalogMedicine { get; set; }
        public List<MedicineName> MedicineNames { get; set; }
    }
}