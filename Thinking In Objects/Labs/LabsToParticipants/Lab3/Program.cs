using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee();

            StoreData(Emp);

            ShowData(Emp);
        }

        static void StoreData(Employee Emp)
        {
            
        }

        static void ShowData(Employee Emp)
        {

            //----------------Display the employee information
            Console.WriteLine("Employee Id : ");
            Console.WriteLine("Employee Name : ");
            Console.WriteLine("Employee Gender : ");

            Console.WriteLine("Employee Address : --------------");
            Console.WriteLine("Address 1 : ");
            Console.WriteLine("Address 2 : ");
            Console.WriteLine("City : ");
            Console.WriteLine("PinCode : ");
            Console.WriteLine("----------------------------------");

            Console.ReadLine();
        }
    }
}
