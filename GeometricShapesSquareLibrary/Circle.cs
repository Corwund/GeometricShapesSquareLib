using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesSquareLibrary
{
    public class Circle :Shape
    {
        private double r;
        public const string RadiusLessThanZeroMessage = "Radius must be greater than zero";

        public Circle(double radius, string name) : base(name)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.Round(Math.PI * r * r, 2);
        }

        public double Radius
        {
            get => r;
            set
            {
                r = value > 0 ? value : throw new ArgumentException(RadiusLessThanZeroMessage);
            }
        }
    }
}
