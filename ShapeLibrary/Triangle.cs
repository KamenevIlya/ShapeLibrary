using System;

namespace ShapeLibrary
{
    public class Triangle : IShape
    {
        private const double Epsilon = 0.0001;
        private readonly double _sideA, _sideB, _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double GetArea()
        {
            var halfPerimeter = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * (halfPerimeter - _sideB) *
                             (halfPerimeter - _sideC));
        }

        public bool IsRightAngled()
        {
            return Math.Abs(_sideA * _sideA + _sideB * _sideB - _sideC * _sideC) < Epsilon
                   || Math.Abs(_sideA * _sideA + _sideC * _sideC - _sideB * _sideB) < Epsilon
                   || Math.Abs(_sideB * _sideB + _sideC * _sideC - _sideA * _sideA) < Epsilon;
        }
    }
}