using BlueLife.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlueLife.Migrations
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        

        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketMedicine> BasketMedicine { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<MedicineManufacturer> MedicineManufacturer { get; set; }
        public DbSet<MedicineName> MedicineName { get; set; }
        public DbSet<MedicineType> MedicineType { get; set; }
        public DbSet<MedicineUnit> MedicineUnit { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderMedicine> OrderMedicine { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<PharmacyWarehouse> PharmacyWarehouses { get; set; }
        public DbSet<CatalogMedicine> CatalogMedicine { get; set; }
        public DbSet<ReleaseMedicine> ReleaseMedicine { get; set; }
        
    }
}