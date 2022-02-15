using System;
using System.Collections.Generic;

namespace BlueLife.Models
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Description { get; set; }
        public int TotalAmount { get; set; } 
        public OrderStatus OrderStatus { get; set; }
        public int OrderStatusId { get; set; }
        public OrderAddress OrderAddress { get; set; }
        public int OrderAddressId { get; set; }
        public List<OrderMedicine> Medicines { get; set; }
    }
}