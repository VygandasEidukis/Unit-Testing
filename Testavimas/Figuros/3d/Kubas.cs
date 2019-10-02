using System;
using System.Collections.Generic;
using System.Text;

namespace Testavimas
{
    public class Kubas
    {
        public double a { get; set; }
        public Kubas(double a)
        {
            this.a = a;
        }

        public double getPagrindas()
        {
            return Math.Round(Math.Pow(a, 2),2);
        }

        public double getPlotas()
        {
            return Math.Round(6 * (a * a),2);
        }

        public double getTuris()
        {
            return Math.Round(Math.Pow(a, 3),2);
        }
    }
}
