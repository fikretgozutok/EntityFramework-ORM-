using Microsoft.AspNetCore.Mvc;
using Business;
using DataAccess;
using Entity;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private ICategoryService _service;

        public CategoryController()
        {
            _service = new CategoryManager();
        }
        [HttpPost("add")]
        public IActionResult Add(Category entity)
        {
            _service.Add(entity);
            return Ok("veri eklemesi başarılı");
        }

        [HttpPost("delete")]
        public IActionResult Delete(Category entity)
        {
            _service.Delete(entity);
            return Ok("veri silindi");
        }

        [HttpPost("update")]
        public IActionResult Update(Category entity)
        {
            _service.Update(entity);
            return Ok("güncelleme başarılı");
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            return Ok(_service.Get(id));
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }
    }
}
