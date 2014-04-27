using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Methods
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }
        
        public bool IsOlderThan(Student compareStudent)
        {
            DateTime currentStudentDate = this.ExtractDateFromInfo();
            DateTime compareStudentDate = compareStudent.ExtractDateFromInfo();
            if (currentStudentDate < compareStudentDate)
            {
                return true;
            }
            else if (currentStudentDate > compareStudentDate)
            {
                return false;
            }
            else
            {
                throw new ArgumentException("Can not compare equal dates.");
            }
        }

        /*To simplify the extraxtion method from the previous method.*/
        private DateTime ExtractDateFromInfo() 
        {
            string datePattern = @"\d{2}\.\d{2}\.\d{4}";
            string dateAsString = Regex.Match(this.OtherInfo, datePattern).ToString();
            string parseFormat = "dd.MM.yyyy";
            DateTime outputDate = DateTime.ParseExact(dateAsString, parseFormat,
                CultureInfo.InvariantCulture);

            return outputDate;
        }
    }
}