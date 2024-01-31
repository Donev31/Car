using Car.BL.Interfaces;
using Car.Models.Models.Requests;
using Car.Models.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.BL.Services
{
    public class DealerService : IDealerService
    {
        private readonly IBrandService _brandService;
        private readonly IModelService _modelService;
        public DealerService(IBrandService brandService, IModelService modelService)
        {
            _brandService = brandService;
            _modelService = modelService;
        }

        public GetModelsByBrandResponses? GetModelsByBrand(GetModelByBrandRequest request)
        {
            var models = _modelService.GetAllByBrandId(request.Id);

            if (models.Count > 0)
            {
                var response = new GetModelsByBrandResponses()
                {
                    Brand = _brandService.GetById(request.Id),
                    Model = models.Where(b => b.ReleaseDate >= request.AfterDate).ToList()

                };

                return response;

            }

            return null;
        }

    }
}