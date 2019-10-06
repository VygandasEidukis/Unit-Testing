using System;
using System.Collections.Generic;
using System.Text;
using Testavimas;
using Xunit;

namespace ShapeUnitTest.Figuros._2d
{
    public class StaciakampisTest
    {
        [Theory]
        [InlineData(10, 5, 30)]
        [InlineData(5,25,60)]
        public void Staciakampis_ShouldGetPerimetras(double x, double y, double expected)
        {
            var staciakampis = new Staciakampis(x,y);

            var actual = staciakampis.getPerimetras();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8,10, 80)]
        [InlineData(10,11, 110)]
        public void Staciakampis_ShouldGetPlotas(double x, double y, double expected)
        {
            var staciakampis = new Staciakampis(x, y);

            var actual = staciakampis.getPlotas();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(-20, 0)]
        public void CreateStaciakampis_ShouldFail(int value, int b)
        {
            Assert.Throws<Exception>(new Action(
                () =>
                {
                    var staciakampis = new Staciakampis(value, b);
                }
                ));
        }
    }
}
