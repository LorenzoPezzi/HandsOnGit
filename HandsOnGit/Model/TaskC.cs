
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace HandsOnGit.Model
{
    public class TaskC
    {

        public string path = "C:\\Users\\diana\\source\\repos\\HandsOnGit\\HandsOnGit\\Files\\School.txt";
        public bool Read()
        {
            string listOfSchool = File.ReadAllText(path);
            var json = JsonSerializer.Deserialize<List<School>>(listOfSchool);

            foreach(var schools in json)
            {
                Console.WriteLine(schools.Name+" "+ schools.Address+" "+schools.Id);
            }

            return true;
        }

        public class School
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public int Id { get; set; }
        }





    }
}
