using Car.DL.Interfaces;
using Car.DL.MemoryD;
using Car.Users.Models;

namespace Car.DL.Reconstruction
{
    public class BrandRepository : IBrandRepository
    {
        public void Add(Brand brand)
        {
            InMemoryD.BrandData.Add(brand);
        }

        public List<Brand> GetAll()
        {
            return InMemoryD.BrandData;
        }

        public Brand GetById(int id)
        {
            return InMemoryD.BrandData.First(a => a.Id == id);
        }

        public void Remove(int id)
        {
            var brand = GetById(id);
            InMemoryD.BrandData.Remove(brand);
        }
    }
}