// Same namespace so can be accessed by any other class in the same namespace
namespace CatWorx.BadgeMaker
{
    class Employee
    {
        private string FirstName;
        private string LastName;
        private int Id;
        private string PhotoUrl;
        public Employee(string firstName, string lastName, int id, string photoUrl) {
            //Public PascalCase, private camelCase
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            PhotoUrl = photoUrl;
        }
        public string GetName() {
            return FirstName + " " + LastName;
        }
        public int GetId() {
            return Id;
        }

        public string GetPhotoUrl() {
            return PhotoUrl;
        }

    }
}