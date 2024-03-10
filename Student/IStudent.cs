using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal interface IStudent
    {
        string GenerateStudent { get; set; }
        string StudentInfo(string Info);
    }
}
