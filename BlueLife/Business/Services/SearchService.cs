using System.Collections.Generic;
using System.Linq;
using BlueLife.Business.Interfaces;
using BlueLife.Migrations;
using BlueLife.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueLife.Business.Services
{
    public class SearchService : ISearchService
    {
        private readonly ApplicationContext db;

        public SearchService(ApplicationContext db)
        {
            this.db = db;
        }

        public List<PharmacyWarehouse> SearchMedicineByQuery(string query)
        {
            var medicines = db.PharmacyWarehouses.Where(x =>
                EF.Functions.Like(x.ReleaseMedicine.Medicine.MedicineName.Name, $"%{query}%")).Include(x => x.ReleaseMedicine)
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
                .ThenInclude(x => x.MedicineUnit).ToList();;
            return medicines;
        }
    }
}