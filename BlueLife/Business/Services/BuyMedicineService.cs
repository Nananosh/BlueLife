using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                .ThenInclude(x => x.MedicineUnit).Where(x => x.Quantity != 0).ToList();

            return pharmacyWarehouse;
        }

        public List<PharmacyWarehouse> GetAllPharmacyWarehouseByMedicineType(string medicineType)
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
                .Where(x => x.ReleaseMedicine.Medicine.MedicineType.Type == medicineType).Where(x => x.Quantity != 0).ToList();

            return pharmacyWarehouse;
        }

        public List<PharmacyWarehouse> GetAllPharmacyWarehouseOrderDescendingByMedicineName()
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
                .OrderBy(x => x.ReleaseMedicine.Medicine.MedicineName.Name)
                .Where(x => x.Quantity != 0)
                .ToList();

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
            if (db.BasketMedicine.Any(x => x.PharmacyWarehouse.Id == medicine.Id))
            {
                var basket =
                    db.BasketMedicine.FirstOrDefault(x => x.Basket == userBasket && x.PharmacyWarehouse == medicine);
                basket.Quantity += basketMedicineViewModel.Quantity;
                db.SaveChanges();
            }
            else
            {
                db.BasketMedicine.Add(new BasketMedicine
                {
                    Basket = userBasket,
                    PharmacyWarehouse = medicine,
                    Quantity = basketMedicineViewModel.Quantity
                });
                db.SaveChanges();
            }
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

        public int GetTotalAmountByUserId(string userId)
        {
            var totalAmount = db.BasketMedicine.Where(x => x.Basket.User.Id == userId)
                .Sum(x => x.Quantity * x.PharmacyWarehouse.Price);
            var totalAmountByUserDiscount = GetFullPriceByDiscountUser(userId, totalAmount);
            return totalAmountByUserDiscount;
        }

        private async Task SendBuyEmail(User user, Order order)
        {
            EmailConfim emailService = new EmailConfim();
            await emailService.SendEmailDefault(user.Email, $"Заказ №{order.Id}",
                $"Спасибо за предзаказ! Ваш заказ находится в статусе \"{order.OrderStatus.Status}\".");
        }

        private int AddOrder(string userId, int addressId)
        {
            var user = db.Users.FirstOrDefault(x => x.Id == userId);
            var order = new Order
            {
                UserId = userId,
                OrderDate = DateTime.Now,
                Description = "Спасибо что выбрали нашу аптеку",
                OrderStatusId = 1,
                OrderAddressId = addressId,
                TotalAmount = GetTotalAmountByUserId(userId)
            };
            db.Order.Add(order);
            db.SaveChanges();
            AddDiscountUser(userId);
            var addedOrder = db.Order.Include(x => x.OrderStatus).FirstOrDefault(x => x.Id == order.Id);
            SendBuyEmail(user, addedOrder);
            return order.Id;
        }

        public void AddBasketToOrder(string userId, int addressId)
        {
            var basket = db.BasketMedicine
                .Include(x => x.PharmacyWarehouse)
                .Where(x => x.Basket.User.Id == userId).ToList();
            var orderId = AddOrder(userId, addressId);
            foreach (var basketMedicine in basket)
            {
                db.OrderMedicine.Add(new OrderMedicine
                {
                    PharmacyWarehouseId = basketMedicine.PharmacyWarehouse.Id,
                    OrderId = orderId,
                    Quantity = basketMedicine.Quantity
                });

                basketMedicine.PharmacyWarehouse.Quantity -= basketMedicine.Quantity;
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
                .Include(x => x.Order)
                .ThenInclude(x => x.OrderAddress)
                .Where(x => x.Order.Id == id).ToList();
            return order;
        }

        public void DeleteMedicineInBasket(int id, string userId)
        {
            var basket = db.Baskets.FirstOrDefault(x => x.User.Id == userId);
            var medicine =
                db.BasketMedicine.FirstOrDefault(x => x.PharmacyWarehouse.Id == id && x.Basket.User.Id == userId);
            if (medicine != null) db.BasketMedicine.Remove(medicine);
            db.SaveChanges();
        }

        public List<OrderAddress> GetAllOrderAddress()
        {
            var addresses = db.OrderAddresses.ToList();

            return addresses;
        }

        private void AddDiscountUser(string userId)
        {
            var user = db.Users.FirstOrDefault(x => x.Id == userId);
            if (user != null) user.Discount += 1;
            db.SaveChanges();
        }

        private int GetFullPriceByDiscountUser(string userId, int fullPrice)
        {
            var user = db.Users.FirstOrDefault(x => x.Id == userId);
            return fullPrice - (fullPrice * user.Discount / 100);
        }
    }
}