using System;
using System.Collections.Generic;
using System.Text;
using Testavimas;
using Xunit;


namespace ShapeUnitTest
{
    public class ApskritimasTest
    {
        private const int r;

        [Theory]
        [InlineData(5, 31.40)]
        public void getPerimetras_ShouldCalculate(double x, double expected)
        {
            Circle circle = new Circle(x);

            double actual = circle.getPerimetras();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 246.49)]
        [InlineData(21, 4348.08)]
        public void getPlotas_ShouldCalculate(double x, double expected)
        {
            Circle circle = new Circle(x);

            double actual = circle.getPlotas();

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(0)]
        [InlineData(-20)]
        public void createApskritimas_ShouldFail(int value)
        {
            Assert.Throws<Exception>(new Action(
                () =>
                {
                    var circle = new Circle(value);
                }
                ));
        }


    }
}
