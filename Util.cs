// Import correct packages
using System;
using System.Collections.Generic;
using System.IO;


namespace CatWorx.BadgeMaker
{
    // Class will be a collection of general methods that can be used
    // over and over
    class Util 
    {
        // Method declared as stsatic
        public static void PrintEmployees(List<Employee> employees)
        {

            for (int i = 0; i < employees.Count; i++) 
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                // String.Format works like literals in JS
                // argument 0 left align padded 10
                // \t tab
                // argument 1 left align padded 20
                // \t tab
                // argument 2  no formatting
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
            }
            
        }

        public static void MakeCSV(List<Employee> employees)
        {
            // Does folder exist?
            if (!Directory.Exists("data"))
            {
                //Lets create it
                Directory.CreateDirectory("data");
            }

            // Using will use the following code, then remove it from memory
            using (StreamWriter file = new StreamWriter("data/employess.csv"))
            {
                // StreamWrite code goes here
                file.WriteLine("ID, Name, PhotoUrl");
                //Loop over employees
                for (int i = 0; i < employees.Count; i++)
                {
                    // Write each employee to the file
                    string template = "{0},{1},{2}";
                    file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
                }
            }

        }

     }// end Class Util




}// end namespace