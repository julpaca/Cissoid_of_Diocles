using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cissoid_of_Diocles
{
    public class Coordinates
    {
        public double x = default;
        public double y1 = default;
        public double y2 = default;

        public Coordinates (double X, double Y1, double Y2)
        {
            x = X;
            y1 = Y1;
            y2 = Y2;
        }
        
        public static (double y1, double y2) CissoidOfDiocles(double xC, double a)
        {
            double y1;
            double y2;
            double yButNotSqrt;
            yButNotSqrt = ((xC * xC * xC) / (2 * a - xC));
            y1 = Math.Sqrt(yButNotSqrt);
            //y1 = Math.Sqrt(((xC * xC * xC) / (2 * a - xC)));
            y1 = Math.Round(y1, 6);
            y2 = -y1;
            return (y1, y2);
        }
    
    }
}
