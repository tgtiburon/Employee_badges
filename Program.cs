using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {   
        // GetEmployees returns a List of Employee Objects

        static List<Employee> GetEmployees() 
        {
            // List of employee objects
            List<Employee> employees = new List<Employee>();
            while (true) 
            {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                string input = Console.ReadLine();
                if (input == "") 
                {
                    break;
                }
                // Add a console.readline for each value
                Console.Write("Enter last name: " );
                string lastName = Console.ReadLine();
                Console.Write("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.Write("Enter Photo Url: ");
                string photoUrl = Console.ReadLine();
                // Create a new Employee instance
                Employee currentEmployee = new Employee(input, lastName, id, photoUrl); 
               
                employees.Add(currentEmployee);
            


            }
            return employees;
        }


       


        // Main is entry point
        // void returns nothing
        // static, class instance so we don't have to create a 
        // new instance before using.
        static void Main(String[] args)
        {
          // This is our employee getting code now
          // will return a List of strings
          List<Employee> employees = GetEmployees();
          Util.PrintEmployees(employees);
          Util.MakeCSV(employees);
        }
    
    }// end of Class Program
}