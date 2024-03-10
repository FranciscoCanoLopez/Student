using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class NamePerson
    {
        private string name;
        private string fatherLastName;
        private string motherLastName;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string FatherLastName
        {
            get { return fatherLastName; }
            set { fatherLastName = value; }
        }

        public string MotherLastName
        {
            get { return motherLastName; }
            set { motherLastName = value; }
        }
        public string GenerateName()
        {
            return $"{name} {fatherLastName} {motherLastName}";
        }
    }
}
