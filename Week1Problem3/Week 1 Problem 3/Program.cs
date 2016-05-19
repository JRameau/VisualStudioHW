﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a third number number: ");
            int num3 = int.Parse(Console.ReadLine());

            int[] numbers = { num1, num2, num3 }; 
            
            Console.WriteLine("The largest number is {0}", Max(numbers));
            Console.ReadLine();
        }

        public static int Max (int[] numbers)
        {           
            Array.Sort(numbers); 
            return numbers[2]; 
        }
    }
}
