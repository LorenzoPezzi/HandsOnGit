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
