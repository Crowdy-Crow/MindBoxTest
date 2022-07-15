using MindBoxTest.models;
using MindBoxTest.Validators;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.Tests
{
    public class CircleTests
    {
        [Test]
        public void CalculateArea_3_4_5_ShouldReturn_6()
        {
            // arrange 
            var expectedArea = 78.5;
            Circle triangle = new Circle(5);

            // act
            var result = triangle.CalculateArea();

            // assert
            Assert.That(result, Is.EqualTo(expectedArea));
        }
        [Test]
        public void Create_SideLess0_ShouldThrowExtension()
        {
            // arrange
            double r = -1;
            var expectedExtension = Constants.exception_WrongCircleRadiusValue_Message;

            // act
            var exception = Assert.Catch(() => new Circle(r));

            // assert
            Assert.That(exception.Message, Is.EqualTo(expectedExtension));
        }
        [Test]
        public void Create_SideEquel0_ShouldThrowExtension()
        {
            // arrange
            double r = 0;
            var expectedExtension = Constants.exception_WrongCircleRadiusValue_Message;

            // act
            var exception = Assert.Catch(() => new Circle(r));

            // assert
            Assert.That(exception.Message, Is.EqualTo(expectedExtension));
        }
    }
}
