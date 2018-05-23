using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{

    class Employee
    {
        public int EmployeeNo { get; set; }
        public string EmployeeName { get; set; }
        public decimal Salary { get; set; }

    }
    class Manager : Employee
    {
        public string Department { get; set; }
    }
    class Salesman : Employee
    {
        public decimal Commission { get; set; }
    }
    class Program
    {

        public static void ShowEmployeeDetails(Employee emp)
        {
            Console.WriteLine($"Employee   : {emp.EmployeeNo}");
            Console.WriteLine($"Employee Name   : {emp.EmployeeName}");
            Console.WriteLine($"Salary # : {emp.Salary}");


            if (emp is Manager )
            {
                var manager = (Manager)emp;
                Console.WriteLine($"Department  : {manager.Department}");
            }
            if (emp is Salesman salesman)
            {
                Console.WriteLine($"Commission  : {salesman.Commission}");
            }
            Console.WriteLine("-----------------------------");

         
        }

        static void Main(string[] args)
        {
            Manager m = new Manager() { EmployeeNo = 10, EmployeeName = "Ebubekir", Salary = 1000, Department = "SFE" };

            Salesman s = new Salesman() { EmployeeNo = 21, EmployeeName = "Doğan", Salary = 1000, Commission = 3000 };

            ShowEmployeeDetails(m);
            ShowEmployeeDetails(s);

        }
    }
}
