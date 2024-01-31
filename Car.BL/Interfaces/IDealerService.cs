using Car.Models.Models.Requests;
using Car.Models.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.BL.Interfaces
{
    public interface IDealerService
    {
        public GetModelsByBrandResponses? GetModelsByBrand(GetModelByBrandRequest request);
    }
}