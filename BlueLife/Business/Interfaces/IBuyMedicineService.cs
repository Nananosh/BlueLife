using System.Collections.Generic;
using BlueLife.Models;
using BlueLife.ViewModels.BuyMedicine;
using Microsoft.AspNetCore.Mvc;

namespace BlueLife.Business.Interfaces
{
    public interface IBuyMedicineService
    {
        public List<PharmacyWarehouse> GetAllPharmacyWarehouse();
        public PharmacyWarehouse GetPharmacyWarehouseById(int id);
        public void AddMedicineToBasket(BasketMedicineViewModel basketMedicineViewModel);
        public List<BasketMedicine> GetUserBasket(string id);
        public void AddBasketToOrder(string userId);
        public List<Order> GetAllOrdersByUserId(string id);
        public List<OrderMedicine> GetOrderById(int id);
        public void DeleteMedicineInBasket(int id, string userId);
    }
}