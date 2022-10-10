using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGit
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SchoolId { get; set; }

        public Student(string firstName, string lastName, int schoolId)
        {
            FirstName = firstName;
            LastName = lastName;
            SchoolId = schoolId;
        }
    }
}
