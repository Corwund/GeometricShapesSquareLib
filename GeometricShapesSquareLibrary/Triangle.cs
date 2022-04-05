using System;

namespace GeometricShapesSquareLibrary
{
    public class Triangle : Shape
    {
        private double edgeA;
        private double edgeB;
        private double edgeC;

        public const string ValueMustBeGreaterThanZero = "The value must be greater than zero";
        public const string ValueMustBeLessThan = "The value must be less than ";
        public const string AllValueMustBeGreaterThanZero = "Not a triangle. All edge lengths of the triangle must be greater than zero";
        public const string LengthGeraterThanSummAnotherLengths = "Not a triangle. The length of one of the edges is greater " +
            "than the sum of the lengths of the other edges";

        public Triangle(double edgeA, double edgeB, double edgeC, string name) : base(name)
        {
            if (IsTriangleExist(edgeA, edgeB, edgeC))
            {
                this.edgeA = edgeA;
                this.edgeB = edgeB;
                this.edgeC = edgeC;
            }
        }
        public double EdgeA
        {
            get => edgeA;
            set
            {
                if (value <= 0)
                    throw new ArgumentException(ValueMustBeGreaterThanZero, nameof(EdgeA));
                if (value >= EdgeB + EdgeC)
                    throw new ArgumentException(ValueMustBeLessThan + value);
                edgeA = value;
            }
        }
        public double EdgeB
        {
            get => edgeB;
            set
            {
                if (value <= 0)
                    throw new ArgumentException(ValueMustBeGreaterThanZero, nameof(EdgeB));
                if (value >= EdgeA + EdgeC)
                    throw new ArgumentException(ValueMustBeLessThan + value);
                edgeB = value;
            }
        }
        public double EdgeC
        {
            get => edgeC;
            set
            {
                if (value <= 0)
                    throw new ArgumentException(ValueMustBeGreaterThanZero, nameof(EdgeC));
                if (value >= EdgeA + EdgeB)
                    throw new ArgumentException(ValueMustBeLessThan + value);
                edgeC = value;
            }
        }

        public bool IsRightTriangle()
        {
            bool resC = Math.Pow(EdgeA, 2) + Math.Pow(EdgeB, 2) == Math.Pow(EdgeC, 2);
            bool resB = Math.Pow(EdgeA, 2) + Math.Pow(EdgeC, 2) == Math.Pow(EdgeB, 2);
            bool resA = Math.Pow(EdgeC, 2) + Math.Pow(EdgeB, 2) == Math.Pow(EdgeA, 2);

            return resA || resB || resC;
        }

        public override double Area()
        {
            double sp = SemiPerimetr();
            return Math.Round(Math.Sqrt(sp * (sp - EdgeA) * (sp - EdgeB) * (sp - EdgeC)), 2);
        }

        private double SemiPerimetr()
        {
            return (EdgeA + EdgeB + EdgeC) * 0.5;
        }

        private bool IsTriangleExist(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException(AllValueMustBeGreaterThanZero);
            if ((a + b) <= c || (a + c) <= b || (b + c) <= a)
                throw new ArgumentException(LengthGeraterThanSummAnotherLengths);
            return true;
        }
    }
}

