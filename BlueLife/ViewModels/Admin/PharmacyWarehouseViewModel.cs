using BlueLife.Models;

namespace BlueLife.ViewModels.Admin
{
    public class PharmacyWarehouseViewModel
    {
        public int Id { get; set; }
        public ReleaseMedicineViewModel ReleaseMedicine { get; set; }
        public int ReleaseMedicineId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public bool IsRecipe { get; set; }
    }
}