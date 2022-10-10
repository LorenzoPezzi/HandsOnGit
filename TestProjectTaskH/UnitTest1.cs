using System;
using HandsOnGit;
using System.Text.Json;

namespace TestProjectTaskH
{
    public class UnitTest1
    {
        [Fact]

        public void ReadStudentFile()
        {
            var student1 = new Student("Riccardo", "Stagni", 0);
            var student2 = new Student("Francesco", "Fera", 1);

            Student[] studentArray = { student1, student2 };

            string jsonString = JsonSerializer.Serialize(studentArray);
            string fullPath = "C:\\Users\\UTENTE\\Desktop\\handson\\HandsOnGit\\Files\\Student.txt";
            string resultOfReading = "";

            using (StreamReader sr = new StreamReader(fullPath))
            {
                resultOfReading = sr.ReadLine();
            }

            Assert.True(resultOfReading == jsonString);
        }

    }

}