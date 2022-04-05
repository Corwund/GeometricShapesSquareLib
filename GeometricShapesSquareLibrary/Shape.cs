using System;

namespace GeometricShapesSquareLibrary
{
    public abstract class Shape
    {
        public string ShapeName { get; }
        public Shape(string name)
        {
            ShapeName = name;
        }
        public abstract double Area();
        public void PrintInfo()
        {
            Console.WriteLine($"The name of the figure is {ShapeName}.\nThe area is equal to {Area()}");
        }
        public override string ToString()
        {
            return ShapeName;
        }

    }
}
