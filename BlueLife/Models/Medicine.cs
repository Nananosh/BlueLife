using System;
using System.Collections.Generic;

namespace BlueLife.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public MedicineName MedicineName { get; set; }
        public MedicineType MedicineType { get; set; }
        public MedicineManufacturer MedicineManufacturer { get; set; }
        public MedicineUnit MedicineUnit { get; set; }
        public int Volume { get; set; }
        public double Dosage { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime ExpirationDate { get; set; } 
        public int Price { get; set; }
        public int Quantity { get; set; }
        
        public List<BasketMedicine> Baskets { get; set; }
        public List<OrderMedicine> Orders { get; set; }
    }
}