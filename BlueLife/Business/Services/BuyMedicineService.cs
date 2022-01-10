using System;
using System.Collections.Generic;
using System.Linq;
using BlueLife.Business.Interfaces;
using BlueLife.Migrations;
using BlueLife.Models;
using BlueLife.ViewModels.BuyMedicine;
using Microsoft.EntityFrameworkCore;

namespace BlueLife.Business.Services
{
    public class BuyMedicineService : IBuyMedicineService
    {
        private readonly ApplicationContext db;

        public BuyMedicineService(ApplicationContext db)
        {
            this.db = db;
        }

        public List<PharmacyWarehouse> GetAllPharmacyWarehouse()
        {
            var pharmacyWarehouse = db.PharmacyWarehouses
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Manufacturer)
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineName)
                .ThenInclude(x => x.CatalogMedicines)
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineType)
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineUnit).ToList();

            return pharmacyWarehouse;
        }

        public PharmacyWarehouse GetPharmacyWarehouseById(int id)
        {
            var pharmacyWarehouse = db.PharmacyWarehouses
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Manufacturer)
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineName)
                .ThenInclude(x => x.CatalogMedicines)
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineType)
                .Include(x => x.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineUnit)
                .FirstOrDefault(x => x.Id == id);

            return pharmacyWarehouse;
        }

        public void AddMedicineToBasket(BasketMedicineViewModel basketMedicineViewModel)
        {
            var userBasket = db.Baskets.FirstOrDefault(x => x.User.Id == basketMedicineViewModel.UserId);
            var medicine =
                db.PharmacyWarehouses.FirstOrDefault(x =>
                    x.Id == basketMedicineViewModel.MedicineInPharmacyWarehouseId);
            db.BasketMedicine.Add(new BasketMedicine
            {
                Basket = userBasket,
                PharmacyWarehouse = medicine,
                Quantity = basketMedicineViewModel.Quantity
            });
            db.SaveChanges();
        }

        public List<BasketMedicine> GetUserBasket(string id)
        {
            var basket = db.Baskets.FirstOrDefault(u => u.User.Id == id);
            var userBasket = db.BasketMedicine.Where(x => x.Basket == basket)
                .Include(x => x.PharmacyWarehouse)
                .Include(x => x.PharmacyWarehouse.ReleaseMedicine)
                .ThenInclude(x => x.Manufacturer)
                .Include(x => x.PharmacyWarehouse.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineName)
                .ThenInclude(x => x.CatalogMedicines)
                .Include(x => x.PharmacyWarehouse.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineType)
                .Include(x => x.PharmacyWarehouse.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineUnit).ToList();
            return userBasket;
        }

        private int GetTotalAmountByUserId(string userId)
        {
            var totalAmount = db.BasketMedicine.Where(x => x.Basket.User.Id == userId)
                .Sum(x => x.Quantity * x.PharmacyWarehouse.Price);
            return totalAmount;
        }

        private int AddOrder(string userId)
        {
            var order = new Order
            {
                UserId = userId,
                OrderDate = DateTime.Now,
                Description = "Спасибо что выбрали нашу аптеку",
                OrderStatusId = 1,
                TotalAmount = GetTotalAmountByUserId(userId)
            };
            db.Order.Add(order);
            db.SaveChanges();
            return order.Id;
        }

        public void AddBasketToOrder(string userId)
        {
            var basket = db.BasketMedicine
                .Include(x => x.PharmacyWarehouse)
                .Where(x => x.Basket.User.Id == userId).ToList();
            var orderId = AddOrder(userId);
            foreach (var basketMedicine in basket)
            {
                db.OrderMedicine.Add(new OrderMedicine
                {
                    PharmacyWarehouseId = basketMedicine.PharmacyWarehouse.Id,
                    OrderId = orderId,
                    Quantity = basketMedicine.Quantity
                });
            }

            db.RemoveRange(basket);
            db.SaveChanges();
        }

        public List<Order> GetAllOrdersByUserId(string id)
        {
            var orders = db.Order.Include(x => x.OrderStatus).Where(x => x.User.Id == id).ToList();
            return orders;
        }

        public List<OrderMedicine> GetOrderById(int id)
        {
            var order = db.OrderMedicine
                .Include(x => x.PharmacyWarehouse)
                .Include(x => x.PharmacyWarehouse.ReleaseMedicine)
                .ThenInclude(x => x.Manufacturer)
                .Include(x => x.PharmacyWarehouse.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineName)
                .ThenInclude(x => x.CatalogMedicines)
                .Include(x => x.PharmacyWarehouse.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineType)
                .Include(x => x.PharmacyWarehouse.ReleaseMedicine)
                .ThenInclude(x => x.Medicine)
                .ThenInclude(x => x.MedicineUnit)
                .Where(x => x.Order.Id == id).ToList();
            return order;
        }

        public void DeleteMedicineInBasket(int id, string userId)
        {
            var basket = db.Baskets.FirstOrDefault(x => x.User.Id == userId);
            var medicine = db.BasketMedicine.FirstOrDefault(x => x.PharmacyWarehouse.Id == id && x.Basket.User.Id == userId);
            if (medicine != null) db.BasketMedicine.Remove(medicine);
            db.SaveChanges();
        }
    }
}