using System;
using static System.Console;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Default test");
            Employee employeeObj = new Employee(500, "Asia", "Gibson", "D.O.E");
            Write(employeeObj.ToString());

            WriteLine("\n\nEmpolyee Benefits Test");
            EmployeeBenefits employeeBenefitObj = new EmployeeBenefits();
            AskUserName();
            employeeBenefitObj.Paybeforetaxes = AskUserEmployeeSales();

            Write("\n" + employeeBenefitObj); 

            ReadKey();
        }

        //for Employee Benifits class
        static string AskUserName()
        {
            WriteLine("Enter Employee name: ");
            string userInput = ReadLine();

            return userInput;
        }
        static decimal AskUserEmployeeSales()
        {
            WriteLine("Please enter sales: ");
            string userInput = ReadLine();
            decimal sales = decimal.Parse(userInput);

            return sales;
        }
    }
}
