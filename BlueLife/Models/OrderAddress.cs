using System.Collections.Generic;

namespace BlueLife.Models
{
    public class OrderAddress
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }
    }
}