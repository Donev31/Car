using Car.BL.Interfaces;
using Car.Models;
using Car.Users.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Car.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("GetBrandById")]

        public Brand GetBrandById(int id)
        {
            return _brandService.GetById(id);
        }

        [HttpGet("GetAllBrands")]

        public List<Brand> GetAllBrands()
        {
            return _brandService.GetAll();
        }

        [HttpPost]

        public void Add([FromBody] Brand brand)
        {
            _brandService.Add(brand);
        }

        [HttpDelete]

        public void Delete(int id)
        {
            _brandService.Remove(id);
        }


    }
}