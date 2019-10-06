using System;
using System.Collections.Generic;
using System.Text;

namespace Testavimas
{
    public class Staciakampis
    {
        public double a { get; set; }
        public double b { get; set; }

        public Staciakampis(double a, double b)
        {
            if (a <= 0 || b <= 0)
                throw new Exception("Number is too small");
            this.a = a;
            this.b = b;
        }

        public double getPerimetras()
        {
            return 2*a + 2*b;
        }

        public double getPlotas()
        {
            return a*b;
        }
    }
}
