using System.Collections.Generic;

namespace BlueLife.Models
{
    public class MedicineType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<Medicine> Medicines { get; set; }
    }
}