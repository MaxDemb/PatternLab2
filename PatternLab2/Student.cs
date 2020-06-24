using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PatternLab2.EducationalInstitutions;

namespace PatternLab2
{
    public class Student
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Age")]
        public int Age { get; set; }
        [JsonProperty("AverageMark")]
        public int AverageMark { get; set; }
        [JsonProperty("Course")]
        public int Course { get; set; }
        [JsonProperty("Institution")]
        public string Institution { get; set; }
        public IEducationalInstitution educationalInstitutionObject { set; get; }

        public void ShowInfoAboutFutureEducation()
        {

            string Message = educationalInstitutionObject.GetInfoAboutFutureEducation(this);
            Console.WriteLine(Message);
            //if(Institution == Institutions.College)
            //{
            //    College.GetInfoAboutFutureEducation(this);
            //}
            //else if (Institution == Institutions.School)
            //{
            //    School.GetInfoAboutFutureEducation(this);
            //}
            //else if (Institution == Institutions.School)
            //{
            //    University.GetInfoAboutFutureEducation(this);
            //}

        }
                                                                                                                       
    }
}
