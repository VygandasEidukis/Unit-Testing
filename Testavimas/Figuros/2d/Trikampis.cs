using System;
using System.Collections.Generic;
using System.Text;

namespace Testavimas
{
    public class Trikampis
    {
        public double a { get; set; }
        public double b { get; set; }

        public Trikampis(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double getPerimetras()
        {
            double c = Math.Sqrt(a * a + b * b);

            return Math.Round(a + b + c,2);
        }

        public double getPlotas()
        {
            return Math.Round(0.5 * b * a, 2);
        }
    }
}
