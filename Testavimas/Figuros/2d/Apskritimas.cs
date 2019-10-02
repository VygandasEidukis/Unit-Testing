using System;
using System.Collections.Generic;
using System.Text;

namespace Testavimas
{
    public class Circle
    {
        private double pi = 3.14;
        public double r { get; set; }
        public Circle(double r)
        {
            this.r = r;
        }

        public double getPerimetras()
        {
            return Math.Round(2 * pi * r,2);
        }

        public double getPlotas()
        {
            return Math.Round(Math.Pow(pi * r, 2),2);
        }
    }
}
