using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.models
{
    public abstract class Shape
    {
        public double Area { get { return CalculateArea(); } }
        public abstract double CalculateArea();
    }
}
