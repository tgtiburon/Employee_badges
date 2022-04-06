using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {   

        static List<string> GetEmployees() 
        {
            List<string> employees = new List<string>();
            while (true) 
            {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                string input = Console.ReadLine();
                if (input == "") 
                {
                    break;
                }
                // Create a new Employee instance
                Employee currentEmployee = new Employee(input, "Smith");
               
                employees.Add(currentEmployee.GetName());
            


            }
            return employees;
        }

        static void PrintEmployees(List<string> employees)
        {
            for (int i = 0; i < employees.Count; i++) 
            {
                Console.WriteLine(employees[i]);
            }
            
        }


        // Main is entry point
        // void returns nothing
        // static, class instance so we don't have to create a 
        // new instance before using.
        static void Main(String[] args)
        {
          // This is our employee getting code now
          // will return a List of strings
          List<string> employees = GetEmployees();
          PrintEmployees(employees);
        }
    
    }// end of Class Program
}