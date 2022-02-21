using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class CalLengthOfLine
    {
        public static void CalculateLength()
        {
            double x1, x2, y1, y2, LenghtOfLine;
            Console.WriteLine("Enter value of x1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value of x2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value of y1:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value of y2:");
            y2 = Convert.ToInt32(Console.ReadLine());

            LenghtOfLine = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Length of line is " + LenghtOfLine);









        }


    }
}
