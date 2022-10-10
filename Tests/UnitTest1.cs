using HandsOnGit.Model;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var schoolList = FileManager.ConvertJsonSchoolToListSchool();
            Assert.Equal(2, schoolList.Count);
            Assert.True(schoolList.GetType() == typeof(List<School>));

               
        }
        [Fact]
        public void Test2()
        {
            var teachersList = JsonFileManager.DeserializeObjects<Teacher>("Teacher.txt");
            Assert.True(teachersList.Count >= 2);
            Assert.True(JsonFileManager.WriteOnTeacherFile("Teacher.txt", teachersList));
        }

        [Fact]
        public void Test3()
        {
                Teacher student = new Teacher("Pinco", "Pallino", 2);
                Assert.True(JsonFileManager.WriteStudentOnFile(student, "School.txt"));
            
        }

    }
}