using System.Collections.Generic;

namespace BlueLife.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public User User { get; set; }
        
        public List<BasketMedicine> Medicines { get; set; }
    }
}