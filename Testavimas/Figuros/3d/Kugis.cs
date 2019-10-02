using System;
using System.Collections.Generic;
using System.Text;

namespace Testavimas
{
    public class Kugis
    {
        public double h { get; set; }
        public double r { get; set; }
        private double pi = 3.14;

        public double S
        {
            get { return Math.Round(Math.Sqrt((h*h)+(r*r)),2); }
        }



        public Kugis(double r, double h)
        {
            this.r = r;
            this.h = h;
        }

        public double getPagrindas()
        {
            return Math.Round(pi * (r * r),2);
        }


        public double getPlotas()
        {
            double ss = pi * r * S;
            return Math.Round(getPagrindas() + ss,2);
        }

        public double getTuris()
        {
            return Math.Round((((double)1/3)*pi*(r*r)*h),2);
        }
    }
}
