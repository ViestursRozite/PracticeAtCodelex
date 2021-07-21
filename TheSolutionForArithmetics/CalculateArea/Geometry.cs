using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        
        public static double? areaOfCircle(decimal radius)
        {
            if(radius <= 0)
            {
                Console.WriteLine("Error, radius cannot be zero or below");
                return null;
            }
            decimal area = (decimal)Math.PI * radius * 2;
            return Convert.ToDouble(area);
            //throw new NotImplementedException();
        }

        public static double? areaOfRectangle(decimal length, decimal width)
        {
            if (length <= 0 || width <= 0)
            {
                Console.WriteLine("Error, nither length nor width can be zero or below");
                return null;
            }
            decimal area = length * width;
            return Convert.ToDouble(area);
            //throw new NotImplementedException();
        }

        public static double? areaOfTriangle(decimal ground, decimal h)
        {
            if (ground <= 0 || h <= 0)
            {
                Console.WriteLine("Error, nither groud nor h can be zero or below");
                return null;
            }
            decimal area = 0.5M * (ground * h);
            return Convert.ToDouble(area);
            //throw new NotImplementedException();
        }
    }
}
