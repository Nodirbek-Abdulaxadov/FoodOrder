using FoodOrder.Models;
using FoodOrder.Services.Interface;
using FoodOrder.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrder.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IKategoriyaInterface _kategoriya;

        public CategoryController(IKategoriyaInterface kategoriya)
        {
            _kategoriya = kategoriya;
        }
        [HttpGet, Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            var json = await _kategoriya.GetKategoriyalar();
            return Ok(json);
        }
        [HttpGet, Route("get/{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var json = await _kategoriya.GetKategoriya(id);
            return Ok(json);
        }
        [HttpPost, Route("add")]
        public async Task<IActionResult> Add(KategoriyaViewModel kategoriya)
        {
            var json = await _kategoriya.AddKategoriya((Kategoriya)kategoriya);
            return Ok(json);
        }
        [HttpPut, Route("update")]
        public async Task<IActionResult> Update(Kategoriya kategoriya)
        {
            var json = await _kategoriya.UpdateKategoriya(kategoriya);
            return Ok(json);
        }
        [HttpDelete, Route("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _kategoriya.DeleteKategoriya(id);
            return Ok();
        }
    }
}
