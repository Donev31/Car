using Car.BL.Interfaces;
using Car.BL.Services;
using Car.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Car.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : Controller
    {
        private readonly IModelService _modelService;
        public ModelController(IModelService modelService)
        {
            _modelService = modelService;
        }

        [HttpGet("GetModelById")]

        public Model GetModelById(int id)
        {
            return _modelService.GetById(id);
        }

        [HttpGet("GetAllModels")]

        public List<Model> GetAllModels()
        {
            return _modelService.GetAll();
        }

        [HttpPost]

        public void Add([FromBody] Model model)
        {

            _modelService.Add(model);
        }

        [HttpDelete]

        public void Delete(int id)
        {
            _modelService.Remove(id);
        }


    }
}
