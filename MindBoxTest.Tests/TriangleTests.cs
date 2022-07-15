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
    public class TriangleTests
    {

        [Test]
        public void CalculateArea_3_4_5_ShouldReturn_6()
        {
            // arrange 
            var expectedArea = 6;
            Triangle triangle = new Triangle(3,4,5);

            // act
            var result = triangle.CalculateArea();

            // assert
            Assert.That(result, Is.EqualTo(expectedArea));
        }
        [Test]
        public void IsRightTriangle_3_4_5_ShouldReturnTrue()
        {
            // arrange 
            var expectedResult = true;
            Triangle triangle = new Triangle(3, 4, 5);

            // act
            var result = triangle.isRightTriangle();

            // assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        public void IsRightTriangle_3_4_5_ShouldReturnFalse()
        {
            // arrange 
            var expectedResult = false;
            Triangle triangle = new Triangle(3, 4, 6);

            // act
            var result = triangle.isRightTriangle();

            // assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        public void Create_SideLess0_ShouldThrowExtension()
        {
            // arrange
            double a = 3;
            double b = 4;
            double c = -1;
            var expectedExtension = Constants.exception_WrongTriangleSidesValue_Message;

            // act
            var exception = Assert.Catch(() => new Triangle(a, b, c));

            // assert
            Assert.That(exception.Message, Is.EqualTo(expectedExtension));
        }
        [Test]
        public void Create_SideEquel0_ShouldThrowExtension()
        {
            // arrange
            double a = 3;
            double b = 4;
            double c = 0;
            var expectedExtension = Constants.exception_WrongTriangleSidesValue_Message;

            // act
            var exception = Assert.Catch(() => new Triangle(a, b, c));

            // assert
            Assert.That(exception.Message, Is.EqualTo(expectedExtension));
        }
        [Test]
        public void Create_WrongRatioSides_ShouldThrowExtension()
        {
            // arrange
            double a = 3;
            double b = 4;
            double c = 8;
            var expectedExtension = Constants.exception_WrongRatioTriangleSides_Message;

            // act
            var exception = Assert.Catch(() => new Triangle(a, b, c));

            // assert
            Assert.That(exception.Message, Is.EqualTo(expectedExtension));
        }
    }
}
