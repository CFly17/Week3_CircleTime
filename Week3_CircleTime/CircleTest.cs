using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace Week3_CircleTime
{
    public class CircleTest
    {
        [Fact]
        public void TestCircumference()
        {
            Circle c = new Circle(5);
            double actual = c.CalculateCircumference();
            double expected = 31.42;
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(5, (2 * 5 * Math.PI))]
        [InlineData(10, (2 * 10 * Math.PI))]
        [InlineData(15, (2*15*Math.PI))]
        //[InlineData("sdhjfhjksd", -1)] I wanted to test giving the method a bad input, but i cant give it a non double
        [InlineData(-1, (2*1*Math.PI))]
        [InlineData(0, 0)]

        public void TestCircumferenceTheory(double radius, double expected)
        {
            Circle c = new Circle(radius);
            double actual = c.CalculateCircumference();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(2, 2*2*Math.PI)]
        [InlineData(-2, 2 * 2 * Math.PI)]
        public void TestAreaTheory(double radius, double expected)
        {
            Circle c = new Circle(radius);
            double actual = c.CalculateArea();
            Assert.Equal(expected, actual);
        }
    }
}
