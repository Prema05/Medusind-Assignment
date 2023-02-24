using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string1:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the string2:");
            string s2 = Console.ReadLine();
            if (s1 == s2)
            {
                Console.WriteLine("The two strings are same.");
            }
            else
            {
                Console.WriteLine("The two strings are not equal.");
            }
            Console.ReadLine();
        }
    }
}
