using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.ViewModels
{
    public class IndexViewModel
    {
        public List<KategoriyaViewModel> Kategoriyalar { get; set; }
        public List<MahsulotViewModel> Mahsulotlar { get; set; }
    }
}
