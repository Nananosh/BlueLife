using System;
using System.Collections.Generic;

namespace BlueLife.Models
{
    public class ReleaseMedicine
    {
        public int Id { get; set; }
        public Medicine Medicine { get; set; }
        public int MedicineId { get; set; }
        public MedicineManufacturer Manufacturer { get; set; }
        public int ManufacturerId { get; set; }
        public List<PharmacyWarehouse> PharmacyWarehouses { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}