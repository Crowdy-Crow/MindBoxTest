using MindBoxTest.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.Services
{
    public class ShapesService
    {
        public Triangle Create(double a, double b, double c)
        {
            return new Triangle(a,b,c);
        }
        public Circle Create(double a)
        {
            return new Circle(a);
        }
    }
}
