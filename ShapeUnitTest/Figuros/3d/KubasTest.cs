using System;
using System.Collections.Generic;
using System.Text;
using Testavimas;
using Xunit;

namespace ShapeUnitTest.Figuros._3d
{
    public class KubasTest
    {
        [Theory]
        [InlineData(10, 100)]
        public void Kubas_ShouldGetPagrindas(double a, double expected)
        {
            var kubas = new Kubas(a);

            var actual = kubas.getPagrindas();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(18, 1944)]
        public void Kubas_ShouldGetPlotas(double a, double expected)
        {
            var kubas = new Kubas(a);

            var actual = kubas.getPlotas();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(21, 9261)]
        public void Kubas_ShouldGetTuris(double a, double expected)
        {
            var kubas = new Kubas(a);

            var actual = kubas.getTuris();

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
                    var kubas = new Kubas(value);
                }
                ));
        }

    }
}
