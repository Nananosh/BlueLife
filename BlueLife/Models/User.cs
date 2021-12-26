using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace BlueLife.Models
{
    public class User : IdentityUser
    {
        public string UserImage { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public int Discount { get; set; }
    }
}