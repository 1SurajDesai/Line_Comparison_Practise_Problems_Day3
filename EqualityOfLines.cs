using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class EqualityOfLines
    {
        public static void CheckEqualityOfLines()
        {
            double x1, x2, y1, y2, x3, x4, y3, y4, LengthOfLine1, LengthOfLine2;
            Console.WriteLine("Enter co-ordinates of first line:");
            Console.WriteLine("Enter value of x1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value of x2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value of y1:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value of y2:");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter co-ordinates of second line:");
            Console.WriteLine("Enter value of x3:");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value of x4");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value of y3:");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value of y4:");
            y4 = Convert.ToInt32(Console.ReadLine());


            LengthOfLine1= Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            LengthOfLine2 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));

            if (LengthOfLine1.Equals(LengthOfLine2))
            {
                Console.WriteLine("Two lines are equal");
            }
            else
            {
                Console.WriteLine("Two lines are not equal");

            }
        }
        
    }
}
