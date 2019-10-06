using System;
using System.Collections.Generic;
using System.Text;
using Testavimas;
using Xunit;

namespace ShapeUnitTest.Figuros._3d
{
    public class RutulysTest
    {
        [Theory]
        [InlineData(18, 4069.44)]
        public void Rutulys_ShouldGetPlotas(double r, double expected)
        {
            var rutulys = new Rutulys(r);

            var actual = rutulys.getPlotas();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(18, 18312.48)]
        public void Rutulys_ShouldGetTuris(double r, double expected)
        {
            var rutulys = new Rutulys(r);

            var actual = rutulys.getTuris();

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(0)]
        [InlineData(-20)]
        public void CreateStaciakampis_ShouldFail(int value)
        {
            Assert.Throws<Exception>(new Action(
                () =>
                {
                    var rutulys = new Rutulys(value);
                }
                ));
        }
    }
}
