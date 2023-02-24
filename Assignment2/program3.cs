using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string s1 = Console.ReadLine();
            string reverse = string.Empty;
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                reverse = reverse + s1[i];
            }
            Console.WriteLine("The reverse string is:" + reverse);
            Console.ReadLine();
        }
    }
}