using Car.Models;
using Car.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.DL.Interfaces
{
    public interface IModelRepository
    {
        List<Model> GetAll();

        Model GetById(int id);

        void Add(Model model);

        void Remove(int id);

        List<Model> GetAllByBrandId(int id);

    }

}