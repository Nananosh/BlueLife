using System;
using System.Collections.Generic;

namespace BlueLife.Models
{
    public class MedicineUnit
    {
        public int Id { get; set; }
        public string Unit { get; set; }
        public List<Medicine> Medicines { get; set; }
    }
}