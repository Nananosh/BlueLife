using System.Collections.Generic;
using BlueLife.Models;

namespace BlueLife.Business.Interfaces
{
    public interface ISearchService
    {
        public List<PharmacyWarehouse> SearchMedicineByQuery(string query);
    }
}