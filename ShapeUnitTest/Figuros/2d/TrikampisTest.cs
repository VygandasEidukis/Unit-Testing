using System;
using System.Collections.Generic;
using System.Text;
using Testavimas;
using Xunit;

namespace ShapeUnitTest.Figuros._2d
{
    public class TrikampisTest
    {
        [Theory]
        [InlineData(5,6,18.81)]
        public void Trikampis_ShouldGetPerimetras(double a, double b, double expected)
        {
            Trikampis trikampis = new Trikampis(a,b);

            var actual = trikampis.getPerimetras();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 6, 15)]
        public void Trikampis_ShouldGetPlotas(double a, double b, double expected)
        {
            Trikampis trikampis = new Trikampis(a, b);

            var actual = trikampis.getPlotas();

            Assert.Equal(expected, actual);
        }
    }
}
