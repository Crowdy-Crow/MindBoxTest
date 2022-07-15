using MindBoxTest.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.Validators
{
    public static class CircleValidator
    {
        public static bool isValid(Circle circle)
        {
            //Проверка на отрицательное или равное нулю значение радиуса
            if (circle.Radius <= 0)
            {
                throw new Exception(Constants.exception_WrongCircleRadiusValue_Message);
            } 
            return true;
        }
    }
}
