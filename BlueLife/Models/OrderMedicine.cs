namespace BlueLife.Models
{
    public class OrderMedicine
    {
        public int Id { get; set; }
        public Order Basket { get; set; }
        public Medicine Medicine { get; set; }
        public int Quantity { get; set; }
    }
}