using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First_name:");
            string first_name = Console.ReadLine();
            Console.WriteLine("Enter the last_name:");
            string last_name = Console.ReadLine();
            Program p = new Program();
            Display(first_name.ToUpper(), last_name.ToUpper());
        }
            public static void Display(string first_name, string last_name)
            {
                Console.WriteLine(first_name);
                Console.WriteLine(last_name);
                Console.ReadLine();
            }
        }
    }

