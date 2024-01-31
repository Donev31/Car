using Car.BL.Interfaces;
using Car.BL.Services;
using Car.Models.Models.Requests;
using Car.Models.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Car.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealerController : Controller
    {
        private readonly IDealerService _dealerService;

        public DealerController(IDealerService dealerService)
        {
            _dealerService = dealerService;
        }

        [HttpPost("GetModelsByBrand")]
        public GetModelsByBrandResponses? GetModelsByBrand(GetModelByBrandRequest request)
        {
            return _dealerService.GetModelsByBrand(request);
        }



    }
}
