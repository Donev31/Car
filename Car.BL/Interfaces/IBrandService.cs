using Car.Users.Models;

namespace Car.BL.Interfaces
{
    public interface IBrandService
    {
        
        List<Brand> GetAll();

         Brand GetById(int id);

        void Add(Brand brand);

        void Remove(int id);
    }
}

