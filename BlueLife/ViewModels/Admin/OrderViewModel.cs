using System;
using BlueLife.Models;

namespace BlueLife.ViewModels.Admin
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Description { get; set; }
        public int TotalAmount { get; set; } 
        public OrderStatus OrderStatus { get; set; }
        public int OrderStatusId { get; set; }
    }
}