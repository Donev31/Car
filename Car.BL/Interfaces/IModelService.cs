using Car.Models;
using Car.Models.Models.Responses;
using Car.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.BL.Interfaces
{
    public interface IModelService
    {
        List<Model> GetAll();

        Model GetById(int id);

        void Add(Model model);

        void Remove(int id);

        List<Model> GetAllByAuthorId(int id);
    }
}
    