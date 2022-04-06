// Same namespace so can be accessed by any other class in the same namespace
namespace CatWorx.BadgeMaker
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public int Id;
        public string PhotoUrl;
        public Employee(string firstName, string lastName) {
            //Public PascalCase, private camelCase
            FirstName = firstName;
            LastName = lastName;
        }
        public string GetName() {
            return FirstName + " " + LastName;
        }

    }
}