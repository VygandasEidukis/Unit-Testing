using System;
using System.Collections.Generic;
using System.Text;

namespace Testavimas
{
    public class Rutulys
    {
        public double R { get; set; }
        private double pi = 3.14;
        public Rutulys(double r)
        {
            this.R = r;
        }

        public double getPlotas()
        {
            return Math.Round(4*pi*(R*R),2);
        }

        public double getTuris()
        {
            return Math.Round((4 / 3) * pi * Math.Pow(R, 3),2);
        }
    }
}
