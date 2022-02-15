﻿using System;
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
        private readonly UserManager<User> userManager;

        public SeedDatabaseService(ApplicationContext db, RoleManager<IdentityRole> roleManager,
            UserManager<User> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.db = db;
        }

        public async Task CreateStartAdmin()
        {
            if (db.Users.Any(x => x.UserName == "Admin"))
            {
                Console.WriteLine("Админ уже есть");
            }
            else
            {
                var user = new User
                {
                    Email = "admin@bluelife.com", UserName = "Admin",
                    UserImage = "https://img.icons8.com/material-outlined/200/000000/user--v1.png"
                };

                await userManager.CreateAsync(user, "123Snp-");
                await db.SaveChangesAsync();
                await userManager.AddToRoleAsync(user, "Admin");
                Console.WriteLine("Админ создан");
            }
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

        public async Task CreateStartAddress()
        {
            if (db.OrderAddresses.Any(x => x.Address == "ул Колесникова, 3"))
            {
                Console.WriteLine("ул Колесникова, 3 есть");
            }
            else
            {
                await db.OrderAddresses.AddAsync(new OrderAddress {Address = "ул Колесникова, 3"});
                await db.SaveChangesAsync();
                Console.WriteLine("ул Колесникова, 3 создана");
            }

            if (db.OrderAddresses.Any(x => x.Address == "ул Глебки, 10"))
            {
                Console.WriteLine("ул Глебки, 10 есть");
            }
            else
            {
                await db.OrderAddresses.AddAsync(new OrderAddress {Address = "ул Глебки, 10"});
                await db.SaveChangesAsync();
                Console.WriteLine("ул Глебки, 10 создана");
            }

            if (db.OrderAddresses.Any(x => x.Address == "ул Янки Купалы, 20"))
            {
                Console.WriteLine("ул Янки Купалы, 20 есть");
            }
            else
            {
                await db.OrderAddresses.AddAsync(new OrderAddress {Address = "ул Янки Купалы, 20"});
                await db.SaveChangesAsync();
                Console.WriteLine("ул Янки Купалы, 20 создана");
            }
        }
    }
}