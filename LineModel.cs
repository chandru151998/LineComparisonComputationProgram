using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1
{
    internal class LineModel
    {
        public static void LineAndModel()
        {
            Console.WriteLine("x1 is ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2 is ");
            double x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1 is ");
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2 is ");
            double y2 = Convert.ToInt32(Console.ReadLine());
            double x3 = x2 - x1;
            double y3 = y2 - y1;
            double z1 = x3 * x3;
            double z2 = y3 * y3;
            double z3 = z1 + z2;
            Console.WriteLine("Lentgh is " + Math.Sqrt(z3));
        }
    }
}
