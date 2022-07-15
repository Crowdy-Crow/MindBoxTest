using MindBoxTest.models;
using MindBoxTest.Services;
using NUnit.Framework;

namespace MindBoxTest.Tests
{
    public class ShapesServiceTests
    {
        ShapesService shapesService;
        [SetUp]
        public void Setup()
        {
            shapesService = new ShapesService();
        }
        [Test]
        public void Create_NormalSides_ShouldReturnNewShape()
        {
            // arrange
            double a = 3;
            double b = 4;
            double c = 5;

            // act
            var triangle = shapesService.Create(a, b, c);
            var circle = shapesService.Create(a);

            // assert
            Assert.IsNotNull(triangle);
            Assert.IsNotNull(circle);
        }
    }
}