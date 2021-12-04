using System.Collections.Generic;

namespace BlueLife.Models
{
    public class MedicineName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Medicine> Medicines { get; set; }
    }
}