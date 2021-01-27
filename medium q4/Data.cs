using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium_q1
{
    class Data
    {
        public static List<Employee> Employees = new List<Employee>();
        public static void PrintEmployee()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("\nPlease enter the employee ID\n");
            int key = Convert.ToInt32(Console.ReadLine());
            var age = (from Employee in Employees where Employee.Id == key select Employee.Age);
            int y=0;
            foreach(var i in age)
                y = Convert.ToInt32(i);

            var emp = (from Employee in Employees where Employee.Age >= y select Employee);
            Console.WriteLine("\nEmployees who are older than employee with ID {0} ({1} years old ) are \n",key,y);

            foreach (var i in emp)
            {

                Console.WriteLine(i+"\n");
            }

        }
        public static void SortAndPrintEmployees()
        {

            Employees.RemoveAt(Employees.Count - 1);
            Data.Employees.Sort();
            Console.WriteLine("----------------------------");
            Console.WriteLine("\nEmployee list after sorting \n");
            Data.Employees.ForEach(employee => Console.WriteLine(employee+"\n"));
            



        }

    }
}