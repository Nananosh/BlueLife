using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueLife.Models
{
    public class MedicineName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CatalogMedicine CatalogMedicines { get; set; }
        public int CatalogMedicinesId { get; set; }
        [JsonIgnore]
        public List<Medicine> Medicines { get; set; }
    }
}