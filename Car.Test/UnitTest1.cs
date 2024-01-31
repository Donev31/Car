namespace Car.Test
{
    public class UnitTest1
    {
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
                BrandId = 3,
                ReleaseDate = new DateTime(2020, 12, 05)
            }
        };

        [Fact]
        public void GetAllByBrandId_Count_Check()
        {
            //setup
            var expectedCount = 2;
            var BrandId = 1;

            var mockedModelRepository = new Mock<IModelRepository>();

            mockedModelRepository.Setup(x => x.GetAllByBrandId(BrandId))
                .Returns(ModelData.Where(b => b.AuthorId == BrandId).ToList());

            //inject
            var service = new ModelService(mockedModelRepository.Object);

            //Act
            var result = service.GetAllByBrandId(BrandId);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count());
        }
    }
}