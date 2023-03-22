using System;
using NUnit.Framework;
using ShapeLibrary;

namespace ShapeLibraryTests
{
    public class Tests
    {
        [Test]
        public void TestCircleArea()
        {
            var circle = new Circle(2.5);
            Assert.AreEqual(Math.PI * 2.5 * 2.5, circle.GetArea(), 0.0001);
        }

        [Test]
        public void TestTriangleArea()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.GetArea(), 0.0001);
        }

        [Test]
        public void TestTriangleIsRightAngled()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled());
        }

        [Test]
        public void TestShapeFactoryCircle()
        {
            var shape = ShapeFactory.CreateShape(new double[] { 2.5 });
            Assert.IsInstanceOf<Circle>(shape);
            Assert.AreEqual(Math.PI * 2.5 * 2.5, shape.GetArea(), 0.0001);
        }

        [Test]
        public void TestShapeFactoryTriangle()
        {
            var shape = ShapeFactory.CreateShape(new double[] { 3, 4, 5 });
            Assert.IsInstanceOf<Triangle>(shape);
            Assert.AreEqual(6, shape.GetArea(), 0.0001);
            Assert.IsTrue(((Triangle)shape).IsRightAngled());
        }
    }
}