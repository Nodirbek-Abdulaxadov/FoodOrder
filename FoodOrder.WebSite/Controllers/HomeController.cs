using FoodOrder.Services.Interface;
using FoodOrder.ViewModels;
using FoodOrder.WebSite.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrder.WebSite.Controllers
{
    public class HomeController : Controller
    {
        public readonly IKategoriyaInterface _kategoriyaInterface;

        private readonly IMahsulotInterface _mahsulotInterface;
        private readonly UserManager<FoodOrderWebSiteUser> _userManager;

        public HomeController(IKategoriyaInterface kategoriyaInterface,
                              IMahsulotInterface mahsulotInterface,
                              UserManager<FoodOrderWebSiteUser> userManager)
        {
            _kategoriyaInterface = kategoriyaInterface;
            _mahsulotInterface = mahsulotInterface;
            _userManager = userManager;
        }

        //[Authorize]
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

        [HttpGet]
        public IActionResult Korzinka()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddKorzinka(Guid Id)
        {
            Add(Id).Wait();
            return RedirectToAction("Index");
        }


        public async Task Add(Guid Id)
        {
            var user = await _userManager.GetUserAsync(User);
            var mahsulotList = await _mahsulotInterface.GetMahsulotlar();
            var mahsulot = mahsulotList.FirstOrDefault(m => m.Id == Id);
            user.Korzinka.Add(mahsulot);
            int a = 4;
        }
    }
}
