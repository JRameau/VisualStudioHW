using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter an integer: ");
            int width = int.Parse(Console.ReadLine());

            int area = Calculate(length, width);

            Console.WriteLine("The area is: {0}", area);
            Console.ReadLine();
        }

        public static int Calculate(int l, int w)
        {
            return l * w;
        }
    }
}
