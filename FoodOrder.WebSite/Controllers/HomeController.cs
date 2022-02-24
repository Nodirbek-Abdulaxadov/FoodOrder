using FoodOrder.Services.Interface;
using FoodOrder.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodOrder.WebSite.Controllers
{
    public class HomeController : Controller
    {
        public readonly IKategoriyaInterface _kategoriyaInterface;

        private readonly IMahsulotInterface _mahsulotInterface;

        public HomeController(IKategoriyaInterface kategoriyaInterface,
                              IMahsulotInterface mahsulotInterface)
        {
            _kategoriyaInterface = kategoriyaInterface;
            _mahsulotInterface = mahsulotInterface;
        }
        public async Task<IActionResult> Index()
        {
            List<KategoriyaViewModel> viewList1 = new List<KategoriyaViewModel>();
            List<MahsulotViewModel> viewList2 = new List<MahsulotViewModel>();

            var list1 = await _kategoriyaInterface.GetKategoriyalar();
            foreach (var item in list1)
            {
                viewList1.Add((KategoriyaViewModel)item);
            }
            var list2 = await _mahsulotInterface.GetMahsulotlar();
            foreach (var item in list2)
            {
                viewList2.Add((MahsulotViewModel)item);
            }

            IndexViewModel viewModel = new IndexViewModel()
            {
                Kategoriyalar = viewList1,
                Mahsulotlar = viewList2           
            };
            return View("Index", viewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Book()
        {
            return View();
        }

        public async Task<IActionResult> Menu()
        {
            List<KategoriyaViewModel> viewList1 = new List<KategoriyaViewModel>();
            List<MahsulotViewModel> viewList2 = new List<MahsulotViewModel>();

            var list1 = await _kategoriyaInterface.GetKategoriyalar();
            foreach (var item in list1)
            {
                viewList1.Add((KategoriyaViewModel)item);
            }
            var list2 = await _mahsulotInterface.GetMahsulotlar();
            foreach (var item in list2)
            {
                viewList2.Add((MahsulotViewModel)item);
            }

            IndexViewModel viewModel = new IndexViewModel()
            {
                Kategoriyalar = viewList1,
                Mahsulotlar = viewList2
            };
            return View("Menu", viewModel);
        }
    }
}
