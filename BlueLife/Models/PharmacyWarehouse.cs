using System.Collections.Generic;

namespace BlueLife.Models
{
    public class PharmacyWarehouse
    {
        public int Id { get; set; }
        public ReleaseMedicine ReleaseMedicine { get; set; }
        public int ReleaseMedicineId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public bool IsRecipe { get; set; }
        public List<BasketMedicine> Baskets { get; set; }
        public List<OrderMedicine> Orders { get; set; }
    }
}