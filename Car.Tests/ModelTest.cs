using Car.DL.Interfaces;
using Car.Models;

namespace Car.Test
{
    public class StaticDataTest
    {
        

        

        public void GetAllByBrandId_WrongId()
        {
            //setup
            var expectedCount = 0;
            var BrandId = 11;

            var mockedModelRepository = new Mock<IModelRepository>();

            mockedModelRepository.Setup(x => x.GetAllByBrandId(BrandId))
                .Returns(ModelData.Where(b => b.BrandId == brandId).ToList());
            var service = new ModelService(mockedModelRepository.Object);
            var result = service.GetAllByBrandId(BrandId);
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count());
        }

        public void TestCalculation_Result_Check()
        {
            var expectedResult = 14;
            var testNumber = 10;
            var mockedModelRepository = new Mock<IModelRepository>();
            mockedModelRepository.Setup(x => x.GetAll())
                .Returns(ModelData);
            var service = new ModelService(mockedModelRepository.Object);
            var result = service.TestCalculation(testNumber);
            Assert.Equal(expectedResult, result);
        }

        public void RemoveModel_Count_Check()
        {
            //setup
            var expectedResult = 3;
            var modelId = 1;
            var modelToRemove = ModelData.FirstOrDefault(x => x.Id == modelId);

            var mockedModelRepository = new Mock<IModelRepository>();

            mockedModelRepository.Setup(x => x.Remove(modelId)).Callback(() => { ModelData.Remove(modelToRemove); });


            //inject
            var service = new ModelService(mockedModelRepository.Object);

            //Act
            service.Remove(modelId);

            //Assert

            Assert.Equal(expectedResult, ModelData.Count);




        }
    }
}