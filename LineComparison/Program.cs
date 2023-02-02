using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Compare();
            Console.ReadLine();
        }
        public static void Compare()
        {
            Console.WriteLine("Welcome to Line Comparison Problem");
            Console.WriteLine("Enter the value of x1 and y1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x2 and y2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            double length = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("Line length is " + length);

            Console.WriteLine("Enter the value of x3 and y3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x4 and y4");
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());

            double length2 = Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2);
            Console.WriteLine("Line length is " + length2);

            if (length.Equals(length2))
            {
                Console.WriteLine("Both line length are equal");
            }
            else if (length.CompareTo(length2) == 1)
            {
                Console.WriteLine("length of line is greater than length2 of line");
            }
            else if (length.CompareTo(length2) == -1)
            {
                Console.WriteLine("length of line is less than length2 of line");
            }
            else
            {
                Console.WriteLine("line length are not equal");
            }
        }

    }
}
