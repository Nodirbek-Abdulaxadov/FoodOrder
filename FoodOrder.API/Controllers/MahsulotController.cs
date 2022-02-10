using FoodOrder.Models;
using FoodOrder.Services.Interface;
using FoodOrder.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FoodOrder.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahsulotController : ControllerBase
    {
        private readonly IMahsulotInterface _Mahsulot;

        public MahsulotController(IMahsulotInterface Mahsulot)
        {
            _Mahsulot = Mahsulot;
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