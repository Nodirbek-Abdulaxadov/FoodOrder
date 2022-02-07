using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FISH { get; set; }
        public string Nomer { get; set; }
        public string Manzil { get; set; }
        public List<Mahsulot> Savatcha { get; set; }
    }
}
