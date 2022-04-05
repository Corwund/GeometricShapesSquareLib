using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricShapesSquareLibrary;

namespace GeometricShapesSquareLibrary.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Area_radius7_returned153_94()
        {
            //Arrange
            double radius = 7.0; ;
            var circle = new Circle(radius, "Circle");
            double expected = 153.94;

            //Act
            double actual = circle.Area();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Area_WhenRadiusIsLessThanZero_ShouldThrowArgumentException()
        {
            //Arrange
            double radius = -7; ;

            //Act
            try
            {
                var circle = new Circle(radius, "Circle");
            }
            catch (ArgumentException exc)
            {
                //Assert
                StringAssert.Contains(exc.Message, Circle.RadiusLessThanZeroMessage);
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }
    }
}
