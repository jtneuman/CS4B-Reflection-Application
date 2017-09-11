using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssembly
{
    public class Student
    {
        private int _id;

        public int Id { get { return _id; } set { _id = value; } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; private set; }
        public static string School { get; set; }

        public Student()
        {
            DateOfBirth = DateTime.MinValue;
        }

        public Student(DateTime dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }

        public int GetAge()
        {
            TimeSpan difference = DateTime.Now.Subtract(DateOfBirth);

            int ageInYears = (int)(difference.Days / 365.25);
            return ageInYears;
        }

        public int GetAge(DateTime dateOfBirth)
        {
            if (DateOfBirth == DateTime.MinValue ||
                dateOfBirth != DateOfBirth)
                DateOfBirth = dateOfBirth;

            return GetAge();
        }
    }
}
