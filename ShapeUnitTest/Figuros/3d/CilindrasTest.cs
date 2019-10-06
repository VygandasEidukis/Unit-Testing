using System;
using System.Collections.Generic;
using System.Text;
using Testavimas;
using Xunit;

namespace ShapeUnitTest.Figuros._3d
{
    public class CilindrasTest
    {
        [Theory]
        [InlineData(5,15, 246.49)]
        public void Cilindras_ShouldGetPagrindas(double r, double h, double expected)
        {
            var cilindras = new Cilindras(r, h);

            var actual = cilindras.getPagrindas();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 15, 628)]
        [InlineData(5, 81, 2700.4)]
        public void Cilindras_ShouldGetPlotas(double r, double h, double expected)
        {
            var cilindras = new Cilindras(r, h);

            var actual = cilindras.getPlotas();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(18, 45, 45781.2)]
        [InlineData(69, 85, 1270710.9)]
        public void Cilindras_ShouldGetTuris(double r, double h, double expected)
        {
            var cilindras = new Cilindras(r, h);

            var actual = cilindras.getTuris();

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
                    var cilindras = new Cilindras(value, b);
                }
                ));
        }
    }
}
