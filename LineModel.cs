﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2
{
    internal class Linemodel
    {
         /// <summary>
        /// Lengthes the of line.
        /// </summary>
        /// <param name="x1">The x1.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="y2">The y2.</param>
        public static void LineAndModel(double x1, double y1, double x2, double y2, double a1, double b1, double a2, double b2)
        {
           double lengthOfLine;
            double lengthOfLine1;

            lengthOfLine = Math.Sqrt( Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) );
            Console.WriteLine("Length of a given Line is: " + lengthOfLine);

            lengthOfLine1 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine("Length of a given Line is: " + lengthOfLine1);

            if (lengthOfLine1 == lengthOfLine)
            {
                Console.WriteLine("Both lines are Equal.");
            }
        }
    }
}
