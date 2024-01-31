using Car.BL.Interfaces;
using Car.DL.Interfaces;
using Car.Users.Models;

namespace Car.BL.Services
{
    public class BrandService: IBrandService
    {
        
            private readonly IBrandRepository _brandRepository;

            public BrandService(IBrandRepository brandRepository)
            {
                _brandRepository = brandRepository;
            }

            public Brand GetById(int id)
            {
                return _brandRepository.GetById(id);
            }

            public void Add(Brand brand)
            {
                _brandRepository.Add(brand);
            }

            public void Remove(int id)
            {
                _brandRepository.Remove(id);
            }

            public List<Brand> GetAll()
            {
                return _brandRepository.GetAll();
            }
        }

    }
