using BlueLife.Models;

namespace BlueLife.ViewModels.Admin
{
    public class MedicineNameViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CatalogMedicine CatalogMedicine { get; set; }
        public int CatalogMedicinesId { get; set; }
        public string FullName => $"{Name}, {CatalogMedicine.NameCatalogMedicine}";
    }
}