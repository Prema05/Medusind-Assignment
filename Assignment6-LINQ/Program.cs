using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEg
{
    class Employee
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public string Title;
        public DateTime DOB;
        public DateTime DOJ;
        public string City;
    }
    class Program
    {
        //Insert Employee Details with the given data
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>
            {
                new Employee{ EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title="Manager", DOB=DateTime.Parse("16/11/1984"), DOJ=DateTime.Parse("8/6/2011"), City="Mumbai"},
                new Employee{ EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title="AsstManager", DOB=DateTime.Parse("20/08/1984"), DOJ=DateTime.Parse("7/7/2012"), City="Mumbai"},
                new Employee{ EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title="Consultant", DOB=DateTime.Parse("14/11/1987"), DOJ=DateTime.Parse("12/4/2015"), City="Pune"},
                new Employee{ EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title="SE", DOB=DateTime.Parse("3/6/1990"), DOJ=DateTime.Parse("2/2/2016"), City="Pune"},
                new Employee{ EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title="SE", DOB=DateTime.Parse("8/3/1991"), DOJ=DateTime.Parse("2/2/2016"), City="Mumbai"},
                new Employee{ EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title="Consultant", DOB=DateTime.Parse("7/11/1989"), DOJ=DateTime.Parse("8/8/2014"), City="Chennai"},
                new Employee{ EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title="Consultant", DOB=DateTime.Parse("2/12/1989"), DOJ=DateTime.Parse("1/6/2015"), City="Mumbai"},
                new Employee{ EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title="Associate", DOB=DateTime.Parse("11/11/1993"), DOJ=DateTime.Parse("6/11/2014"), City="Chennai"},
                new Employee{ EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title="Associate", DOB=DateTime.Parse("12/8/1992"), DOJ=DateTime.Parse("3/12/2014"), City="Chennai"},
                new Employee{ EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title="Manager", DOB=DateTime.Parse("12/4/1991"), DOJ=DateTime.Parse("2/1/2016"), City="Pune"}
            };

            // a. Display detail of all the employee:

            Console.WriteLine("A. Display details of all the employee ");
            var allEmployees = from emp in emplist
                               select emp;
            foreach (var emp in allEmployees)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB.ToShortDateString() + " " + emp.DOJ.ToShortDateString() + " " + emp.City);
            }

            // b. Display details of all the employee whose location is not Mumbai:
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("B. Display details of all the employee whose location is not Mumbai ");
            
            var employeesNotInMumbai = from emp in emplist
                                       where emp.City != "Mumbai"
                                       select emp;
            foreach (var emp in employeesNotInMumbai)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB.ToShortDateString() + " " + emp.DOJ.ToShortDateString() + " " + emp.City);
            }

            //c. Display details of all the employee whose title is AsstManager:
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("C. Display details of all the employee whose title is AsstManager ");
            
            var asstManagers = from emp in emplist
                               where emp.Title == "AsstManager"
                               select emp;
            foreach (var emp in asstManagers)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB.ToShortDateString() + " " + emp.DOJ.ToShortDateString() + " " + emp.City);
            }

            //d. Display details of all the employee whose Last Name start with S:
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("D. Display details of all the employee whose Last Name start with S ");
            
            var employeesWithLastNameStartingWithS = from emp in emplist
                                                     where emp.LastName.StartsWith("S")
                                                     select emp;
            foreach (var emp in employeesWithLastNameStartingWithS)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB.ToShortDateString() + " " + emp.DOJ.ToShortDateString() + " " + emp.City);
            }

            // e. Display a list of all the employee who have joined before 1/1/2015:
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("E. Display a list of all the employee who have joined before 1/1/2015");
            
            var employeesJoinedBefore2015 = from emp in emplist
                                            where emp.DOJ < new DateTime(2015, 1, 1)
                                            select emp;
            foreach (var emp in employeesJoinedBefore2015)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB.ToShortDateString() + " " + emp.DOJ.ToShortDateString() + " " + emp.City);
            }

            //f. Display a list of all the employee whose date of birth is after 1/1/1990:

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("F. Display a list of all the employee whose date of birth is after 1/1/1990 ");
            
            var employeesBornAfter1990 = from emp in emplist
                                         where emp.DOB > new DateTime(1990, 1, 1)
                                         select emp;
            foreach (var emp in employeesBornAfter1990)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB.ToShortDateString() + " " + emp.DOJ.ToShortDateString() + " " + emp.City);
            }

            // g. Display a list of all the employee whose designation is Consultant and Associate

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("G. Display a list of all the employee whose designation is Consultant and Associate ");
            
            var empConsultantAssociate = emplist.Where(emp => emp.Title == "Consultant" || emp.Title == "Associate");
            foreach (var emp in empConsultantAssociate)
            {
                Console.WriteLine($"{emp.EmployeeID} {emp.FirstName} {emp.LastName} {emp.Title} {emp.DOB.ToShortDateString()} {emp.DOJ.ToShortDateString()} {emp.City}");
            }

            // h. Display total number of employees

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("H. Display total number of employees ");
            
            var totalEmp = emplist.Count;
            Console.WriteLine($"Total number of employees: {totalEmp}");

            //i. Display total number of employees belonging to “Chennai”

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("I. Display total number of employees belonging to “Chennai” ");
           
            var totalEmpChennai = emplist.Count(emp => emp.City == "Chennai");
            Console.WriteLine($"Total number of employees in Chennai: {totalEmpChennai}");

            // j. Display highest employee id from the list

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("J. Display highest employee id from the list ");
           
            var maxEmpID = emplist.Max(emp => emp.EmployeeID);
            Console.WriteLine($"Highest Employee ID: {maxEmpID}");

            //k. Display total number of employee who have joined after 1/1/2015

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("K.Display total number of employee who have joined after 1/1/2015 ");

            var totalEmpJoinedAfter2015 = emplist.Count(emp => emp.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"Total number of employees joined after 1/1/2015: {totalEmpJoinedAfter2015}");

            //l. Display total number of employee whose designation is not “Associate”

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine(" L.Display total number of employee whose designation is not “Associate” ");
            var totalEmpNotAssociate = emplist.Count(emp => emp.Title != "Associate");
            Console.WriteLine($"Total number of employees not in Associate designation: {totalEmpNotAssociate}");

            //m. Display total number of employee based on City

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("M.Display total number of employee based on City ");

            var empByCity = emplist.GroupBy(emp => emp.City)
                       .Select(cityGroup => new { City = cityGroup.Key, Count = cityGroup.Count() });
            foreach (var emp in empByCity)
            {
                Console.WriteLine($"Total number of employees in {emp.City}: {emp.Count}");
            }

            // n. Display total number of employee based on city and title

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("N.Display total number of employee based on city and title");
           
            var empByCityAndTitle = emplist.GroupBy(emp => new { emp.City, emp.Title })
                               .Select(cityTitleGroup => new { City = cityTitleGroup.Key.City, Title = cityTitleGroup.Key.Title, Count = cityTitleGroup.Count() });
            foreach (var emp in empByCityAndTitle)
            {
                Console.WriteLine($"Total number of {emp.Title} employees in {emp.City}: {emp.Count}");
            }

            // o. Display total number of employee who is youngest in the list

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("O.Display total number of employee who is youngest in the list ");
            var youngestEmp = emplist.OrderBy(emp => emp.DOB).First();
            Console.WriteLine($"Youngest employee: {youngestEmp.FirstName} {youngestEmp.LastName}");


            Console.ReadLine();
        }
    }
}
