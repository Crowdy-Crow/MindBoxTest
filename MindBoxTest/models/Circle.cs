using MindBoxTest.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.models
{
    public class Circle : Shape
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
            CircleValidator.isValid(this);
        }

        public double Radius { get; set; }

        public override double CalculateArea()
        {
            var area = Radius * Radius * 3.14;
            return Math.Round(area, 3);
        }
    }
}
