﻿namespace BlueLife.Models
{
    public class OrderMedicine
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public PharmacyWarehouse PharmacyWarehouse { get; set; }
        public int PharmacyWarehouseId { get; set; }
        public int Quantity { get; set; }
    }
}