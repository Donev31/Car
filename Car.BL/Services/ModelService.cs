using Car.BL.Interfaces;
using Car.DL.Interfaces;
using Car.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.BL.Services
{
    public class ModelService : ModelService
    {
        private readonly IModelRepository _modelRepository;

        public ModelService(IModelRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }

        public Model GetById(int id)
        {
            return _modelRepository.GetById(id);
        }

        public void Add(Model model)
        {
            _modelRepository.Add(model);
        }

        public void Remove(int id)
        {
            _modelRepository.Remove(id);
        }

        public List<Model> GetAll()
        {
            return _modelRepository.GetAll();
        }

        public List<Model> GetAllByAuthorId(int id)
        {
            return _modelRepository.GetAllByBrandId(id);
        }

        public int TestCalculation(int number)
        {
            var models = _modelRepository.GetAll();

            return models.Count() + number;


        }

    }
}



 