using HandsOnGit;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using Newtonsoft.Json;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace TestProjectTaskC
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<School> schoolList = new List<School>();

            string fileSchool = "./../../../files/School.txt";
            string text = Helper.Read(fileSchool);

            text = text.Replace(",},", "}*").Replace("[", "").Replace(",}]", "}");
            string[] arr = text.Split('*');

            for (int i = 0; i < arr.Length; i++)
                schoolList.Add(JsonSerializer.Deserialize<School>(arr[i]));

            Assert.Equal(schoolList.ElementAt(0).ToString(), JsonSerializer.Deserialize<School>(arr[0]).ToString());
            Assert.Equal(schoolList.ElementAt(1).ToString(), JsonSerializer.Deserialize<School>(arr[1]).ToString());

            //string objToJson0 = JsonConvert.SerializeObject(schoolList.ElementAt(0));
            //string objToJson1 = JsonConvert.SerializeObject(schoolList.ElementAt(1));

            //Assert.Equal(objToJson0, arr[0] );
            //Assert.Equal(objToJson1, arr[1] );

        }
    }
}