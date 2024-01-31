using Car.Users.Models;

namespace Car.Models.Models.Responses
{
    public class GetModelsByBrandResponses
    {
        public Brand Brand { get; set; }

        public List<Model> Models { get; set; }
    }
}
