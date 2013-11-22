using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }
        // to loosen some coupling refactored this method to take 2 args instead of one
        public bool IsOlderThan(Student firstStudent, Student secondStudent)
        {
            DateTime firstDate =
                DateTime.Parse(firstStudent.OtherInfo.Substring(firstStudent.OtherInfo.Length - 10));
            DateTime secondDate =
                DateTime.Parse(secondStudent.OtherInfo.Substring(secondStudent.OtherInfo.Length - 10));
            if (firstDate > secondDate)
            {
                return true;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
