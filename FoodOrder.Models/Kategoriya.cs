using System;
using System.Collections.Generic;

namespace FoodOrder.Models
{
    public class Kategoriya
    {
        public Guid Id { get; set; }
        public string Nomi { get; set; }
        public List<Mahsulot> Mahsulotlar { get; set; }
    }
}
