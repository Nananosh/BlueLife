using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueLife.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        [JsonIgnore]
        public List<Order> Orders { get; set; }
    }
}