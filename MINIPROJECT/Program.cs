using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace MINI_PROJECT
{
    class Program
    {
        public static SqlConnection getconnection()
        {
            SqlConnection con = new SqlConnection("Data Source = LENOVO; Initial Catalog = master;" + "Integrated Security = true;");
            con.Open();
            return con;
        }
        public class Database
        {
            public static void CloseConnection(SqlConnection con)
            {
                con.Close();
            }
            public static void InsertEmp(decimal EMPNO, string ENAME, string JOB, decimal MGR, decimal SAL, decimal COMM, decimal DEPTNO)
            {
                using (SqlConnection con = getconnection()) 
                using (SqlCommand cmd = new SqlCommand("InsertEmp", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EMPNO", EMPNO);
                    cmd.Parameters.AddWithValue("@ENAME", ENAME);
                    cmd.Parameters.AddWithValue("@JOB", JOB);
                    cmd.Parameters.AddWithValue("@MGR", MGR);
                    cmd.Parameters.AddWithValue("@SAL", SAL);
                    cmd.Parameters.AddWithValue("@COMM", COMM);
                    cmd.Parameters.AddWithValue("@DEPTNO", DEPTNO);
                    cmd.ExecuteNonQuery();
                }
            }
            public static void DeleteEmp(decimal EMPNO)
            {
                using (SqlConnection con = getconnection())
                using (SqlCommand cmd = new SqlCommand("DeleteEmp", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EMPNO", EMPNO);
                    cmd.ExecuteNonQuery();
                }
            }
            public static void UpdateEmp(decimal EMPNO, string ENAME, decimal SAL)
            {
                using (SqlConnection con = getconnection()) 
                using (SqlCommand cmd = new SqlCommand("UpdateEmp", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EMPNO", EMPNO);
                    cmd.Parameters.AddWithValue("@ENAME", ENAME);
                    cmd.Parameters.AddWithValue("@SAL", SAL);
                    cmd.ExecuteNonQuery();
                }
            }
            public static DataTable SelectEmp()
            {
                using (SqlConnection con = getconnection())
                using (SqlCommand cmd = new SqlCommand("SelectEmp", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter Da = new SqlDataAdapter(cmd))
                    {
                        DataTable dbt = new DataTable();
                        Da.Fill(dbt);
                        return dbt;
                    }
                }
            }

            
            static void Main(String[] args)
            {
                while (true)
                    {
                        Console.WriteLine("Select a option: ");
                        Console.WriteLine("1. Insert new data: ");
                        Console.WriteLine("2. Delete a data: ");
                        Console.WriteLine("3. Update a data: ");
                        Console.WriteLine("4. Select a data: ");
                        Console.WriteLine("5. Exit");

                        string option = Console.ReadLine();
                        Console.WriteLine();
                        switch (option)
                        {
                            case "1":
                                Console.WriteLine("Enter Employee no: ");
                                decimal EMPNO = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Employee name: ");
                                string ENAME = Console.ReadLine();
                                Console.WriteLine("Enter Employee job: ");
                                string JOB = Console.ReadLine();
                                Console.WriteLine("Enter Manager no: ");
                                decimal MGR = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Enter salary of Employee: ");
                                decimal SAL = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Enter commission of Employee: ");
                                decimal COMM = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Department no of Employee: ");
                                decimal DEPTNO = decimal.Parse(Console.ReadLine());
                                Database.InsertEmp(EMPNO, ENAME, JOB, MGR, SAL, COMM, DEPTNO);
                                Console.WriteLine("Employee added Successfully...");
                                break;

                            case "2":
                                Console.Write("Enter Employee no: ");
                                EMPNO = int.Parse(Console.ReadLine());
                                Database.DeleteEmp(EMPNO);
                                Console.WriteLine("Employee deleted successfully...");
                                break;

                            case "3":
                                Console.Write("Enter employee no: ");
                                EMPNO = decimal.Parse(Console.ReadLine());
                                Console.Write("Enter employee name: ");
                                ENAME = Console.ReadLine();
                                Console.Write("Enter employee salary: ");
                                SAL = decimal.Parse(Console.ReadLine());
                                Database.UpdateEmp(EMPNO, ENAME, SAL);
                                Console.WriteLine("Employee updated successfully...");
                                break;

                            case "4":
                                DataTable employees = Database.SelectEmp();
                                foreach (DataRow row in employees.Rows)
                                {
                                    Console.WriteLine($"ID: {row["EMPNO"]}, Name: {row["ENAME"]}, Job: {row["job"]}, ManagerNo: {row["MGR"]}, Salaray: {row["Sal"]}, Commission: {row["COMM"]}, Department No: {row["DEPTNO"]}");
                                }
                                break;

                            case "5":
                                Console.WriteLine("Exit");
                                return;

                            default:
                                Console.WriteLine("Invalid option");
                                break;
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
