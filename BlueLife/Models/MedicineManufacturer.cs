using System.Collections.Generic;

namespace BlueLife.Models
{
    public class MedicineManufacturer
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public List<Medicine> Medicines { get; set; }
    }
}