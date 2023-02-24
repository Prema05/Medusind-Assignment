using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class program1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0, avg = 0, max = arr[0], min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            Console.WriteLine("Sum of Array is:" + sum);
            Console.WriteLine("Average of Array is:" + avg);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum Element:" + max);
            Console.WriteLine("Minimum Element:" + min);

            Array.Sort(arr);
            Console.WriteLine("Ascending Order:");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
            Console.WriteLine();
            Array.Reverse(arr);
            Console.WriteLine("Descending Order:");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}

