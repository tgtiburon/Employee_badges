using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {   
       
        // Main is entry point
        // void returns nothing
        // static, class instance so we don't have to create a 
        // new instance before using.
        static void Main(String[] args)
        {
          // This is our employee getting code now
          // will return a List of strings
         // List<Employee> employees = GetEmployees();
         // Not sure about the list<employee>
          List<Employee> employees = PeopleFetcher.GetFromApi();
          Util.PrintEmployees(employees);
          Util.MakeCSV(employees);
          Util.MakeBadges(employees);
        }
    
    }// end of Class Program
}