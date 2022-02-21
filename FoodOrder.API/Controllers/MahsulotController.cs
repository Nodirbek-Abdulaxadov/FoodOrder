using FoodOrder.Models;
using FoodOrder.Services.Interface;
using FoodOrder.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace FoodOrder.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahsulotController : ControllerBase
    {
        private readonly IMahsulotInterface _Mahsulot;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public MahsulotController(IMahsulotInterface Mahsulot,
                                    IWebHostEnvironment webHostEnvironment)
        {
            _Mahsulot = Mahsulot;
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpGet, Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            var json = await _Mahsulot.GetMahsulotlar();
            return Ok(json);
        }
        [HttpGet, Route("get/{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var json = await _Mahsulot.GetMahsulot(id);
            return Ok(json);
        }
        [HttpPost, Route("add")]
        public async Task<IActionResult> Add(MahsulotViewModel mahsulot)
        {
            //string uniqueName = string.Empty;
            //using (var memory = new MemoryStream(mahsulot.Rasmi))
            //{
            //    if (mahsulot.Rasmi != null)
            //    {
            //        string uplodFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
            //        uniqueName = Guid.NewGuid().ToString() + ".jpg";
            //        string filePath = Path.Combine(uplodFolder, uniqueName);
            //        FileStream fileStream = new FileStream(filePath, FileMode.Create);
            //        memory.CopyTo(fileStream);
            //        fileStream.Close();
            //    }
            //}

            //Mahsulot mahsulot1 = (Mahsulot)mahsulot;
            //mahsulot1.Rasmi = uniqueName;

            var json = await _Mahsulot.AddMahsulot((Mahsulot)mahsulot);
            return Ok(json);
        }
        [HttpPut, Route("update")]
        public async Task<IActionResult> Update(MahsulotViewModel mahsulot)
        {
            var json = await _Mahsulot.UpdateMahsulot((Mahsulot)mahsulot);
            return Ok(json);
        }
        [HttpDelete, Route("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _Mahsulot.DeleteMahsulot(id);
            return Ok();
        }
    }
}