using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLab2.EducationalInstitutions
{
    public class University : IEducationalInstitution
    {

        public string GetInfoAboutFutureEducation(Student student)
        {

            string Message = "";
            bool canContinue = false;
            if (student.AverageMark > 4)
            {
                canContinue = true;
            }
           
            if (student.Course == 4)
            {
                Message += "This is last course.";
            }
            else if(canContinue == true)
            {
                Message += "Your AverageMark is sufficient to continue your education!";
            }
            else if(canContinue == false)
            {
                Message += "Your AverageMark is not sufficient to continue your education!";

            }

            if (Message == "")
            {
                throw new Exception("Unknow error!");
            }
            return Message;
        }
    }
}
