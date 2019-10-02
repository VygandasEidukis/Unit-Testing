using System;
using System.Collections.Generic;
using System.Text;

namespace Testavimas
{
    public class Cilindras
    {
        public double r { get; set; }
        public double h { get; set; }
        private double pi = 3.14;

        public Cilindras(double r, double h)
        {
            this.r = r;
            this.h = h;
        }
        public double getPagrindas()
        {
            return Math.Round(Math.Pow(pi * r, 2),2);
        }

        public double getPlotas()
        {
            return Math.Round(2 * pi * (r * r) + h * (2 * pi * r),2 );
        }

        public double getTuris()
        {
            return Math.Round(pi * (r * r) * h,2);
        }
    }
}
