using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frederico_Alexandre_Lab06_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeController controller = EmployeeController.GetInstance();
            SortedDictionary<int, Employee> employees = new SortedDictionary<int, Employee>();
            Employee Employee01 = new Employee("Employee 01" , 1000.00);
            Employee Employee02 = new Employee("Employee 02" , 1500.00);
            Employee Employee03 = new Employee("Employee 03" , 1420.00);
            Employee Employee04 = new Employee("Employee 04" , 1020.00);
            Employee Employee05 = new Employee("Employee 05" , 1001.00);
            Employee Employee06 = new Employee("Employee 06" , 1030.00);

            Console.WriteLine("Inserting Employees.");
            controller.AddDictionaryItem(employees, Employee01);
            controller.AddDictionaryItem(employees, Employee02);
            controller.AddDictionaryItem(employees, Employee03);
            controller.AddDictionaryItem(employees, Employee04);
            controller.AddDictionaryItem(employees, Employee05);
            controller.AddDictionaryItem(employees, Employee06);

            Console.WriteLine();
            Console.WriteLine("Printing The Dictionary at beginning:");
            controller.PrintDictionary(employees);

            Console.WriteLine();
            Console.WriteLine("Search for the Employee with the highest salary...");
            Employee eMaxSalary = controller.MaxDictionaryItem(employees);
            Console.WriteLine();
            Console.WriteLine("The employee with the highest salary is: " + eMaxSalary);
            Console.WriteLine();
            Console.WriteLine("Search for: " + eMaxSalary);
            int searchResult = controller.SearchDictionaryItem(employees, eMaxSalary);
            if (searchResult > -1)
            {
                Console.WriteLine("The employee " + eMaxSalary + " is in: " + searchResult + " position!!!");
            }
            else
            {
                Console.WriteLine("The employee " + eMaxSalary + " was not found!!!");
            }
            Console.WriteLine();
            Console.WriteLine("Removing the employee with the highest salary...");
            controller.RemoveDictionaryItem(employees, eMaxSalary);

            Console.WriteLine();
            Console.WriteLine("Search for: " + eMaxSalary);
            searchResult = controller.SearchDictionaryItem(employees, eMaxSalary);
            if (searchResult > -1)
            {
                Console.WriteLine("The employee " + eMaxSalary + " is in index: " + searchResult +  " !!!");
            } else
            {
                Console.WriteLine("The employee " + eMaxSalary + " was not found!!!");
            }
            Console.WriteLine();
            Console.WriteLine("Search for the new Employee with the highest salary...");
            eMaxSalary = controller.MaxDictionaryItem(employees);
            Console.WriteLine("The employee with the highest salary is: " + eMaxSalary);

            Console.WriteLine();
            Console.WriteLine("Printing The Dictionary at end:");
            controller.PrintDictionary(employees);
        }
    }
}
