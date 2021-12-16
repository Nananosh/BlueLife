using System;
using System.Collections.Generic;

namespace BlueLife.Models
{
    public class Medicine
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
        public List<ReleaseMedicine> ReleaseMedicines { get; set; }
    }
}