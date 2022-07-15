using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.Validators
{
    public static class Constants
    {
        public const string exception_WrongTriangleSidesValue_Message = "Стороны не могут быть отрицательными или равны нулю";
        public const string exception_WrongRatioTriangleSides_Message = "Треугольник с такими сторонами существовать не может";
        public const string exception_WrongCircleRadiusValue_Message = "Радиус не может быть отрицательным или равным нулю";
    }
}
