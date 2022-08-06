using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2
{
    internal class Linemodel
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
            if (y1 == y2 && x1 == x2)
            {
                Console.WriteLine("Lines are Equal");
            }
            else
            {
                Console.WriteLine("Lines are unequal");
            }
        }
    }
}