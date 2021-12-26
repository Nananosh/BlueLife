using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueLife.Models
{
    public class MedicineUnit
    {
        public int Id { get; set; }
        public string Unit { get; set; }
        [JsonIgnore]
        public List<Medicine> Medicines { get; set; }
    }
}