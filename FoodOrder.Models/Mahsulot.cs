using System;

namespace FoodOrder.Models
{
    public class Mahsulot
    {
        public Guid Id { get; set; }
        public string Nomi { get; set; }
        public string Batafsil { get; set; }
        public double Narxi { get; set; }
        public string Rasmi { get; set; }
        public Guid KategoriyaId { get; set; }
        public Guid UserId { get; set; }
    }
}
