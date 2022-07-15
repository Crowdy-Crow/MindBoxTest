using MindBoxTest.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.models
{
    public class Triangle : Shape
    {
        public List<double> sides { get; set; }
        public Triangle(double a, double b, double c)
        {
            this.sides = new List<double> { a, b, c };
            TriangleValidator.isValid(this);
        }
        public override double CalculateArea()
        {
            var p = (sides[0] + sides[1] + sides[2]) / 2;
            var area = Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
            return Math.Round(area, 3);
        }
        public bool isRightTriangle()
        {
            var maxSide = sides.Max();
            var otherSides = sides.Where(x => x != maxSide);
            double summDegreeOtherSides = 0;
            foreach (var side in otherSides)
            {
                summDegreeOtherSides += side * side;
            }
            return maxSide * maxSide == summDegreeOtherSides;
        }
    }
}
