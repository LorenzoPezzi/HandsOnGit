
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
            //using (var sr = new StreamReader(path))
            //{


            //    List<string> listOfSchools = new List<string>();
            //    var schoolFile = File.ReadAllLines(path);
            //    foreach (var line in schoolFile)
            //    {
            //        if (line.Contains("name"))
            //        {
            //          line.Substring(line.IndexOf(":"), line.IndexOf(","));
            //          listOfSchools.Add(line.Trim());
            //        }
            //    }
            //}

            string listOfSchool = File.ReadAllText(path);
            var json = JsonSerializer.Deserialize<List<School>>(listOfSchool); //.Select((s => s.Split(',')));
            //JsonConvert.SerializeObject(ListOfSchool);
            foreach(var schools in json)
            {
                Console.WriteLine(schools);
            }
            

            return true;
        }

        public class School
        {

            public string name { get; set; }
            public string address { get; set; }
            public int id { get; set; }


        }





    }
}
