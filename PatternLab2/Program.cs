using Nancy.Json;
using Newtonsoft.Json;
using PatternLab2.EducationalInstitutions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = "";
            using (StreamReader r = new StreamReader("file.json"))
            {
                json = r.ReadToEnd();
            }
            if(json == "")
            {
                throw new Exception("File is empty");
            }

            //Console.WriteLine(json);
           // Console.WriteLine();
           // Console.WriteLine();


            List<Student> items = JsonConvert.DeserializeObject<List<Student>>(json);

            foreach(var i in items)
            {
                if (i.Institution == "School")
                {
                    i.educationalInstitutionObject = new School();
                }
                else if (i.Institution == "University")
                {
                    i.educationalInstitutionObject = new University();
                }
                else if (i.Institution == "College")
                {
                    i.educationalInstitutionObject = new College();
                }
                i.ShowInfoAboutFutureEducation();
            }
            Console.ReadLine();
        }
    }
}
