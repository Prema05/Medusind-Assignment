using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Student
    {
        int rollno;
        string name;
        string classname;
        int semester;
        string branch;
        int[] marks = new int[5];

        public Student(int rollno, string name, string classname, int semester, string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.classname = classname;
            this.semester = semester;
            this.branch = branch;
        }

        public void GetMarks(int mark1, int mark2, int mark3, int mark4, int mark5)
        {
            marks[0] = mark1;
            marks[1] = mark2;
            marks[2] = mark3;
            marks[3] = mark4;
            marks[4] = mark5;
        }

        public void DisplayResult()
        {
            int totalMarks = 0;
            foreach (int mark in marks)
            {
                totalMarks += mark;
                if (mark < 35)
                {
                    Console.WriteLine("Result: Failed");
                    return;
                }
            }
            double avgMarks = totalMarks / 5.0;
            if (avgMarks < 50)
            {
                Console.WriteLine("Result: Failed");
                return;
            }
            Console.WriteLine("Result: Passed");
        }

        public void DisplayData()
        {
            Console.WriteLine("Roll No.: {0}", rollno);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Class: {0}", classname);
            Console.WriteLine("Semester: {0}", semester);
            Console.WriteLine("Branch: {0}", branch);
            Console.WriteLine("Marks: {0} {1} {2} {3} {4}", marks[0], marks[1], marks[2], marks[3], marks[4]);
        }
    }
}