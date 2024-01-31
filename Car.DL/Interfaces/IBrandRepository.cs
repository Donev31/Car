using Car.Users.Models;

namespace Car.DL.Interfaces
{
    public interface IBrandRepository
    {
        List<Brand> GetAll();

        Brand GetById(int id);

        void Add(Brand brand);

        void Remove(int id);
    }
}
