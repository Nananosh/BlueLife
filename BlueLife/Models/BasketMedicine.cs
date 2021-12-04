﻿using Microsoft.EntityFrameworkCore;

namespace BlueLife.Models
{
    public class BasketMedicine
    {
        public int Id { get; set; }
        public Basket Basket { get; set; }
        public Medicine Medicine { get; set; }
        public int Quantity { get; set; }
    }
}