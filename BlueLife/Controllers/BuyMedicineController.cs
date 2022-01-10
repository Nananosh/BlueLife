using System.Collections.Generic;
using System.Data.Common;
using AutoMapper;
using BlueLife.Business.Interfaces;
using BlueLife.Migrations;
using BlueLife.Models;
using BlueLife.ViewModels.Admin;
using BlueLife.ViewModels.BuyMedicine;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlueLife.Controllers
{
    public class BuyMedicineController : Controller
    {
        private readonly IBuyMedicineService buyMedicineService;
        private readonly IMapper mapper;

        public BuyMedicineController(ApplicationContext db, IBuyMedicineService buyMedicineService, IMapper mapper)
        {
            this.buyMedicineService = buyMedicineService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var medicines = buyMedicineService.GetAllPharmacyWarehouse();
            return View(mapper.Map<List<PharmacyWarehouseViewModel>>(medicines));
        }

        public IActionResult Medicine(int id)
        {
            var medicine = buyMedicineService.GetPharmacyWarehouseById(id);
            return View(mapper.Map<PharmacyWarehouseViewModel>(medicine));
        }

        public IActionResult AddMedicineToBasket(BasketMedicineViewModel basketMedicineViewModel)
        {
            buyMedicineService.AddMedicineToBasket(basketMedicineViewModel);
            return RedirectToAction("Medicine", "BuyMedicine",
                new {id = basketMedicineViewModel.MedicineInPharmacyWarehouseId});
        }

        public IActionResult Basket(string id)
        {
            var basket = buyMedicineService.GetUserBasket(id);
            return View(basket);
        }

        public IActionResult AddBasketToOrder(string userId)
        {
            buyMedicineService.AddBasketToOrder(userId);
            return RedirectToAction("Basket", new {id = userId});
        }
        
        public IActionResult Order(int id)
        {
            var order = buyMedicineService.GetOrderById(id);
            return View(order);
        }

        public IActionResult Orders(string id)
        {
            var orders = buyMedicineService.GetAllOrdersByUserId(id);
            return View(orders);
        }

        public IActionResult DeleteMedicineInBasket(int id, string userId)
        {
            buyMedicineService.DeleteMedicineInBasket(id, userId);
            return RedirectToAction("Basket", "BuyMedicine", new {id = userId});
        }
    }
}