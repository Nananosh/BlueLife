using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlueLife.Models
{
    public class MedicineType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        [JsonIgnore]
        public List<Medicine> Medicines { get; set; }
    }
}