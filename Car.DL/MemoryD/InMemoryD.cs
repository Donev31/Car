using Car.Models;
using Car.Users.Models;

namespace Car.DL.MemoryD
{
    public static class InMemoryD
    {
        public static List<Brand> BrandData = new List<Brand>()
        {
            new Brand()
            {
                Id = 1,
                Name = "BMW",
                BirthDay = DateTime.Now
            },
             new Brand()
            {
                Id = 2,
                Name = "Mercedes",
                BirthDay = DateTime.Now
            },
              new Brand()
            {
                Id = 3,
                Name = "Audi",
                BirthDay = DateTime.Now
            },
              new Brand()
              { Id = 4,
                  Name = "VW",
                  BirthDay = DateTime.Now
            }
        };

        public static List<Model> ModelData = new List<Model>()
        {
            new Model()
            {
                Id = 1,
                Mname = "M5 Competition",
                BrandId = 1,
                ReleaseDate = new DateTime(2011, 11, 05)
            },
             new Model()
            {
                Id = 4,
                Mname = "X5 ",
                BrandId = 1,
                ReleaseDate = new DateTime(2015, 11, 06)
            },
             new Model()
            {
                Id = 2,
                Mname = "S coupe",
                BrandId = 2,
                ReleaseDate = new DateTime(2015, 11, 05)
            },
              new Model()
            {
                Id = 3,
                Mname = "Rs6",
                BrandId= 3,
                ReleaseDate = new DateTime(2020, 12, 05)
            },
            new Model()
            {
                Id = 4,
                Mname = "Golf",
                BrandId = 4,
                ReleaseDate = new DateTime(2010, 11, 05)
            },
        };


    }
}