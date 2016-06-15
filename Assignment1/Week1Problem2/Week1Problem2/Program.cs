using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int n = int.Parse(Console.ReadLine());

            Table(n);

            Console.ReadKey();
        }

        static void Table(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    Console.Write("{0} ", i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
