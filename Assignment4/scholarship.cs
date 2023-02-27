using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class scholarship
    {
        public int total_marks;
        public float fees;

        public float Merit(int x, float y)
        {
            if (x >= 70 && x <= 80)
            {
                return (y * 20) / 100;
            }
            else if (x > 80 && x <= 90)
            {
                return (y * 30) / 100;
            }
            else if (x > 90)
            {
                return (y * 50) / 100;
            }
            else
            {
                return 0;
            }
        }
        static void Main(String[] args)
        {
            scholarship sc = new scholarship();

            Console.WriteLine("Please Enter Total Marks: ");
            sc.total_marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Fees: ");
            sc.fees = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Scholarship Amount is: " + sc.Merit(sc.total_marks, sc.fees));
            Console.ReadLine();
        }
    }

}