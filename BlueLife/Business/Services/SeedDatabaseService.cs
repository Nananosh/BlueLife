using System;
using System.Linq;
using System.Threading.Tasks;
using BlueLife.Business.Interfaces;
using BlueLife.Migrations;
using BlueLife.Models;
using Microsoft.AspNetCore.Identity;

namespace BlueLife.Business.Services
{
    public class SeedDatabaseService : ISeedDatabaseService
    {
        private readonly ApplicationContext db;
        private readonly RoleManager<IdentityRole> roleManager;

        public SeedDatabaseService(ApplicationContext db, RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
            this.db = db;
        }

        public void CreateStartOrderStatus()
        {
            if (db.OrderStatus.Any(x => x.Status == "Ждёт обработки"))
            {
                Console.WriteLine("Статус ждёт обработки есть");
            }
            else
            {
                db.OrderStatus.Add(new OrderStatus
                {
                    Status = "Ждёт обработки"
                });
                db.SaveChanges();
            }

            if (db.OrderStatus.Any(x => x.Status == "Оформлен"))
            {
                Console.WriteLine("Статус оформлен есть");
            }
            else
            {
                db.OrderStatus.Add(new OrderStatus
                {
                    Status = "Оформлен"
                });
                db.SaveChanges();
                Console.WriteLine("Статус оформлен создан");
            }

            if (db.OrderStatus.Any(x => x.Status == "Выдан"))
            {
                Console.WriteLine("Статус выдан есть");
            }
            else
            {
                db.OrderStatus.Add(new OrderStatus
                {
                    Status = "Выдан"
                });
                db.SaveChanges();
                Console.WriteLine("Статус выдан создан");
            }
        }

        public async Task CreateStartRole()
        {
            if (db.Roles.Any(x => x.Name == "Admin"))
            {
                Console.WriteLine("Роль админа есть");
            }
            else
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
                Console.WriteLine("Роль админа создана");
            }
        }
    }
}