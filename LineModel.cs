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
           double lengthOfLine;
            double lengthOfLine1;

            lengthOfLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of a given Line is: " + lengthOfLine);

            lengthOfLine1 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine("Length of a given Line is: " + lengthOfLine1);

            Console.WriteLine(lengthOfLine.Equals(lengthOfLine1));
        }
    }
}
