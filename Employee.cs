using System;
using static System.Console;

namespace EmployeeApp
{
    class Employee
    {
        private string firstName, lastName, jobDescription, department, dateHired;
        private int employeeNumber;
        private double monthSal;

        public Employee()
        {

        }

        public Employee(string fname, string lname)
        {
            firstName = fname;
            lastName = lname;
        }

        public Employee(int empNum, string fname, string lname)
        {
            employeeNumber = empNum;
            firstName = fname;
            lastName = lname;
        }

        public Employee(int empNum, string fname, string lname, string dept)
        {
            employeeNumber = empNum;
            firstName = fname;
            lastName = lname;
            department = dept;
        }

        public string Firstname
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }


        }

        public string Lastname
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }


        }

        public string Jobdescription
        {
            get
            {
                return jobDescription;
            }

            set
            {
                jobDescription = value;
            }


        }

        public string Department
        {
            get
            {
                return department;
            }

            set
            {
                department = value;
            }


        }
        public string Datehired
        {
            get
            {
                return dateHired;
            }

            set
            {
                dateHired = value;
            }


        }

        public int Employeenumber
        {
            get
            {
                return employeeNumber;
            }

            set
            {
                employeeNumber = value;
            }

        }

        public double Monthlysal
        {
            get
            {
                return monthSal;
            }

            set
            {
                monthSal = value;
            }

        }

        public string FirstNameLast()
        {
            return firstName + " " + lastName;
        }

        public string lLastNameFirst()
        {
            return lastName + ", " + firstName;
        }

        public override string ToString()
        {
            return "Employee Number: " + employeeNumber + "\nEmpoyee Name: " + FirstNameLast().ToString() +
                "\nDate Hired: " + dateHired + "\nJob Description: " + jobDescription + "\nDepartment: " +
                department + "\nMonthly Salary: " + monthSal.ToString("c");

        }


    }
}
