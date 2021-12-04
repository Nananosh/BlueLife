using System.Collections.Generic;

namespace BlueLife.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public List<Order> Orders { get; set; }
    }
}