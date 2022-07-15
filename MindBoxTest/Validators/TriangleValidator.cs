using MindBoxTest.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.Validators
{
    public static class TriangleValidator
    {
        public static bool isValid(Triangle triangle)
        {
            ////Проверка на отрицательные или равные нулю значения сторон
            if (triangle.sides.Any(x => x <= 0))
            {
                throw new Exception(Constants.exception_WrongTriangleSidesValue_Message);
            }

            // Проверка на соотношение сторон
            var maxSide = triangle.sides.Max();
            var otherSides = triangle.sides.Where(x => x < maxSide);
            var summOtherSides = otherSides.Sum();
            if (maxSide >= summOtherSides)
            {
                throw new Exception(Constants.exception_WrongRatioTriangleSides_Message);
            }

            return true;
        }
    }
}
