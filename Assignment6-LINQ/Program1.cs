using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_6
{
    class Employee
    {
        public Decimal EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>()
            {
                new Employee { EmployeeId = 1, FirstName = "Prema", LastName = "Jayakumar", Title = "Developer", DOB = new DateTime(2002, 01, 05), DOJ = new DateTime(2023, 02, 08), City = "Tiruthani" },
                new Employee { EmployeeId = 2, FirstName = "Janani", LastName = "AVR", Title = "Software Engineer", DOB = new DateTime(2001, 12, 01), DOJ = new DateTime(2023, 02, 08), City = "Perambur" },
                new Employee { EmployeeId = 3, FirstName = "Sanjay", LastName = "Dhanapal", Title = "Developer", DOB = new DateTime(2001, 10, 29), DOJ = new DateTime(2023, 02, 08), City = "Avadi" },
                new Employee { EmployeeId = 4, FirstName = "Kailash", LastName = "VP", Title = "Analyst", DOB = new DateTime(2002, 02, 22), DOJ = new DateTime(2023, 02, 08), City = "Chennai" },
                new Employee { EmployeeId = 5, FirstName = "Harish", LastName = "R", Title = "Software Engineer", DOB = new DateTime(2002, 09, 23), DOJ = new DateTime(2023, 02, 08), City = "Vellore" },
            };
            var ChennaiEmployees = from emp in employee
                                   where emp.City == "Chennai"
                                   select emp;
            Console.WriteLine("Employees in Chennai... ");
            foreach (var emp in ChennaiEmployees)
            {
                Console.WriteLine("Employee ID: " + emp.EmployeeId);
                Console.WriteLine("Name: " + emp.FirstName + " " + emp.LastName);
                Console.WriteLine("Title: " + emp.Title);
                Console.WriteLine("Date of Birth: " + emp.DOB.ToShortDateString());
                Console.WriteLine("Date of Joining: " + emp.DOJ.ToShortDateString());
                Console.WriteLine("City: " + emp.City);
                Console.WriteLine();
            }
            var highestId = (from emp in employee
                             orderby emp.EmployeeId descending
                             select emp).FirstOrDefault();

            Console.WriteLine("Highest ID of Employee...");
            Console.WriteLine("Employee ID: " + highestId.EmployeeId);
            Console.WriteLine("Name: " + highestId.FirstName + " " + highestId.LastName);
            Console.WriteLine("Title: " + highestId.Title);
            Console.WriteLine("Date of Birth: " + highestId.DOB.ToShortDateString());
            Console.WriteLine("Date of Joining: " + highestId.DOJ.ToShortDateString());
            Console.WriteLine("City: " + highestId.City);
        }
    }
}