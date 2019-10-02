using System;
using System.Collections.Generic;
using System.Text;
using Testavimas;
using Xunit;

namespace ShapeUnitTest.Figuros._2d
{
    public class KvadratasTest
    {
        [Theory]
        [InlineData(5,20)]
        [InlineData(25,100)]
        public void Kvadratas_ShouldGetPerimetras(double x, double expected)
        {
            Kvadratas kvadratas = new Kvadratas(x);

            var actual = kvadratas.getPerimetras();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 100)]
        [InlineData(5,25)]
        public void Kvadratas_ShouldGetPlotas(double x, double expected)
        {
            Kvadratas kvadratas = new Kvadratas(x);

            var actual = kvadratas.getPlotas();

            Assert.Equal(expected, actual);
        }
    }
}
