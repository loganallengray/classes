using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company company = new Company("Gray Industries");

            // Create three employees
            Employee Matt = new Employee("Matthew", "McDonald", "Loremaster");
            Employee Marek = new Employee("Marek", "Snyder", "Timekeeper");
            Employee Will = new Employee("Will", "Hedges", "Code Wizard");
            Employee Kaci = new Employee("Kaci", "Wooldridge", "Question Asker");

            // Assign the employees to the company
            company.Employees.Add(Matt);
            company.Employees.Add(Marek);
            company.Employees.Add(Will);
            company.Employees.Add(Kaci);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            company.ListEmployees();
        }
    }
}
