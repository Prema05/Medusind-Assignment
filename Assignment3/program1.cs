using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the letter to count the occurance:");
            char letter = Console.ReadLine()[0];
            int count = 0;
            foreach (char c in str)
            {
                if (c == letter)
                {
                    count++;
                }
            }
            Console.WriteLine($"\nThe letter '{letter}' occurs {count} times int the input string.");
            Console.ReadLine();
        }
    }
}
