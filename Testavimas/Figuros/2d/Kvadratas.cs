using System;
using System.Collections.Generic;
using System.Text;

namespace Testavimas
{
    public class Kvadratas
    {
        public double x { get; set; }
        public Kvadratas(double x)
        {
            this.x = x;
        }

        public double getPerimetras()
        {
            return 4*x;
        }

        public double getPlotas()
        {
            return Math.Pow(x, 2);
        }
    }
}
