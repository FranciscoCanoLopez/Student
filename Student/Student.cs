using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student:Person , IStudent
    {
        private string enrollment;

        public string Enrollment
        {
            get { return enrollment; }
            set { enrollment = value; }
        }
        private string race;

        public string Race
        {
            get { return race; }
            set { race = value; }
        }

        private string average;

        public string Average
        {
            get { return average; }
            set { average = value; }
        }
        public string GenerateStudent
        {
            get; set;
        }
        string IStudent.GenerateStudent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string StudentInfo(string info)
        {
            return $"{GeneratePerson()}\nCareer: {race}\nEnrollment: {enrollment}\nAverage: {average}";
        }
    }
}
