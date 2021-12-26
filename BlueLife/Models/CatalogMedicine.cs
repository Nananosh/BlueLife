using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueLife.Models
{
    public class CatalogMedicine
    {
        public int Id { get; set; }
        public string NameCatalogMedicine { get; set; }
        [JsonIgnore]
        public List<MedicineName> MedicineNames { get; set; }
    }
}