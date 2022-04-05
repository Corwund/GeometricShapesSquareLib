using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricShapesSquareLibrary;

namespace GeometricShapesSquareLibrary.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Area_4and8and6_returned11_62()
        {
            //Arrange
            double a = 4.0;
            double b = 8.0;
            double c = 6.0;
            double expected = 11.62;
            var triangle = new Triangle(a, b, c, "Triangle");

            //Act
            double actual = triangle.Area();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRightTriangle_3and4and5_returnedTrue()
        {
            //Arrange
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            var triangle = new Triangle(a, b, c, "Triangle");

            //Act
            bool actual = triangle.IsRightTriangle();

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Area_4and8and13_ShouldThrowArgumentException()
        {
            //Arrange
            double a = 4.0;
            double b = 8.0;
            double c = 13.0;

            //Act
            try
            {
                Triangle triangle = new Triangle(a, b, c, "Triangle");
            }
            catch (ArgumentException exc)
            {
                //Assert
                StringAssert.Contains(exc.Message, Triangle.LengthGeraterThanSummAnotherLengths);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void Area_0and8and5_ShouldThrowArgumentException()
        {
            //Arrange
            double a = 0.0;
            double b = 8.0;
            double c = 5.0;

            //Act
            try
            {
                Triangle triangle = new Triangle(a, b, c, "Triangle");
            }
            catch (ArgumentException exc)
            {
                //Assert
                StringAssert.Contains(exc.Message, Triangle.AllValueMustBeGreaterThanZero);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }
    }

}
