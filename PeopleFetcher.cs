using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;


namespace CatWorx.BadgeMaker
{

    class PeopleFetcher 
    {
        //Code from GetEmployees() in Program.cs
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

        public static List<Employee> GetFromApi()
        {
            List<Employee> employees = new List<Employee>();
            using (WebClient client = new WebClient())
            {
              
                //Image example
               // Image.FromStream(client.OpenRead("image.png"));
               // client.DownloadString is Synchronous...it waits before moving on
                string response = client.DownloadString("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");
                JObject json = JObject.Parse(response);

                // Console.WriteLine(json.SelectToken("results[0].name.first"));
                // Console.WriteLine(json.SelectToken("results[1].name.first"));
                // Console.WriteLine(json.SelectToken("results[2].name.first"));

                 foreach (JToken token in json.SelectToken("results")) {
                // Parse JSON data
                Employee emp = new Employee
                (
                    token.SelectToken("name.first").ToString(),
                    token.SelectToken("name.last").ToString(),
                    Int32.Parse(token.SelectToken("id.value").ToString().Replace("-", "")),
                    token.SelectToken("picture.large").ToString()
                );
                employees.Add(emp);
               
             }
 
            }
           

           

           return employees;
        }

        
    }

}// end namespace