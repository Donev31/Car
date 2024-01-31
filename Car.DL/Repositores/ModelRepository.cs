using Car.DL.Interfaces;
using Car.DL.MemoryD;
using Car.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.DL.Repositores
{
    public class ModelRepository : IModelRepository
    {
        public void Add(Model model)
        {
            InMemoryD.ModelData.Add(model);
        }

        public List<Model> GetAll()
        {
            return InMemoryD.ModelData;
        }

        public List<Model> GetAllByBrandId(int id)
        {
            return InMemoryD.ModelData.Where(b => b.BrandId == id).ToList();

        }

        public Model GetById(int id)
        {
            return InMemoryD.ModelData.First(a => a.Id == id);
        }

        public void Remove(int id)
        {
            var model = GetById(id);
            InMemoryD.ModelData.Remove(model);
        }
    }
}