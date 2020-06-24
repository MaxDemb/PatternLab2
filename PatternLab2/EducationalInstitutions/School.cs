using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLab2.EducationalInstitutions
{
    public class School : IEducationalInstitution
    {

        public string GetInfoAboutFutureEducation(Student student)
        {

            string Message = "";
            bool canContinue = false;
            if(student.AverageMark > 60)
            {
                Message += "Your AverageMark is sufficient to continue your education!";
                canContinue = true;
            }
            else
            {
                Message += "Your AverageMark is not sufficient to continue your education!";
            }
            if(student.Course == 11)
            {
                Message += "This is last course.";
                if (canContinue)
                {
                    Message += "But you can pass exams and enter the University or College!";
                }
            }

            if(Message == "")
            {
                throw new Exception("Unknow error!");
            }
            return Message;
        }
    }
}
