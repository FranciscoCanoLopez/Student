using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Person : NamePerson
    {
        private string birthDate;

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string GeneratePerson()
        {
            return ($"{GenerateName()}\nBirthdate: {birthDate}");
        }
    }
}
