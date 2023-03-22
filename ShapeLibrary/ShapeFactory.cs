using System;

namespace ShapeLibrary
{
    public static class ShapeFactory
    {
        public static IShape CreateShape(double[] sides)
        {
            switch (sides.Length)
            {
                case 1:
                    return new Circle(sides[0]);
                case 3:
                    return new Triangle(sides[0], sides[1], sides[2]);
                default:
                    throw new ArgumentException("Unsupported number of sides");
            }
        }
    }
}