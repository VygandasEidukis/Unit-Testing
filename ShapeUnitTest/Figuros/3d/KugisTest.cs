using System;
using System.Collections.Generic;
using System.Text;
using Testavimas;
using Xunit;

namespace ShapeUnitTest.Figuros._3d
{
    public class KugisTest
    {
        [Theory]
        [InlineData(28,20,2461.76)]
        public void Kugis_ShouldGetPagrindas(double r, double h, double expected)
        {
            var kugis = new Kugis(r, h);

            var actual = kugis.getPagrindas();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(31, 82, 11550.36)]
        public void Kugis_ShouldGetPlotas(double r, double h, double expected)
        {
            var kugis = new Kugis(r, h);

            var actual = kugis.getPlotas();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(16, 14, 3751.25)]
        public void Kugis_ShouldGetTuris(double r, double h, double expected)
        {
            var kugis = new Kugis(r, h);

            var actual = kugis.getTuris();

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
                    var kugis = new Kugis(value, b);
                }
                ));
        }
    }
}
